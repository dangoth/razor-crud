using PersonDB.Shared;

namespace PersonDB.Client.Services;

public interface IPersonService
{
    List<Person> Persons { get; set; }
    public event Action OnChange;
    Task<List<Person>> GetPersons();
    Task<Person> GetPerson(int id);
    Task<List<Person>> CreatePerson(Person person);
    Task<List<Person>> UpdatePerson(Person person, int id);
    Task<List<Person>> DeletePerson(int id);
}
