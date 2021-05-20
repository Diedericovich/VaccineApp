namespace VaccineApp.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using DTO;

    using Entities;

    using Helpers;

    using Moq;
    using Moq.Language.Flow;

    using NUnit.Framework;
    using NUnit.Framework.Internal;

    using Repositories;

    using Services;

    [TestFixture]
    public class UserServiceTest
    {
        private User _user;

        private Mock<IUserRepo> _repo;

        private List<User> _userList;

                [SetUp]
        public void Setup()
        {
            _repo = new Mock<IUserRepo>();
            _userList = new List<User>();

            _user = new User
            {
                Address = "TestAddress",
                Appointments = null,
                BirthDate = DateTime.Today,
                FirstName = "Pieter",
                Surname = "Pan"
            };

            for (var i = 0; i < 10; i++)
            {
                _userList.Add(_user);
            }
        }

        [TestCase(1)]
        public async Task GetUserIsNotNull(int id)
        {
            _repo.Setup(repo => repo.GetAsync(1)).ReturnsAsync(_user);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());
            var testService = new UserService(_repo.Object, testconfig.CreateMapper());

            UserDto result = await testService.GetUserAsync(1);
            string name1 = result.FirstName;
            string name2 = _user.FirstName;

            Assert.AreEqual(name2, name1);
        }

        [Test]
        public async Task GetUsersReturnsUsers()
        {
            _repo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(_userList);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());
            var testService = new UserService(_repo.Object, testconfig.CreateMapper());

            List<UserDto> result = await testService.GetUsersAsync();
            Assert.AreEqual(_userList.Count, result.Count);
        }
    }
}