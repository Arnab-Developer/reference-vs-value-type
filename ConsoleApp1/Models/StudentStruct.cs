namespace ConsoleApp1.Models
{
    internal struct StudentStruct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public StudentStruct(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
