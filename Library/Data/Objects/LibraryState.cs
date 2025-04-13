using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects
{
    public class LibraryState
    {
        public List<Book> Books { get; private set; } = new List<Book>();
        public List<User> Users { get; private set; } = new List<User>();
    }
}
