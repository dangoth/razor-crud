using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB.Shared.Models;
public class CollaborationBook
{
    public int CollaborationBookId { get; set; }
    public string Title { get; set; }
    public int PageCount { get; set; }
    public ICollection<Author> Authors { get; set; }
}
