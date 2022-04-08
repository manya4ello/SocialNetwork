using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Linq;
using Xunit;

namespace SocialNetwork.BLL.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void TestOfTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void RegistrationThrowExceptionsTest()
        {
            var userService = new UserService();

            var testuser = new UserRegistrationData();
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

            testuser.FirstName = "Ivan";
        }

        [Fact]
        public void FindByEmailThrowExceptionsTest()
        {
            var userService = new UserService();
            Assert.Throws<UserNotFoundException>(() => userService.FindByEmail("thereisnosuchemail@no.no"));
            Assert.Throws<UserNotFoundException>(() => userService.FindByEmail("mail@mail.ru"));
        }


    }
}