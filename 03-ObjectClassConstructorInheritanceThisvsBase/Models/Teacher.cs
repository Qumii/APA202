using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Teacher : Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;

        public Teacher(string FirstName, string LastName, int Age, string Email, int Id, string Department, string MainSubject, decimal BaseSalary, int ExperienceYears) : base(FirstName, LastName, Age, Email, Id)
        {
            this.Department = Department;
            this.MainSubject = MainSubject;
            this.BaseSalary = BaseSalary;
            this.ExperienceYears = ExperienceYears;
        }
        public void ShowTeacherInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Yas: {Age}, Email: {Email}, Id: {Id}, Kafedra: {Department}, Esas fenn: {MainSubject}, Baza maas: {BaseSalary}, Tecrube ili: {ExperienceYears}");

        }

        public decimal CalculateSalary()
        {
            //Console.WriteLine($"{BaseSalary+(ExperienceYears*50)}");

            return BaseSalary + (ExperienceYears * 50);
        }
    }
}
