
using gregslistSharp.Models;
using gregslistSharp.Services;
using Microsoft.AspNetCore.Mvc;


namespace gregslistSharp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarsController : Controller
    {
        private readonly CarsService _cs;
        public CarsController(CarsService cs)
        {
            _cs = cs;
        }
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.GetAll();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            try
            {
                Car car = _cs.GetById(id);
                return Ok(car);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car body)
        {
            try
            {
                Car newCar = _cs.Create(body);
                return Ok(newCar);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Car> Edit(string id, [FromBody] Car update)
        {
            try
            {
                update.Id = id;
                Car updated = _cs.Edit(update);
                return Ok(updated);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<String> Remove(string id)
        {
            try
            {
                _cs.Remove(id);
                return Ok("deleted");
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }



    }
}