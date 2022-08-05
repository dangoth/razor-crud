using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonDB.Shared;

namespace PersonDB.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    static List<Person> persons = new List<Person> {
        new Person{Id = 1, FirstName = "Peter", LastName = "Johns", Gender = GenderEnum.Male, Email = "peter.johns@gmail.com", PhoneNumber = "00312642236", Age = 32 },
        new Person{Id = 2, FirstName = "Joe", LastName = "Walsh", Gender = GenderEnum.Male, Email = "joe23@gmail.com", PhoneNumber = "0048125629349", Age = 28 }
    };
    [HttpGet]
    public async Task<IActionResult> GetPersons()
    {
        return Ok(persons);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSinglePerson(int id)
    {
        var person = persons.FirstOrDefault(p => p.Id == id);
        if (person == null) return NotFound("Incorrect person ID");
        return Ok(person);
    }
   [HttpPost]
    public async Task<IActionResult> CreatePerson(Person person)
    {
        person.Id = persons.Max(p => p.Id + 1);
        persons.Add(person);
        return Ok(persons);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePerson(Person person, int id)
    {
        var personToUpdate = persons.FirstOrDefault(p => p.Id == id);
        if (personToUpdate == null) return NotFound("Incorrect person ID");
        var index = persons.IndexOf(personToUpdate);
        persons[index] = person;
        return Ok(persons);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var personToDelete = persons.FirstOrDefault(p => p.Id == id);
        if (personToDelete == null) return NotFound("Incorrect person ID");
        persons.Remove(personToDelete);
        return Ok(persons);
    }
}
