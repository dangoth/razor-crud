using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonDB.Server.Data;
using PersonDB.Shared;

namespace PersonDB.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly DataContext _context;
    public PersonController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> GetPersons()
    {
        return Ok(await _context.Persons.ToListAsync());
    }
   [HttpPost]
    public async Task<IActionResult> CreatePerson(Person person)
    {
        _context.Persons.Add(person);
        await _context.SaveChangesAsync();
        return Ok(await _context.Persons.ToListAsync());
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePerson(Person person, int id)
    {
        var personToUpdate = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
        if (personToUpdate == null) return NotFound("Incorrect person ID");
        personToUpdate.FirstName = person.FirstName;
        personToUpdate.LastName = person.LastName;
        personToUpdate.Gender = person.Gender;
        personToUpdate.Email = person.Email;
        personToUpdate.PhoneNumber = person.PhoneNumber;
        personToUpdate.Age = person.Age;
        await _context.SaveChangesAsync();
        return Ok(await _context.Persons.ToListAsync());
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var personToDelete = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
        if (personToDelete == null) return NotFound("Incorrect person ID");
        _context.Persons.Remove(personToDelete);
        await _context.SaveChangesAsync();
        return Ok(await _context.Persons.ToListAsync());
    }
}
