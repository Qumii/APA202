using _03_ObjectClassConstructorInheritanceThisvsBase.Models;
namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Program
    {

        static void Main()
        {

            Person person1 = new("Qumral", "Tahmazova", 21, "qmrl.tahmaz", 1);
            Console.WriteLine(person1.GetFullName());
            person1.ShowBasicInfo();

            Student student = new("Qumral", "Tahmazova", 21, "qmrl.tahmaz", 1, "5", "ITT", 79.7, 4);
            student.ShowStudentInfo();
            Console.WriteLine($"{student.FirstName} {student.LastName} adli telebenin teqaudu: {student.CalculateScholarShip()} AZN");


            Teacher teacher = new("Ali", "Khalilov", 35, "ali.khalilov", 3, "Komputer texnologiyalari", "Sebeke", 1500, 6);
            teacher.ShowTeacherInfo();
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} adli muellimin maasi: {teacher.CalculateSalary()} AZN");


            Administrator administrator = new("Zefer", "Ceferov", 60, "zeferceferov", 5, "Kafedra mudiri", "Komputer texnologiyalari", 2);
            administrator.ShowAdminInfo();

            administrator.GrantAccess(student);

            Student student1 = new("Konul", "Rasulova", 21, "konull", 3, "3", "ITT", 88.5, 4);
            Student student2 = new("Roya", "Amiraslanli", 22, "roya", 2, "1", "ITT", 92.0, 4);
            Student student3 = new("Gunay", "Aliyeva", 21, "gunai", 4, "6", "EA", 68.5, 3);

            student1.ShowStudentInfo();
            Console.WriteLine($"{student1.FirstName} {student1.LastName} adli telebenin teqaudu: {student1.CalculateScholarShip()} AZN");
            student2.ShowStudentInfo();
            Console.WriteLine($"{student2.FirstName} {student2.LastName} adli telebenin teqaudu: {student2.CalculateScholarShip()} AZN");
            student3.ShowStudentInfo();
            Console.WriteLine($"{student3.FirstName} {student3.LastName} adli telebenin teqaudu: {student3.CalculateScholarShip()} AZN");

            Teacher teacher1 = new("Fizuli", "Azimov", 65, "azimov.fizuli", 3, "MR ve SI", "Proqramlasdirma", 2000, 18);
            Teacher teacher2 = new("Ali", "Khalilov", 35, "ali.khalilov", 3, "Komputer texnologiyalari", "Sebeke", 1500, 8);

            teacher1.ShowTeacherInfo();
            Console.WriteLine($"{teacher1.FirstName} {teacher1.LastName} adli muellimin maasi: {teacher1.CalculateSalary()} AZN");
            teacher2.ShowTeacherInfo();
            Console.WriteLine($"{teacher2.FirstName} {teacher2.LastName} adli muellimin maasi: {teacher2.CalculateSalary()} AZN");

            Administrator administrator1 = new("Leyla", "Memmedova", 50, "leila.mm", 5, "Dekan", "Komputer texnologiyalari", 2);

            administrator1.ShowAdminInfo();
            administrator1.GrantAccess(student2);


            Console.WriteLine($"3 telebenin teqaudlerinin cemi: {student1.CalculateScholarShip() + student2.CalculateScholarShip() + student3.CalculateScholarShip()} AZN");
            Console.WriteLine($"2 muellimin maaslarinin cemi: {teacher1.CalculateSalary() + teacher2.CalculateSalary()} AZN");
        }

    }









}