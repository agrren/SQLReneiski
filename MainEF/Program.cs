using EFReneiskiNew;

namespace MainEF
{
    public class Class1
    {
        public static void Main()
        {
            SimpleCheck();
        }

        private static void SimpleCheck()
        {
            using (var context = new AdonetdbEntities())
            {
                var name = context.Users.First(x => x.Id == 3).Name;

                var newUser = new User() { Age = 48, Name = "Gearge" };
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }
    }
}