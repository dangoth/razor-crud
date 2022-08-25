using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB.Shared.Models;
public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Biography Biography { get; set; }
    public ICollection<Book> Books { get; set; }
    public ICollection<CollaborationBook> CollaborationBooks { get; set; }
}
