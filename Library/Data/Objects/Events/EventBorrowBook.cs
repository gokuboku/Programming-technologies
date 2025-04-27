using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventBorrowBook : IEventBorrowBook
    {
        public Guid BookGuid { get; }

        public Guid UserGuid { get; }
        public Guid Guid { get; }

        public string Action { get; } = "BorrowBook";

        public DateTime Date { get; }

        public EventBorrowBook(Guid bookGuid, Guid userGuid, Guid guid,DateTime date)
        {
            BookGuid = bookGuid;
            UserGuid = userGuid;
            Guid = guid;
            Date = date;
        }
    }
}
