using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class Event
    {
        public string Action { get; private set; }
        public DateTime Date { get; private set; }
        public Event(string action, DateTime date)
        {
            Action = action;
            Date = date;
        }
    }
}
