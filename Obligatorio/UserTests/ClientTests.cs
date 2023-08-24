using ObligatorioFernandezMorandi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserTests
{
    [TestClass]
    public class ClientTests
    {

        private const string ValidUserName = "JavierMilan";
        private const string SensitiveUserName = "jAVIERmILAN";
        private const string ValidPassword = "JaviMilan13";
        private DateTime ValidDate = DateTime.Today; 

        private User someUser;

        [TestInitialize]
        public void TestInit()
        {
            someUser = new User()
            {
                UserName = ValidUserName,
                Password = ValidPassword,
                Creation = ValidDate,
            };
        }

        [TestMethod]
        public void CreateProfileSuccessTest()
        {
            var user = new User()
            {
                UserName = ValidUserName,
                Password = ValidPassword,
                Creation = ValidDate, 
            };

            Assert.IsNotNull(user);
            Assert.AreEqual(user.UserName, ValidUserName);
            Assert.AreNotEqual(user.UserName, SensitiveUserName);
            Assert.AreEqual(user.Password, ValidPassword);
            Assert.AreEqual(user.Creation, ValidDate); 
            Assert.AreEqual(user.ToString(), ValidUserName); 
        }

        [TestMethod]
        public void GivenTheSameUserEqualsReturnsTrue() 
        {
            bool result = someUser.Equals(someUser);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenDifferentUsersEqualsReturnsFalse() 
        {
            var newUserName = "BigGarfFan37";
            var user = new User()
            {
                UserName = newUserName,
                Password = ValidPassword,
                Creation = ValidDate,
            };
            bool result = someUser.Equals(user);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName too short")]
        public void UserNameTooShort()
        {
            var ShortUserName = "jm";
            someUser.UserName = ShortUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName too long")]
        public void UserNameTooLong()
        {
            var LongUserName = "JavierMilanRigobertoLopezMendezPiemonteMessi";
            someUser.UserName = LongUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName must have no spaces")]
        public void UserNameBeginningWithSpace()
        {
            var BeginningSpaceUserName = " Javier";
            someUser.UserName = BeginningSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName must have no spaces")]
        public void UserNameWithSpace()
        {
            var MiddleSpaceUserName = "Javier Milan";
            someUser.UserName = MiddleSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName must have no spaces")]
        public void UserNameEndsWithSpace()
        {
            var EndSpaceUserName = "Javier ";
            someUser.UserName = EndSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "UserName must contain only letters and numbers")]
        public void UserNameNotAlphanumeric()
        {
            var NotAlphanumericUserName = "...javier...";
            someUser.UserName = NotAlphanumericUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Password must have at least one capital letter")]
        public void PasswordWithoutCapitalLetter()
        {
            var NoCapitalPassword = "javimilan13";
            someUser.Password = NoCapitalPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Password must have at least one number")]
        public void PasswordWithoutNumber()
        {
            var NoNumberPassword = "JaviMilan";
            someUser.Password = NoNumberPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Password too short")]
        public void PasswordTooShort()
        {
            var ShortPassword = "Jav1";
            someUser.Password = ShortPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Password too long")]
        public void PasswordTooLong()
        {
            var LongPassword = "JavierMilanRigobertoLopezMendezPiemonteMessi420";
            someUser.Password = LongPassword;
        }

    }
}
