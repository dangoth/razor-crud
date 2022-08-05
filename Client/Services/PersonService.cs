using PersonDB.Shared;
using System.Net.Http.Json;

namespace PersonDB.Client.Services;

public class PersonService : IPersonService
{
    private readonly HttpClient _httpClient;
    public PersonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public List<Person> Persons { get; set; } = new List<Person>();
    public event Action OnChange;

    public async Task<List<Person>> GetPersons()
    {
        Persons = await _httpClient.GetFromJsonAsync<List<Person>>("api/person");
        return Persons;
    }

    public async Task<Person> GetPerson(int id)
    {
        return await _httpClient.GetFromJsonAsync<Person>($"api/person/{id}");
    }

    public async Task<List<Person>> CreatePerson(Person person)
    {
        var result = await _httpClient.PostAsJsonAsync<Person>($"api/person", person);
        Persons = await result.Content.ReadFromJsonAsync<List<Person>>();
        OnChange.Invoke();
        return Persons;
    }

    public async Task<List<Person>> UpdatePerson(Person person, int id)
    {
        var result = await _httpClient.PutAsJsonAsync($"api/person/{id}", person);
        Persons = await result.Content.ReadFromJsonAsync<List<Person>>();
        OnChange.Invoke();
        return Persons;
    }

    public async Task<List<Person>> DeletePerson(int id)
    {
        var result = await _httpClient.DeleteAsync($"api/person/{id}");
        Persons = await result.Content.ReadFromJsonAsync<List<Person>>();
        OnChange.Invoke();
        return Persons;
    }
}
