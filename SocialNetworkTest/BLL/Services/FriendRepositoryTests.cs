using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetworkTest.BLL.Services
{
    [TestClass()]
    public class UserAddingFriendDataTests
    {
        UserService UserService = new UserService();
        [TestMethod()]
        public void UserNotFoundException()
        {
            UserAddingFriendData userAddingFriendData = new UserAddingFriendData();
            Assert.ThrowsException<UserNotFoundException>(() => UserService.AddFriend(userAddingFriendData));
        }        
    }
}