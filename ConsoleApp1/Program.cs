using static System.Console;

StudentClass sclass = new(10, "jon");
ChangeStudentClass(sclass);
WriteLine($"{sclass.Id} {sclass.Name}"); // output: 11 invalid

StudentStruct sstruct = new(10, "jon");
ChangeStudentStruct(sstruct);
WriteLine($"{sstruct.Id} {sstruct.Name}"); // output: 10 jon

static void ChangeStudentClass(StudentClass s)
{
    s.Id++;
    s.Name = "invalid";
}

static void ChangeStudentStruct(StudentStruct s)
{
    s.Id++;
    s.Name = "invalid";
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