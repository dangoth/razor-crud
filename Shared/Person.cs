using System.ComponentModel.DataAnnotations;

namespace PersonDB.Shared;
public class Person
{
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "Please enter a first name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Please provide a last name")]
    public string LastName { get; set; }
    public GenderEnum Gender { get; set; }
    [Range(0, 120, ErrorMessage = "Please choose a correct age")]
    public int Age { get; set; }
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "You must provide a phone number")]
    public string PhoneNumber { get; set; }
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
}
