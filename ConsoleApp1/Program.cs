using static System.Console;

StudentClass sclass = new(1, "Jon Doe");
ChangeStudentClass(sclass);
WriteLine($"{sclass.Id} {sclass.Name}"); // output: 2 Bob

StudentClass sclass1 = new(1, "Jon Doe");
ChangeStudentClass1(sclass1);
WriteLine($"{sclass1.Id} {sclass1.Name}"); // output: 1 Jon Doe

StudentStruct sstruct = new(1, "Jon Doe");
ChangeStudentStruct(sstruct);
WriteLine($"{sstruct.Id} {sstruct.Name}"); // output: 1 Jon Doe

StudentStruct sstruct1 = new(1, "Jon Doe");
ChangeStudentStruct1(ref sstruct1);
WriteLine($"{sstruct1.Id} {sstruct1.Name}"); // output: 2 Bob

StudentRecord srecord = new(1, "Jon Doe");
ChangeStudentRecord(srecord);
WriteLine($"{srecord.Id} {srecord.Name}"); // output: 2 Bob

StudentRecord srecord1 = new(1, "Jon Doe");
ChangeStudentRecord1(srecord1);
WriteLine($"{srecord1.Id} {srecord1.Name}"); // output: 1 Jon Doe

static void ChangeStudentClass(StudentClass s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentClass1(StudentClass s)
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

static void ChangeStudentRecord(StudentRecord s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentRecord1(StudentRecord s)
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