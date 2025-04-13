using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class EventBorrowBook : Event
    {
        public EventBorrowBook(Guid userId, Guid bookId, DateTime date) : base("Book_borrowed", date)
        {
            UserId = userId;
            BookId = bookId;
        }
        public Guid UserId { get; private set; }
        public Guid BookId { get; private set; }
    }
}
