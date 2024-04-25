using EFReneiskiNew;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MainEFnew
{
    public class UserSqlHelper
    {
        public static List<T> GetAdonetDbInstance<T>(Func<AdonetdbEntities, IQueryable<T>> func)
        {
            using (var context = new AdonetdbEntities())
            {
                var result = func(context);

                return result.ToList();
            }
        }

        public static User GetUserNameById(int value) =>
            GetAdonetDbInstance(context =>
                from users in context.Users
                where users.Id == value
                select users).First();

        public static User GetUserIdByName(string value) =>
            GetAdonetDbInstance(context =>
                from users in context.Users
                where users.Name == value
                select users).First();

        public static void AddUserToDb(string nameValue, int ageValue)
        {
            using (var context = new AdonetdbEntities())
            {
                var newUser = new User() { Age = ageValue, Name = nameValue };
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public static void DeleteUserFromDb(int id)
        {
            using (var context = new AdonetdbEntities())
            {
                var userToDelete = context.Users.FirstOrDefault(x => x.Id == id);
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
        }
    }
}
