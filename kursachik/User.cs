using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursachik
{
     class User
    {
        public int Id { get; set; }

        public string Login, Pass, FirstName, SecondName;
        public User() { }
        public User (string Login, string Pass,  string FirstName, string SecondName) {
            this.Login = Login;
            this.Pass = Pass;

            this.FirstName = FirstName;
            this.SecondName = SecondName;
        }
    }
    
}
