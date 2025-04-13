using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class EventSetFine : Event
    {
        public EventSetFine(string action, Guid userId, DateTime date, double fineAmount): base(action, date)
        {
            UserId = userId;
            FineAmount = fineAmount;
        }
        public Guid UserId { get; private set; }
        public double FineAmount { get; private set; }
    }
}
