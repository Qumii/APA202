using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Administrator : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;


        public Administrator(string FirstName, string LastName, int Age, string Email, int Id, string Position, string Department, int AccessLevel) : base(FirstName, LastName, Age, Email, Id)
        {
            this.Position = Position;
            this.Department = Department;
            this.AccessLevel = AccessLevel;
        }

        public void ShowAdminInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Yas: {Age}, Email: {Email}, Id: {Id}, Vezife: {Position}, Kafedra: {Department}, Giris seviyyesi: {AccessLevel}");
        }

        public void GrantAccess(Student student)
        {

            Console.WriteLine($"{student.FirstName} {student.LastName} adli telebeye sistem girisi verildi");
        }
    }
}
