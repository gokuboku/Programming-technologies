using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Interfaces;

namespace Library.Data.Objects.Events
{
    internal class EventAddBook: IEvent
    {
        public Guid Guid { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public EventAddBook(Guid guid, string action, DateTime date)
        {
            Guid = guid;
            Action = action;
            Date = date;
        }
    }
}
