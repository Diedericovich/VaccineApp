namespace VaccineApp.Tests
{
    using System.Collections.Generic;

    using Microsoft.Extensions.Configuration;

    using Moq;

    using NUnit.Framework;

    using VaccineApp.Entities;
    using VaccineApp.Services;

    [TestFixture]
    public class TokenServiceTest
    {
        private Mock<IConfiguration> _config;

        private Mock<IConfigurationSection> _configSection;

        [SetUp]
        public void SetUp()
        {
        }

        private TokenService CreateService()
        {
            var inMemorySettings = new Dictionary<string, string>
                                   {
                                       { "TokenKey", "ThisKeyIsVeryVeryImportantAlsoIAmAGoblin" },
                                   };

            IConfiguration configuration = new ConfigurationBuilder().AddInMemoryCollection(inMemorySettings)
                                                                     .Build();
            return new TokenService(configuration);
        }

        [Test]
        public void CreateToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            User testuser = new User()
                            {
                                Email = "test"
                            };

            // Act
            var temp = service.CreateToken(testuser);
            int tokenlength = temp.Length;

            // Assert
            Assert.AreEqual(
                215,
                tokenlength);
        }
    }
}