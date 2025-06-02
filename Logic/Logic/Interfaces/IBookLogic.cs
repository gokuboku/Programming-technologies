using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic.Interfaces
{
    public interface IBookLogic
    {
        public Guid OwnerId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public Guid Guid { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
        public void SetAvailability(bool isAvailable);
        public void SetOwner(Guid ownerId);
    }
}
