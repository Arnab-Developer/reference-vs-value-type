using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    internal static class StudentRecordService
    {
        public static void ChangeStudentRecord(StudentRecord s)
        {
            s.Id++;
            s.Name = "Bob";
        }

        public static void ChangeStudentRecordWithNewInstance(StudentRecord s)
        {
            s = new(2, "Bob");
        }

        public static void ChangeStudentRecordWithNewInstanceWithRef(ref StudentRecord s)
        {
            s = new(2, "Bob");
        }
    }
}
