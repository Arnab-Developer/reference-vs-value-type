using ConsoleApp1.Models;
using ConsoleApp1.Services;
using static System.Console;

WriteLine("---- Operation with class\n");

StudentClass sclass = new(1, "Jon Doe");
StudentClassService.ChangeStudentClass(sclass);
WriteLine($"ChangeStudentClass: {sclass.Id} {sclass.Name}");

StudentClass sclass1 = new(1, "Jon Doe");
StudentClassService.ChangeStudentClassWithNewInstance(sclass1);
WriteLine($"ChangeStudentClassWithNewInstance: {sclass1.Id} {sclass1.Name}");

StudentClass sclass2 = new(1, "Jon Doe");
StudentClassService.ChangeStudentClassWithNewInstanceWithRef(ref sclass2);
WriteLine($"ChangeStudentClassWithNewInstanceWithRef: {sclass2.Id} {sclass2.Name}");

WriteLine("\n---- Operation with struct\n");

StudentStruct sstruct = new(1, "Jon Doe");
StudentStructService.ChangeStudentStruct(sstruct);
WriteLine($"ChangeStudentStruct: {sstruct.Id} {sstruct.Name}");

StudentStruct sstruct1 = new(1, "Jon Doe");
StudentStructService.ChangeStudentStructWithRef(ref sstruct1);
WriteLine($"ChangeStudentStructWithRef: {sstruct1.Id} {sstruct1.Name}");

StudentStruct sstruct2 = new(1, "Jon Doe");
StudentStructService.ChangeStudentStructWithNewInstanceWithRef(ref sstruct2);
WriteLine($"ChangeStudentStructWithNewInstanceWithRef: {sstruct2.Id} {sstruct2.Name}");

WriteLine("\n---- Operation with record\n");

StudentRecord srecord = new(1, "Jon Doe");
StudentRecordService.ChangeStudentRecord(srecord);
WriteLine($"ChangeStudentRecord: {srecord.Id} {srecord.Name}");

StudentRecord srecord1 = new(1, "Jon Doe");
StudentRecordService.ChangeStudentRecordWithNewInstance(srecord1);
WriteLine($"ChangeStudentRecordWithNewInstance: {srecord1.Id} {srecord1.Name}");

StudentRecord srecord2 = new(1, "Jon Doe");
StudentRecordService.ChangeStudentRecordWithNewInstanceWithRef(ref srecord2);
WriteLine($"ChangeStudentRecordWithNewInstanceWithRef: {srecord2.Id} {srecord2.Name}");

/*
Output:

---- Operation with class

ChangeStudentClass: 2 Bob
ChangeStudentClassWithNewInstance: 1 Jon Doe
ChangeStudentClassWithNewInstanceWithRef: 2 Bob

---- Operation with struct

ChangeStudentStruct: 1 Jon Doe
ChangeStudentStructWithRef: 2 Bob
ChangeStudentStructWithNewInstanceWithRef: 2 Bob

---- Operation with record

ChangeStudentRecord: 2 Bob
ChangeStudentRecordWithNewInstance: 1 Jon Doe
ChangeStudentRecordWithNewInstanceWithRef: 2 Bob
*/