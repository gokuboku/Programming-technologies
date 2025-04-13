using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class EventAddUser : Event
    {
        public EventAddUser(Guid userId, DateTime date) : base("User_added", date)
        {
            UserId = userId;
        }
        public Guid UserId { get; private set; }
    }
}
