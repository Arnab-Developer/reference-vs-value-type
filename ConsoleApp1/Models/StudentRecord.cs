namespace ConsoleApp1.Models;

internal record StudentRecord
{
    public int Id { get; set; }

    public string Name { get; set; }

    public StudentRecord(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
