using AdressBookApp.Server.Models;
using AdressBookApp.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AdressBookApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("randomcontact")]
        public async Task<IActionResult> GetRandomUser()
        {
            var randomUser = await _contactService.GetRandomContact();

            return Ok(randomUser);
        }

        [HttpGet("searchcontact")]
        public async Task<IActionResult> SearchUserByName([FromQuery] string name)
        {
            var user = await _contactService.GetUserByNameAsync(name);

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound($"User with name '{name}' not found.");
            }
        }
    }
}
