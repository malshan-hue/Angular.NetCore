using Angular.NetCore.Server.Data;
using Angular.NetCore.Server.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular.NetCore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactDbContext dbcontext;

        public ContactsController(ContactDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = dbcontext.Contacts.ToList();

            if(contacts.Count == 0)
            {
                return NotFound(new {message = "contact data not found"});
            }

            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dbcontext.Contacts.Add(contact);
                    dbcontext.SaveChanges();
                }
                catch(Exception ex)
                {
                    return BadRequest(new {message = "contact not saved", ex.Message });
                }
            }
            else
            {
                var errorList = ModelState.Where(ms => ms.Value.Errors.Any()).Select(ms => new { Field = ms.Key, Errors = ms.Value.Errors.Select(e => e.ErrorMessage).ToList() }).ToList();

                return BadRequest(new { message = "check your contact details", errorList });
            }

            return Ok(new { message = "contact saved successfully", contact });
        }
    }
}
