using MainEFnew;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MainEFnewTests
{
    public class MainEFnewTests
    {
        [Test]
        public void VerifyUserNameById()
        {
            const int id = 3;

            ClassicAssert.AreEqual("Tom", UserSqlHelper.GetUserNameById(id).Name);
        }

        [Test]
        public void AddUserAndVerifyIt()
        {
            var newAge = 65;
            var newName = "Michael";

            UserSqlHelper.AddUserToDb(newName, newAge);

            var createdUserId = UserSqlHelper.GetUserIdByName(newName).Id;

            ClassicAssert.AreEqual(newName, UserSqlHelper.GetUserNameById(createdUserId).Name);
            ClassicAssert.AreEqual(newAge, UserSqlHelper.GetUserNameById(createdUserId).Age);

            UserSqlHelper.DeleteUserFromDb(createdUserId);
        }
    }
}