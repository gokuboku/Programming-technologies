﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Data.Objects;
using Library.Data.Objects.Events;

namespace Library.Data.Interfaces
{
    public interface IRepository
    {
        public IList<IUser> GetAllUsers();
        public IList<IBook> GetCatalog();
        public ILibraryState GetLibraryState();
        public IList<IEvent> GetEvents();
        public void AddUser(IUser user);
        public void RemoveUser(IUser user);
        public void AddBook(IBook book);
        public void RemoveBook(IBook book);
        public void BorrowBook(IBook book, IUser user);
        public void ReturnBook(IBook book, IUser user);
        public void SetFine(IUser user, double amount);
    }
}
