using System;
using System.Text.RegularExpressions;

namespace DataVerificationUsingEvents
{
    public class Program
    {
        public static int k = 0;
        static void Main(string[] args)
        {
            var menu = new Menu();
            var raise = new RaisingEvent();
            var userData = menu.getMenuData();
            

            raise.UserData += verify_EventHandler;
            raise.verifyUserData(userData.Name , userData.Pan , userData.Age);
        }

        public static void verify_EventHandler(object sender, UserDataEventArgs e)
        {
            if(e.Name.Length > 2 && e.Name.Length < 20)
            {
                Console.WriteLine("Valid name");
                k+=1;
            }

          if(e.Pan.Length == 10)
          {
              Regex regex = new Regex("([A-Z]){5}([0-9]){4}([A-Z]){1}$");
            if(regex.IsMatch(e.Pan.ToUpper()))
              {
                Console.WriteLine("Valid PAN number");
                k+=1;
               }
          }

            if(e.Age >= 18 && e.Age <= 100)
            {
                k+=1;
                Console.WriteLine("Valid Age");
            }

        }
    }
}
