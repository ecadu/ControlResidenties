using Microsoft.AspNetCore.Mvc;
using Resident_Control.Business.Users;
using Resident_Control.Model.Users;

namespace Resident_Control.Controllers 
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IUsersBusiness _usersBusiness;

        public UsersController(IUsersBusiness usersBusiness)
        {
            _usersBusiness = usersBusiness;
        }

        [HttpGet("GetAllUsers")]

        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_usersBusiness.GetAllUsers());
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("VerificationLoguin")]

        public IActionResult VerificationLoguin(string userLoguin, string userPassword)
        {
            try
            {
                if(_usersBusiness.VerificationLoguin(userLoguin, userPassword) != null)
                {
                    return StatusCode(200, "Permitido");
                }
                else
                {
                    return StatusCode(500, "Usuario inexistente");
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
