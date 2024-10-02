using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace PWS_Lab02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PwsController : ControllerBase
    {
        private const string StackSessionKey = "StackSessionKey";
        private static int _result = 0;

        private Stack<int> GetStack()
        {
            if (HttpContext.Session.TryGetValue(StackSessionKey, out var value))
            {
                return JsonSerializer.Deserialize<Stack<int>>(value);
            }
            return new Stack<int>();
        }

        private void SetStack(Stack<int> stack)
        {
            HttpContext.Session.SetString(StackSessionKey, JsonSerializer.Serialize(stack));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var stack = GetStack();
            int result = (stack.Count > 0) ? (_result + stack.Peek()) : _result;
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
            var stack = GetStack();
            stack.Push(addParameter);
            SetStack(stack);
            return Ok();
        }

        [HttpDelete("remove")]
        public IActionResult Delete()
        {
            var stack = GetStack();
            if (stack.Count <= 0)
                return BadRequest("[ERROR] Stack is empty.");
            stack.Pop();
            SetStack(stack);
            return Ok();
        }
    }
}