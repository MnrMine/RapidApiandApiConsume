using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult SubscribeCreate(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult SubscribeGet(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult SubscribeUpdate(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult SubscribeDelete(int id)
        {
            var value = _subscribeService.TGetById(id);
            _subscribeService.TDelete(value);
            return Ok();
        }
    }
}
