using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventRemoveBook: IEventRemoveBook
    {
        public Guid BookGuid { get; }

        public Guid Guid { get; }
        public string Action { get; } = "RemoveBook";

        public DateTime Date { get; }

        public EventRemoveBook(Guid bookGuid, Guid guid, DateTime date)
        {
            BookGuid = bookGuid;
            Guid = guid;
            Date = date;
        }
    }
}
