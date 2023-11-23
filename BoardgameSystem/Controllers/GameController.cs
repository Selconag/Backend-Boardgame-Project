using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoardgameSystem.Services;
using BoardgameSystem.Repositories;
using BoardgameSystem.Services.Concrete;
using BoardgameSystem.Dtos.Requests;

namespace BoardgameSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateGameRequestDto requestDto)
        {
            var response = _gameService.Add(requestDto);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return Created("/", response);
            }
            return BadRequest(response);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] UpdateGameRequestDto requestDto)
        {
            var response = _gameService.Update(requestDto);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(response);
            }

            return BadRequest(response);

        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            var response = _gameService.Delete(id);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(response);
            }

            return BadRequest(response);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById([FromQuery] int id)
        {
            var response = _gameService.GetById(id);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(response);
            }

            return BadRequest(response);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var response = _gameService.GetList();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

    }
}
