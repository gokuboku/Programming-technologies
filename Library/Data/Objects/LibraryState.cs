using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects
{
    public class LibraryState
    {
        public IEnumerable<Book> Books { get; private set; }
        public IEnumerable<User> Users { get; private set; }
    }
}
