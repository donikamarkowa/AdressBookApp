using AdressBookApp.Server.Models;
using AdressBookApp.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Xml.Linq;

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
        public async Task<IActionResult> GetRandomContact()
        {
            var randomUser = await _contactService.GetRandomContact();

            if (randomUser != null)
            {
                return Ok(randomUser);
            }
            else
            {
                return NotFound($"Cannot generate random contact.");
            }

        }

        [HttpGet("searchcontact")]
        public async Task<IActionResult> SearchContactByName([FromQuery] string name)
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
