using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventAddBook: Event
    {
        public EventAddBook(Guid bookId, DateTime date) : base("Book_added", date)
        {
            BookId = bookId;
        }
        public Guid BookId { get; private set; }
    }
}
