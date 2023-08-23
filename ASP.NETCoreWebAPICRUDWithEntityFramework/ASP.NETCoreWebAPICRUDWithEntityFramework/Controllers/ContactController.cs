using ASP.NETCoreWebAPICRUDWithEntityFramework.Data;
using ASP.NETCoreWebAPICRUDWithEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreWebAPICRUDWithEntityFramework.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class ContactController : Controller
	{
		private readonly ContactsAPIDbContext DbContext;
        public ContactController(ContactsAPIDbContext DbContex)
        {
            this.DbContext = DbContex;

		}
       
		[HttpGet]
		public async Task<IActionResult> GetContacts()
		{
			return Ok(await DbContext.Contact.ToListAsync());
			

		}

		[HttpGet]
		[Route("{id:guid}")]
		public async Task<IActionResult> GetContact([FromRoute] Guid id)
		{
			var contact = await DbContext.Contact.FindAsync(id);

			if(contact == null)
			{
				return NotFound();
			}
			return Ok(contact);
		}

		[HttpPost]
		public async Task<IActionResult> AddContact(AddContactRequest addContactRequest )
		{
			var contact = new Contact()
			{
				Id = Guid.NewGuid(),
				Address = addContactRequest.Address,
				Email =	addContactRequest.Email,
				FullName =	addContactRequest.FullName,
				Phone = addContactRequest.Phone

			};
		  await	DbContext.Contact.AddAsync(contact);

			await DbContext.Contact.AddAsync(contact);
			await DbContext.SaveChangesAsync();
			return Ok(contact);
		}

		[HttpPut]
		[Route("{id:guid}")]
	    public async Task<IActionResult> UpDateContact([FromRoute] Guid id,UpdateContactRequestcs updateContactRequestcs )
		{
		var contact = await	DbContext.Contact.FindAsync(id);
			if (contact != null)
			{
				contact.FullName = updateContactRequestcs.FullName;
				contact.Address = updateContactRequestcs.Address;
				contact.Phone = updateContactRequestcs.Phone;
				contact.Email = updateContactRequestcs.Email;

				await DbContext.SaveChangesAsync();

				return Ok(contact);

			}
			return NotFound();
		}

		[HttpDelete]
		[Route("{id:guid}")]
		public async Task<IActionResult> DeliteContact([FromRoute] Guid id)
		{
			var contact = await DbContext.Contact.FindAsync(id); 

			if (contact != null)
			{
				DbContext.Remove(contact);
			    await DbContext.SaveChangesAsync();
				return Ok(contact);
			}
			return NotFound();
		}
		
	}

}
