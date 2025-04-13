using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventRemoveBook: Event
    {
        public EventRemoveBook(Guid bookId, DateTime date) : base("Book_removed", date)
        {
            BookId = bookId;
        }
        public Guid BookId { get; private set; }
    }
}
