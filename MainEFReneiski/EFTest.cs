//using EFReneiskiNew;
//using NUnit.Framework;
//using NUnit.Framework.Legacy;
//using System.Linq;
//using System.Net;

//namespace MainEFReneiski
//{
//    public class EFTest
//    {
//        [Test]
//        public void ACreateUserWhichDoesNotExistInPortal()
//        {
//            using (var context = new AdonetdbEntities())
//            {
//                var name = context.Users.First(x => x.Id == 3).Name;
//                ClassicAssert.AreEqual("Tom", name);

//                //Console.WriteLine(name);

//                //var newUser = new User() { Age = 48, Name = "Gearge" };
//                //context.Users.Add(newUser);
//                //context.SaveChanges();
//            }

//            //ClassicAssert.AreEqual("Tom", name);
//        }
//    }
//}
