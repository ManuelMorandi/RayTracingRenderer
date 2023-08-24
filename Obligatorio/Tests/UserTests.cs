using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UserTests
    {

        private const string ValidUserName = "JavierMilan";
        private const string SensitiveUserName = "jAVIERmILAN";
        private const string ValidPassword = "JaviMilan13";
        private DateTime ValidDate = DateTimeProvider.Now;

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
            var someDate = DateTime.Now;
            DateTimeProvider.Now = someDate;
            var user = new User()
            {
                UserName = ValidUserName,
                Password = ValidPassword,
                Creation = someDate, 
            };

            Assert.IsNotNull(user);
            Assert.AreEqual(user.UserName, ValidUserName);
            Assert.AreNotEqual(user.UserName, SensitiveUserName);
            Assert.AreEqual(user.Password, ValidPassword);
            Assert.AreEqual(user.Creation, someDate); 
            Assert.AreEqual(user.ToString(), ValidUserName); 
        }

        [TestMethod]
        public void GivenMinLenghthUserNameItGetsAddedCorrectly()
        {
            string MinLengthUserName = "abc";
            var UserWithMinLengthName = new User()
            {
                UserName = MinLengthUserName,
                Password = ValidPassword,
                Creation = ValidDate,
            };
            Assert.AreEqual(UserWithMinLengthName.UserName, MinLengthUserName);
        }

        [TestMethod]
        public void GivenMaxLenghthUserNameItGetsAddedCorrectly()
        {
            string MaxLengthUserName = "JoseAlbertoLopezRuiz";
            var UserWithMinLengthName = new User()
            {
                UserName = MaxLengthUserName,
                Password = ValidPassword,
                Creation = ValidDate,
            };
            Assert.AreEqual(UserWithMinLengthName.UserName, MaxLengthUserName);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario debe tener al menos 3 caracteres")]
        public void ThrowsExceptionWhenGivenTooShortUserName()
        {
            var ShortUserName = "jm";
            someUser.UserName = ShortUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario debe tener como maximo 20 caracteres")]
        public void ThrowsExceptionWhenGivenTooLongUserName()
        {
            var LongUserName = "JavierMilanRigobertoLopezMendezPiemonteMessi";
            someUser.UserName = LongUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario no puede tener espacios")]
        public void ThrowsExceptionWhenGivenUserNameBeginningWithSpace()
        {
            var BeginningSpaceUserName = " Javier";
            someUser.UserName = BeginningSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario no puede tener espacios")]
        public void ThrowsExceptionWhenGivenUserNameWithSpace()
        {
            var MiddleSpaceUserName = "Javier Milan";
            someUser.UserName = MiddleSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario no puede tener espacios")]
        public void ThrowsExceptionWhenGivenUserNameEndingWithSpace()
        {
            var EndSpaceUserName = "Javier ";
            someUser.UserName = EndSpaceUserName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "El nombre de usuario sólo puede tener letras y números")]
        public void ThrowsExceptionWhenGivenNotAlphanumericUserName()
        {
            var NotAlphanumericUserName = "...javier...";
            someUser.UserName = NotAlphanumericUserName;
        }

        [TestMethod]
        public void GivenMinLenghthPasswordItGetsAddedCorrectly()
        {
            string MinLengthPassword = "Ruiz5";
            var UserWithMinLengthPassword = new User()
            {
                UserName = ValidUserName,
                Password = MinLengthPassword,
                Creation = ValidDate,
            };
            Assert.AreEqual(UserWithMinLengthPassword.Password, MinLengthPassword);
        }

        [TestMethod]
        public void GivenMaxLenghthPasswordItGetsAddedCorrectly()
        {
            string MaxLengthPassword = "JoseAlbertoLopezRuiz12345";
            var UserWithMaxLengthPassword = new User()
            {
                UserName = ValidUserName,
                Password = MaxLengthPassword,
                Creation = ValidDate,
            };
            Assert.AreEqual(UserWithMaxLengthPassword.Password, MaxLengthPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La contraseña debe tener al menos una mayúscula")]
        public void ThrowsExceptionWhenGivenPasswordWithoutCapitalLetter()
        {
            var NoCapitalPassword = "javimilan13";
            someUser.Password = NoCapitalPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La contraseña debe tener al menos un número")]
        public void ThrowsExceptionWhenGivenPasswordWithoutNumbers()
        {
            var NoNumberPassword = "JaviMilan";
            someUser.Password = NoNumberPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La contraseña debe tener al menos 5 caracteres")]
        public void ThrowsExceptionWhenGivenTooShortPassword()
        {
            var ShortPassword = "Jav1";
            someUser.Password = ShortPassword;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "La contraseña debe tener como maximo 25 caracteres")]
        public void ThrowsExceptionWhenGivenTooLongPassword()
        {
            var LongPassword = "JavierMilanRigobertoLopezMendezPiemonteMessi420";
            someUser.Password = LongPassword;
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
            var NewUserName = "BigGarfFan37";
            var user = new User()
            {
                UserName = NewUserName,
                Password = ValidPassword,
                Creation = ValidDate,
            };
            bool result = someUser.Equals(user);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenNullEqualsReturnsFalse()
        {
            Assert.IsFalse(someUser.Equals(null));
        }

    }
}
