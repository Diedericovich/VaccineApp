namespace VaccineApp.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Moq;
    using Moq.Language.Flow;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using DTO;
    using Entities;
    using Helpers;
    using Repositories;
    using Services;

    [TestFixture]
    public class UserRepoTest
    {
        [SetUp]
        public void Setup()
        {
            mokMock = new Mock<IUserRepo>();

            fakeUser = new User
                       {
                           Address = "TestAddress",
                           Appointments = null,
                           BirthDate = DateTime.Today,
                           FirstName = "Pieter",
                           Surname = "Pan"
                       };

            for (var i = 0; i < 10; i++)
            {
                userList.Add(fakeUser);
            }
        }

        private User fakeUser;

        private Mock<IUserRepo> mokMock;

        private IUserRepo testRepo;

        private List<User> userList => new();

        [TestCase(1)]
        public async Task GetUserIsNotNull(int id)
        {
            mokMock.Setup(repo => repo.GetUserAsync(1)).ReturnsAsync(fakeUser);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());

            var testService = new UserService(mokMock.Object, testconfig.CreateMapper());

            UserDto result = await testService.GetUserAsync(1);
            string name1 = result.FirstName;
            string name2 = fakeUser.FirstName;

            Assert.AreEqual(name2, name1);
        }

        [Test]
        public async Task GetUsersReturnsUsers()
        {
            mokMock.Setup(repo => repo.GetUsersAsync()).ReturnsAsync(userList);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());

            var testService = new UserService(mokMock.Object, testconfig.CreateMapper());

            List<UserDto> result = await testService.GetUsersAsync();
            Assert.AreEqual(userList, result);
        }
    }
}