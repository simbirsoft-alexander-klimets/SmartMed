using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartMed.Domain.Infrastructure.Interfaces;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;

namespace SmartMed.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class RatingOptionController : ControllerBase
    {
        private IRatingOptionService _service;
        public RatingOptionController(IRatingOptionService service)
        {
            _service = service;
        }

        [HttpGet("/ratings")]
        public IEnumerable<Rating> GetRatings()
        {
            return _service.GetAllRatings();            
        }

        [HttpGet("/options")]
        public IEnumerable<Option> GetOptions()
        {
            return _service.GetAllOptions();
        }

        [HttpGet("/options/{id}")]
        public ActionResult<Option> GetOptionById(Guid id)
        {
            var result = _service.GetOptionById(id);
            if(result == null)
            {
                return BadRequest("No option with such id");
            }
            return Ok(result);
        }

        [HttpGet("/ratings/{id}")]
        public ActionResult<Rating> GetRatingById(Guid id)
        {
            var result = _service.GetRatingById(id);
            if (result == null)
            {
                return BadRequest("No option with such id");
            }
            return Ok(result);
        }

        [HttpPost("/options/add")]
        public ActionResult AddOption([FromBody] Option option)
        {
            if (ModelState.IsValid)
            {
                _service.AddOption(option);
                return Ok("Success");

            }
            return BadRequest("Option model is invalid");
        }

        [HttpPost("ratings/add")]
        public ActionResult AddRating([FromBody] Rating rating)
        {
            if (ModelState.IsValid)
            {
                _service.AddRating(rating);
                return Ok("Success");

            }
            return BadRequest("Rating is invalid");
        }

        [HttpPut("/options/update/{id}")]
        public ActionResult UpdateOption(Guid id, [FromBody] Option option)
        {
            if(ModelState.IsValid)
            {
                _service.UpdateOption(id, option);
                return Ok("Update success");
            }
            return BadRequest("Option is invalid");
        }

        [HttpPut("/ratings/update/{id}")]
        public ActionResult UpdateRating(Guid id, [FromBody] Rating rating)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateRating(id, rating);
                return Ok("Update success");
            }
            return BadRequest("Rating is invalid");
        }

        [HttpDelete("/options/delete/{id}")]
        public ActionResult DeleteOption(Guid id)
        {
            _service.RemoveOption(id);
            var result = _service.GetOptionById(id);
            if (result == null)
            {
                return Ok("Delete successful");

            }
            return BadRequest("Delete error");
        }

        [HttpDelete("/ratings/delete/{id}")]
        public ActionResult DeleteRating(Guid id)
        {
            _service.RemoveRating(id);
            var result = _service.GetRatingById(id);
            if(result == null)
            {
                return Ok("Delete successful");
                
            }
            return BadRequest("Delete error");
        }
    }
}
