using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PWS_Lab02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PwsController : ControllerBase
    {
        private static int _result = 0;
        private static readonly Stack<int> _stack = new Stack<int>();

        public IActionResult Get()
        {
            int result = (_stack.Count > 0) ? (_result + _stack.Peek()) : _result;
            return Ok(new { result });
        }

        [HttpPost("result")]
        public IActionResult Post([FromQuery] string result)
        {
            if (!int.TryParse(result, out int resultParameter))
                return BadRequest("[ERROR] Enter integer parameter.");
            _result = resultParameter;
            return Ok();
        }

        [HttpPut("add")]
        public IActionResult Put([FromQuery] string add)
        {
            if (!int.TryParse(add, out int addParameter))
                return BadRequest("[ERROR] Enter integer parameter.");
            _stack.Push(addParameter);
            return Ok();
        }

        [HttpDelete("remove")]
        public IActionResult Delete()
        {
            if (_stack.Count <= 0)
                return BadRequest("[ERROR] Stack is empty.");
            _stack.Pop();
            return Ok();
        }
    }
}