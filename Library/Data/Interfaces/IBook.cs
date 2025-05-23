﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IBook
    {
        public string Isbn { get; }
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int Year { get; }
        public Guid Guid { get; }
        public int Pages { get; }
        public bool IsAvailable { get; }
        public void SetAvailability(bool isAvailable);
    }
}
