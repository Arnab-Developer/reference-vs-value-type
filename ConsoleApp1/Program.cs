using static System.Console;

StudentClass sclass = new(1, "Jon Doe");
ChangeStudentClass(sclass);
WriteLine($"{sclass.Id} {sclass.Name}"); // output: 2 Bob

StudentStruct sstruct = new(1, "Jon Doe");
ChangeStudentStruct(sstruct);
WriteLine($"{sstruct.Id} {sstruct.Name}"); // output: 1 Jon Doe

static void ChangeStudentClass(StudentClass s)
{
    s.Id++;
    s.Name = "Bob";
}

static void ChangeStudentStruct(StudentStruct s)
{
    s.Id++;
    s.Name = "Bob";
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