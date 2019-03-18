using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person()
        {

        }
        

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
    }
}
