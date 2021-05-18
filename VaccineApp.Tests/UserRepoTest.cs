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
        private User fakeUser;

        private Mock<IGenericRepo<User>> mokMock;
        private Mock<IGenericRepo<Vaccine>> mokVaxx;

        private IGenericRepo<User> testRepo;

        [SetUp]
        public void Setup()
        {
            mokMock = new Mock<IGenericRepo<User>>();
            mokVaxx = new Mock<IGenericRepo<Vaccine>>();

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

        private List<User> userList
        {
            get { return new(); }
        }

        [TestCase(1)]
        public async Task GetUserIsNotNull(int id)
        {
            mokMock.Setup(repo => repo.GetAsync(1)).ReturnsAsync(fakeUser);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());

            var testService = new UserService(mokMock.Object, mokVaxx.Object, testconfig.CreateMapper());

            UserDto result = await testService.GetUserAsync(1);
            string name1 = result.FirstName;
            string name2 = fakeUser.FirstName;

            Assert.AreEqual(name2, name1);
        }

        [Test]
        public async Task GetUsersReturnsUsers()
        {
            mokMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(userList);
            var testconfig = new MapperConfiguration(x => x.AddProfile<AutoMapperProfile>());

            var testService = new UserService(mokMock.Object, mokVaxx.Object, testconfig.CreateMapper());

            List<UserDto> result = await testService.GetUsersAsync();
            Assert.AreEqual(userList, result);
        }
    }
}