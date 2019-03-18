using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Student: Person 
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }

        public Student()
        {

        }
        public Student(string firstName, string lastName, int id, int age,Gender gender, string group, string course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Age = age;
            this.Gender = gender;
            this.Group = group;
            this.Course = course;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($" Id: {this.Id}, Group: {this.Group}");
        }
    }
}
