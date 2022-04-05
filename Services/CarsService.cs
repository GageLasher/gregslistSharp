

using gregslistSharp.DB;
using gregslistSharp.Models;

namespace gregslistSharp.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
            return FakeDb.Cars;

        }

        internal Car GetById(string id)
        {
            Car found = FakeDb.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }
        internal Car Create(Car body)
        {
            FakeDb.Cars.Add(body);
            return body;
        }

        internal Car Edit(Car update)
        {
            Car original = GetById(update.Id);
            original.Age = update.Age ?? original.Age;
            original.Name = update.Name ?? original.Name;
            return original;
        }

        internal void Remove(string id)
        {
            Car found = GetById(id);
            FakeDb.Cars.Remove(found);
        }
    }
}