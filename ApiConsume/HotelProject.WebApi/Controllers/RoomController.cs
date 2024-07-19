using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult RoomCreate(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult RoomGet(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult RoomUpdate(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult RoomDelete(int id)
        {
            var value = _roomService.TGetById(id);
            _roomService.TDelete(value);
            return Ok();
        }
    }
}
