using System;

namespace DataVerificationUsingEvents
{

    public class RaisingEvent
    {
        public event EventHandler<UserDataEventArgs> UserData;
        public void verifyUserData(string name ,  string pan , int age)
        {
                OnVerifyingUserData(name,pan,age);
              
        }

        private void OnVerifyingUserData(string name, string pan, int age)
        {
              var del = UserData as EventHandler<UserDataEventArgs>;
                if(del!=null)
                {
                    del (this , new UserDataEventArgs(name, pan ,age));
                }
        }
    }
}