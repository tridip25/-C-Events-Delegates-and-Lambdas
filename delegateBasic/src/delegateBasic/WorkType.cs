using System;

namespace delegateBasic
{
    public class WorkType
    {
        private string difficulty;
        private string location;
        public string Difficulty {
            get{ return "moderate";}
            
            set{
                difficulty = value;    
            }
            
            }
        public string Location  {
            
            get {
                   return "moderate";
                }
            
            set {
                   location = value;    
                }
            
        }
    }
}