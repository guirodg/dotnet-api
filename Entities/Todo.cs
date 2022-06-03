using System.ComponentModel.DataAnnotations;

namespace Dotnet.API.Entities
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public Todo(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Done = false;
        }
    }
}