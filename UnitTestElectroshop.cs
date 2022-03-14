using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestElectroshop
    {
        public static string log_in_Account_admin = "Admin@gmail.com"; //Логин в аккаунте
        public static string pas_in_Account_admin = "Admin"; //Пароль в аккаунте
        public static string log_in_Account_manager = "manager3@gmail.com"; //Логин в аккаунте
        public static string pas_in_Account_manager = "Password"; //Пароль в аккаунте
        public static string log_in_Account_Glav_manager = "Glav-manager@gmail.com"; //Логин в аккаунте
        public static string pas_in_Account_Glav_manager = "GlavManager1"; //Пароль в аккаунте
        [TestMethod]
        public void Log_in_admin()
        {
                //Arrange
                string log = "Admin@gmail.com"; //логин для проверки 
                string pas = "Admin"; //пароль для проверки

                //Act
                bool success = Account_admin(log, pas); //проверка авторизации

                //Assert
                Assert.IsTrue(success); //Авторизация выполняется, если логин и пароль действительны.
                Assert.AreEqual(log, log_in_Account_admin); //Верный логин
                Assert.AreEqual(pas, pas_in_Account_admin); //Верный пароль

            
        }
        [TestMethod]
        public void Log_in_manager()
        {
            //Arrange
            string log = "manager3@gmail.com"; //логин для проверки 
            string pas = "Password"; //пароль для проверки

            //Act
            bool success = Account_manager(log, pas); //проверка авторизации

            //Assert
            Assert.IsTrue(success); //Авторизация выполняется, если логин и пароль действительны.
            Assert.AreEqual(log, log_in_Account_manager); //Верный логин
            Assert.AreEqual(pas, pas_in_Account_manager); //Верный пароль


        }
        [TestMethod]
        public void Log_in_glavmanager()
        {
            //Arrange
            string log = "Glav-manager@gmail.com"; //логин для проверки 
            string pas = "GlavManager1"; //пароль для проверки

            //Act
            bool success = Account_manager(log, pas); //проверка авторизации

            //Assert
            Assert.IsTrue(success); //Авторизация выполняется, если логин и пароль действительны.
            Assert.AreEqual(log, log_in_Account_Glav_manager); //Верный логин
            Assert.AreEqual(pas, pas_in_Account_Glav_manager); //Верный пароль


        }
        [TestMethod]
        public void Registration_when_login_and_password_are_not_null() //Регистрация выполняется, если логин и пароль непустые
        {
            //Arrange
            string log = "Manager5@mail.ru"; //логин для проверки 
            string pas = "Manager"; //пароль для проверки

            //Act
            bool success = Register(log, pas); //проверка регистрации

            //Assert
            Assert.IsTrue(success); //Регистрация не выполняется, если логин и пароль не пустые.
            Assert.IsNotNull(log, "Not null"); //непустой логин
            Assert.IsNotNull(pas, "Not null"); //непустой пароль

        }

        [TestMethod]
        public void Registration_when_login_and_password_are_null() //Регистрация выполняется, если логин и пароль пустые
        {
            //Arrange
            string log = null; //логин для проверки 
            string pas = null; //пароль для проверки

            //Act
            bool success = Register(log, pas); //проверка регистрации

            //Assert
            Assert.IsFalse(success); //Регистрация не выполняется, если логин и пароль пустые.
            Assert.IsNull(log, "null"); //пустой логин
            Assert.IsNull(pas, "null"); //пустой пароль

        }
        [TestMethod]
        public void Registration_when_login_or_password_is_null() //Регистрация выполняется, если логин или пароль пустые
        {
            //Arrange
            string log = "GlavManager4@gmail.com"; //логин для проверки 
            string pas = null; //пароль для проверки

            //Act
            bool success = Register(log, pas); //проверка регистрации

            //Assert
            Assert.IsTrue(success); //Регистрация не выполняется, если логин и пароль пустые.
            Assert.IsNotNull(log); //пустой логин
            Assert.IsNull(pas, "null"); //пустой пароль

        }
        //Процесс авторизации администратора
        public static bool Account_admin(string log, string pas)
        {

            if (log == log_in_Account_admin && pas == pas_in_Account_admin) //если логин и пароль верны
            {
                return true; //возвращает true
            }
            return false; //если нет, то возвращает false

        }
        //Процесс авторизации менеджера
        public static bool Account_manager(string log, string pas)
        {

            if (log == log_in_Account_manager && pas == pas_in_Account_manager) //если логин и пароль верны
            {
                return true; //возвращает true
            }
            return false; //если нет, то возвращает false

        }
        //Процесс авторизации главного менеджера
        public static bool Account_glavmanager(string log, string pas)
        {

            if (log == log_in_Account_Glav_manager && pas == pas_in_Account_Glav_manager) //если логин и пароль верны
            {
                return true; //возвращает true
            }
            return false; //если нет, то возвращает false

        }

        //Процесс Регистрации
        public static bool Register(string log, string pas)
        {

            if (log != null || pas != null) //если не пустые
            {
                return true; //возвращает true
            }
            return false;//если нет, то возвращает false

        }
    }
}
