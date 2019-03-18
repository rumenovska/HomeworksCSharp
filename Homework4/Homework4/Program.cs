using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework4
{
    class Program
    {

        static void Main(string[] args)
#region ListOfStudents
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { FirstName= "Mia", LastName="Smith",Id= 1,Age= 23,Gender= Gender.Female, Group="G1", Course="Web Programming" });
            students.Add(new Student() {FirstName= "John",LastName= "Smith",Id= 2,Age= 29,Gender= Gender.Male, Group="G1",Course= "Web Programming" });
            students.Add(new Student(){ FirstName="Rebeca", LastName="Cooper",Id= 3,Age= 37,Gender= Gender.Female,Group= "G1",Course= "Web Programming" });
            students.Add(new Student(){FirstName= "Sophia",LastName= "Davis",Id= 4,Age= 19,Gender= Gender.Female,Group= "G1",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Louis",LastName= "Cooper",Id= 5,Age= 28,Gender= Gender.Male,Group= "G2",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Emma",LastName= "Hill  ",Id= 6,Age= 30,Gender= Gender.Female,Group="G2",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Eric",LastName= "Gray",Id= 7,Age= 25,Gender= Gender.Male,Group= "G2",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Isabella",LastName= "Bailey",Id= 8,Age= 27,Gender= Gender.Female,Group= "G2",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Amelia", LastName="White ",Id= 9,Age= 26,Gender= Gender.Female,Group= "G3",Course= "Web Programming" });
            students.Add(new Student(){FirstName="Saul", LastName="Foster",Id= 10,Age= 37,Gender= Gender.Male,Group= "G3",Course= "Web Programming"});
            students.Add(new Student() {FirstName= "Layla",LastName= "Scott",Id= 11,Age= 39,Gender= Gender.Female,Group= "G3",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Nora",LastName= "Gonzales",Id= 12,Age= 29,Gender= Gender.Female,Group= "G4",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Bob",LastName= "Lewis",Id= 13,Age= 20,Gender= Gender.Male,Group="G4",Course= "Web Programming" });
            students.Add(new Student() { FirstName="Aron",LastName= "Patterson",Id= 14,Age= 22,Gender= Gender.Male,Group= "G4",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Mike",LastName= "Rose",Id= 15,Age= 37,Gender= Gender.Male,Group= "G5",Course= "Web Programming" });
            students.Add(new Student() { FirstName = "Sarah", LastName = " Simmons ", Id = 16, Age = 24, Gender = Gender.Female, Group = "G5", Course = "Web Programming" });
            students.Add(new Student() {FirstName= "Nicolas",LastName= "Parker",Id= 17,Age= 29,Gender= Gender.Male,Group= "G5",Course= "Web Programming" });
            students.Add(new Student() { FirstName="Tommy",LastName= "Thompson",Id= 18,Age= 38,Gender= Gender.Male,Group= "G6",Course= "Web Programming" });
            students.Add(new Student() {FirstName= "Victoria",LastName= "Parker",Id= 19,Age= 36,Gender= Gender.Female, Group="G6", Course="Web Programming" });
            students.Add(new Student() { FirstName="Madison", LastName="Clark",Id= 20,Age= 28,Gender= Gender.Female,Group= "G6",Course="Web Programming" });
            #endregion

            //all female students
            IEnumerable<Student> femaleStudents = students.Where(s=> s.Gender == Gender.Female);
            foreach (var s in femaleStudents)
            {
                s.GetInfo();

            }
            Console.WriteLine("---------------------------");
            //all male students
            IEnumerable<Student> maleStudents = students.Where(s => s.Gender == Gender.Male);
            foreach (var s in maleStudents)
            {
                s.GetInfo();

            }
            Console.WriteLine("---------------------------");
            // all students with a first letter of a name 
            Console.WriteLine("Enter letter:");
            string letter = Console.ReadLine();
            IEnumerable<Student> firstLetter = students.Where(s => s.FirstName.StartsWith(letter));
            foreach (var s in firstLetter)
            {
                s.GetInfo();

            }
            Console.WriteLine("---------------------------");
            // all students that are in group
            Console.WriteLine("Enter number of Group");
            string groupNum = Console.ReadLine();
            IEnumerable<Student> groupNumber = students.Where(s => s.Group == $"G{groupNum}");
            foreach (var s in groupNumber)
            {
                s.GetInfo();

            }
            Console.WriteLine("---------------------------");
            // student with id
            Console.WriteLine("Enter Id number:");
            int num = Int32.Parse(Console.ReadLine());
            IEnumerable<Student> groupId = students.Where(s => s.Id == num );
            foreach (var s in groupId)
            {
                s.GetInfo();

            }
        }
    }
}
