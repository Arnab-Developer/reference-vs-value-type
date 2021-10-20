using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    internal static class StudentStructService
    {
        public static void ChangeStudentStruct(StudentStruct s)
        {
            s.Id++;
            s.Name = "Bob";
        }

        public static void ChangeStudentStructWithRef(ref StudentStruct s)
        {
            s.Id++;
            s.Name = "Bob";
        }

        public static void ChangeStudentStructWithNewInstanceWithRef(ref StudentStruct s)
        {
            s = new(2, "Bob");
        }
    }
}
