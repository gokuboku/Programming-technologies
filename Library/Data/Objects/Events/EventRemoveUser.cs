using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects.Events
{
    public class EventRemoveUser : Event
    {
        public EventRemoveUser(Guid userId, DateTime date) : base("User_removed", date)
        {
            UserId = userId;
        }
        public Guid UserId { get; private set; }
    }
}
