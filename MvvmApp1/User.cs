using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp1
{
    public class User
    {
        public User(string id, string firstName, string lastName, string thirdName)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            ThirdName = thirdName;
        }
        public User()
        {

        }
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThirdName { get; set; }
        
    }
}
