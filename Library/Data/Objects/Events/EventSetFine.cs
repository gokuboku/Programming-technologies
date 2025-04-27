using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventSetFine : IEventSetFine
    {
        public Guid UserGuid { get; }

        public double FineAmount { get; }

        public Guid Guid { get; }

        public string Action { get; }

        public DateTime Date { get; }
        public EventSetFine(Guid userGuid, double fineAmount, Guid guid, DateTime date, string action)
        {
            UserGuid = userGuid;
            FineAmount = fineAmount;
            Guid = guid;
            Action = action;
            Date = date;
        }
    }
}
