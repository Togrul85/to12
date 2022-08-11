using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Home
{
    class User
    {
        public string Username { get; set; }
        private string _password;
        public string Password {
            get {
                return _password;
            } 
            set {
                if (value.Length>=8 && value.Length <= 25)
                {
                   
        public User(string userName)
        {
            if (userName.Length>=6 && userName.Length<25)
            {
                Username = userName;
            }
        }


    }
   
}
    


    
    
    
       
    


    
   


