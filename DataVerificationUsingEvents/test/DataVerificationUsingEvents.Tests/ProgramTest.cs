using System;
using Xunit;

namespace DataVerificationUsingEvents.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void validateNamePanAge()
        {
            

           
            Program.verify_EventHandler(this,new UserDataEventArgs("tridip","MNMNM7878O" ,22));

             Assert.Equal(3,Program.k);
        }
    }
}
