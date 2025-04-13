using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class EventReturnBook : Event
    {
        public EventReturnBook(Guid bookId, Guid userId, DateTime date) : base("Book_returned", date)
        {
            BookId = bookId;
            UserId = userId;
        }
        public Guid BookId { get; private set; }
        public Guid UserId { get; private set; }
    }
}
