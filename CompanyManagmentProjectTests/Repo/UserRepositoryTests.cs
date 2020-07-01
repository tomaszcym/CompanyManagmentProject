using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyManagmentProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagmentProject.Model;

namespace CompanyManagmentProject.Repo.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {

        private User createTestUser(string username, string password)
        {
            User user = new User(username, password);
            List<User> users = UserRepository.getAll();
            User userInDb = users.Find(u => u.username == user.username);
            return userInDb;
        }

        [TestMethod()]
        public void createUserTest()
        {
            User user = createTestUser("jackowy", "noweSilneHasło!.!%");
            Assert.IsNotNull(user);
        }

        [TestMethod()]
        public void invalidAuthoirizeUserTest()
        {
            User user = createTestUser("jackowy", "noweSilneHasło!.!%");
            User authorizedUser = UserRepository.authorizeUser("jackowy", "błędneHasło!.!%");
            Assert.IsNull(user);
        }
        [TestMethod()]
        public void validAuthoirizeUserTest()
        {
            User user = createTestUser("jackowy", "noweSilneHasło!.!%");
            User authorizedUser = UserRepository.authorizeUser("jackowy", "noweSilneHasło!.!%");
            Assert.IsNotNull(user);
        }

    }
}