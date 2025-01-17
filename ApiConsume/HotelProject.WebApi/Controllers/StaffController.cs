﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult StaffCreate(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }

        
        [HttpGet("{id}")]
        public IActionResult StaffGet(int id)
        {
            var value = _staffService.TGetById(id);
            return Ok(value);
        }

      
        [HttpPut]
        public IActionResult StaffUpdate(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult StaffDelete(int id)
        {
            var value = _staffService.TGetById(id);
            _staffService.TDelete(value);
            return Ok();
        }
    }
}
