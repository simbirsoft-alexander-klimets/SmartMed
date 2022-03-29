using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartMed.Domain.Infrastructure.Interfaces;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;

namespace SmartMed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, User")]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _service;

        public AppointmentController(IAppointmentService _service)
        {
            _service = _service;
        }

        [HttpGet("/appointments")]
        public IEnumerable<Appointment> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("/appointments/{id}")]
        public Appointment Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpGet("/appointments/status/{id}")]
        public ActionResult GetStatus(Guid id)
        {
            var appointment = _service.GetById(id);
            if(appointment == null)
            {
                return BadRequest("Appointment is block");
            }
            return Ok(appointment);
        }
    }
}
