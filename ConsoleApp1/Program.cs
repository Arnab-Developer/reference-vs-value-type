using static System.Console;

StudentClass sclass = new(1, "Jon Doe");
ChangeStudentClass(sclass);
WriteLine($"ChangeStudentClass: {sclass.Id} {sclass.Name}");

StudentClass sclass1 = new(1, "Jon Doe");
ChangeStudentClass1(sclass1);
WriteLine($"ChangeStudentClass1: {sclass1.Id} {sclass1.Name}");

StudentClass sclass2 = new(1, "Jon Doe");
ChangeStudentClass2(ref sclass2);
WriteLine($"ChangeStudentClass2: {sclass2.Id} {sclass2.Name}");

StudentStruct sstruct = new(1, "Jon Doe");
ChangeStudentStruct(sstruct);
WriteLine($"ChangeStudentStruct: {sstruct.Id} {sstruct.Name}");

StudentStruct sstruct1 = new(1, "Jon Doe");
ChangeStudentStruct1(ref sstruct1);
WriteLine($"ChangeStudentStruct1: {sstruct1.Id} {sstruct1.Name}");

StudentStruct sstruct2 = new(1, "Jon Doe");
ChangeStudentStruct2(ref sstruct2);
WriteLine($"ChangeStudentStruct2: {sstruct2.Id} {sstruct2.Name}");

StudentRecord srecord = new(1, "Jon Doe");
ChangeStudentRecord(srecord);
WriteLine($"ChangeStudentRecord: {srecord.Id} {srecord.Name}");

StudentRecord srecord1 = new(1, "Jon Doe");
ChangeStudentRecord1(srecord1);
WriteLine($"ChangeStudentRecord1: {srecord1.Id} {srecord1.Name}");

StudentRecord srecord2 = new(1, "Jon Doe");
ChangeStudentRecord2(ref srecord2);
WriteLine($"ChangeStudentRecord2: {srecord2.Id} {srecord2.Name}");

static void ChangeStudentClass(StudentClass s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentClass1(StudentClass s)
{
    s = new(2, "Bob");
}

static void ChangeStudentClass2(ref StudentClass s)
{
    s = new(2, "Bob");
}

static void ChangeStudentStruct(StudentStruct s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentStruct1(ref StudentStruct s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentStruct2(ref StudentStruct s)
{
    s = new(2, "Bob");
}

static void ChangeStudentRecord(StudentRecord s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentRecord1(StudentRecord s)
{
    s = new(2, "Bob");
}

static void ChangeStudentRecord2(ref StudentRecord s)
{
    s = new(2, "Bob");
}

class StudentClass
{
    public int Id { get; set; }

    public string Name { get; set; }

    public StudentClass(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

struct StudentStruct
{
    public int Id { get; set; }

    public string Name { get; set; }

    public StudentStruct(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

record StudentRecord 
{
    public int Id { get; set; }

    public string Name { get; set; }

    public StudentRecord(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

/*
Output:

ChangeStudentClass: 2 Bob
ChangeStudentClass1: 1 Jon Doe
ChangeStudentClass2: 2 Bob
ChangeStudentStruct: 1 Jon Doe
ChangeStudentStruct1: 2 Bob
ChangeStudentStruct2: 2 Bob
ChangeStudentRecord: 2 Bob
ChangeStudentRecord1: 1 Jon Doe
ChangeStudentRecord2: 2 Bob
*/