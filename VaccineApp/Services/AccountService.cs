namespace VaccineApp.Services
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using VaccineApp.DTO;
    using VaccineApp.Entities;
    using VaccineApp.Repositories;
    using VaccineApp.Services.Interfaces;

    public class AccountService : IAccountService
    {
        private ITokenService _tokenService;
        private IUserRepo _userRepo;
        private DatabaseContext _context;

        public AccountService(ITokenService tokenService, IUserRepo userRepo, DatabaseContext context)
        {
            _tokenService = tokenService;
            _userRepo = userRepo;
            _context = context;
        }

        public async Task<AccountDto> LoginAsync(string email, string password)
        {
            var user = await _context.Users.Include(x => x.Login)
                                     .SingleOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username");
            }

            var hmac = new HMACSHA512(user.Login.PasswordSalt);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] != user.Login.PasswordHash[i])
                {
                    throw new UnauthorizedAccessException("Invalid password");
                }
            }

            return new AccountDto
                   {
                       Email = user.Email,
                       Token = _tokenService.CreateToken(user),
                   };
        }

        public async Task<AccountDto> RegisterAsync(RegisterDto registerDto)
        {
            var hmac = new HMACSHA512();
            User user = new User
                        {
                            FirstName = registerDto.FirstName.ToLower(),
                            Surname = registerDto.SurName.ToLower(),
                            BirthDate = registerDto.BirthDate,
                            Address = registerDto.Address,
                            Email = registerDto.Email,
                            Login = new Login
                                    {
                                        PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                                        PasswordSalt = hmac.Key,
                                    },
                            Appointments = new System.Collections.Generic.List<Appointment>(),
                        };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new AccountDto
                   {
                       Email = user.Email,
                       Token = _tokenService.CreateToken(user),
                   };
        }

        public async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email);
        }

        public async Task UpdateUserPassword(string email, string newpassword)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            using var hmac = new HMACSHA512();
            var login = new Login()
                        {
                            Id = user.LoginId,
                            PasswordSalt = hmac.Key,
                            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(newpassword))
                        };

            _context.Logins.Attach(login);
            _context.Entry(login)
                    .Property(x => x.PasswordHash)
                    .IsModified = true;

            _context.Entry(login)
                    .Property(y => y.PasswordSalt)
                    .IsModified = true;

            await _context.SaveChangesAsync();
        }
    }
}