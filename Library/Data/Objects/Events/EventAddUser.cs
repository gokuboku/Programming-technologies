using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    internal class EventAddUser : IEventAddUser
    {

        public Guid UserGuid { get; }
        public DateTime Date { get; }

        public Guid Guid { get; }

        public string Action { get; } = "AddUser";

        public EventAddUser(Guid userGuid, DateTime eventDate, Guid guid, string action)
        {
            this.UserGuid = userGuid;
            this.Date = eventDate;
            this.Guid = guid;
            this.Action = action;
        }
    }
}
