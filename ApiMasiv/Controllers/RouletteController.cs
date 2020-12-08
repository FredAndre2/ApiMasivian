using ApiMasivian.Application.Contracts.Services;
using ApiMasivian.Bussiness.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMasiv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        private IRouletteService rouletteService;
        public RouletteController(IRouletteService rouletteService)
        {
            this.rouletteService = rouletteService;
        }
        [HttpPost]
        public IActionResult Create()
        {
            string idRoulette = rouletteService.CreateRoulette();
            return Ok(idRoulette);
        }
        [HttpPut("{id}/open")]
        public IActionResult Open([FromRoute(Name = "id")] string id)
        {
            try
            {
                rouletteService.OpenRoulette(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(404, e.Message.ToString());
            }
        }
        [HttpGet("/all")]
        public IActionResult GetAll()
        {
            return Ok(rouletteService.GetAllRoulettes());
        }
        [HttpPost("/bet")]
        public IActionResult PlaceBet([FromHeader(Name = "userId")] string idUser, [FromBody]BetRequest bet)
        {
            try
            {
                rouletteService.PlaceBetToRoulette(bet, idUser);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(404, e.Message.ToString());
            }
        }
        [HttpPut("{id}/close")]
        public IActionResult Close([FromRoute(Name = "id")] string id)
        {
            try
            {
                return Ok(rouletteService.CloseRoulette(id));
            }
            catch (Exception e)
            {
                return StatusCode(404, e.Message.ToString());
            }
        }
    }
}
