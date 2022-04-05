

using System.ComponentModel.DataAnnotations;

namespace gregslistSharp.Models
{
    public class Car
    {
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int? Age { get; set; }

        // ONLY REQUIRED WITH FAKEDB
        public Car(string name, int? age)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
        }

    }
}