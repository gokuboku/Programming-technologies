using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects
{
    internal class LibraryState: ILibraryState
    {
        public List<IBook> Books { get; set; } = new List<IBook>();
        public List<IUser> Users { get; set; } = new List<IUser>();
    }
}
