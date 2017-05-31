using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapidemo.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapidemo.Controllers
{
    [Route("api/[controller]")]
    public class UserInfoController : Controller
    {
        private ILogger<UserInfoController> _logger;
        public  UserInfoController(ILogger<UserInfoController> log){
            this._logger = log;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation("This is Information Log!");
            _logger.LogWarning("This is Warning Log!");
            _logger.LogError("This is Error Log!");
            var user = new User() { Id = id, Name = "Name:" + id, Sex = "Male" };
            return new ObjectResult(user);
       }
       [HttpPost]
         public IActionResult Post([FromBody] User user){
            if(user == null){
            return BadRequest();
        }
        //新增操作
        user.Id = new Random().Next(1,10);
        return CreatedAtAction("Get", new { id = user.Id }, user);
       }
       [HttpPut("{id}")]
       public IActionResult Put(int id,[FromBody] User user){
           if(user == null){
                return BadRequest();
            }
           return new NoContentResult();
       }
    }
}
