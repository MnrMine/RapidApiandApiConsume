using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult ServiceCreate(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult ServiceGet(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult ServiceUpdate(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult ServiceDelete(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TDelete(value);
            return Ok();
        }

    }
}
