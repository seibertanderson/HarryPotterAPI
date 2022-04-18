using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Net;

namespace HarryPotterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<House>>> GetAll()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return new HouseAppService().GetAll();
                });
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("GetAll2")]
        public async Task<ActionResult<List<House>>> GetAll2()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return new HouseAppService().GetAll();
                });
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<House>> GetById(int id)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return new HouseAppService().GetById(id);
                });
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
