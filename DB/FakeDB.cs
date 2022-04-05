

using gregslistSharp.Models;

namespace gregslistSharp.DB
{
    public static class FakeDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>() {
        new Car("Chevy", 1978),
        new Car("Toyota", 2006),
        new Car("Porsche", 2021),
        new Car("Hyundai", 2022)
     };
    }
}