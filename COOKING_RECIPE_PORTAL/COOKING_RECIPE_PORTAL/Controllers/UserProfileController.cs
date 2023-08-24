using COOKING_RECIPE_PORTAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COOKING_RECIPE_PORTAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly LoginContext _dbContext;
        public UserProfileController(LoginContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetUserById(int id)
        {
            if (_dbContext.Login == null)
            {
                return NotFound();
            }

            var login = await _dbContext.Login.FindAsync(id);
            return login;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProfile(Login login)
        {
            _dbContext.Entry(login).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfileAvailable(login.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        private bool ProfileAvailable(int id)
        {
            return (_dbContext.Login?.Any(x => x.Id == id)).GetValueOrDefault();
        }
    }
}
