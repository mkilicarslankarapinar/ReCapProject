using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }




        //ICarService _carService;

        //public CarsController(ICarService carService)
        //{
        //    _carService = carService;
        //}

        //[HttpGet("getall")]
        //public IActionResult Get()
        //{
        //    var result = _carService.GetAllCars();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}

        //[HttpPost("add")]
        //public IActionResult Add(Car car)
        //{
        //    var result = _carService.Add(car);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}

    }
}
