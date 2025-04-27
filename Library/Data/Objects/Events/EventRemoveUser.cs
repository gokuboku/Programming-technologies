using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventRemoveUser : IEventRemoveUser
    {
        public Guid UserGuid { get; }

        public Guid Guid { get; }

        public string Action { get; } = "RemoveUser";

        public DateTime Date { get; }
        public EventRemoveUser(Guid userGuid, Guid guid, DateTime date)
        {
            UserGuid = userGuid;
            Guid = guid;
            Date = date;
        }
    }
}
