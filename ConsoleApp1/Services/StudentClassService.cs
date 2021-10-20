using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    internal static class StudentClassService
    {
        public static void ChangeStudentClass(StudentClass s)
        {
            s.Id++;
            s.Name = "Bob";
        }

        public static void ChangeStudentClassWithNewInstance(StudentClass s)
        {
            s = new(2, "Bob");
        }

        public static void ChangeStudentClassWithNewInstanceWithRef(ref StudentClass s)
        {
            s = new(2, "Bob");
        }
    }
}