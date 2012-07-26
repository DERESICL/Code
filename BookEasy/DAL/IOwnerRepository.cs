using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;

namespace BookEasy.DAL
{

    //This code declares a typical set of CRUD methods, including 
    //two read methods — one that returns all Owner entities, and one that finds a single Owner entity by ID.
    public interface IOwnerRepository : IDisposable
    {
        IEnumerable<Owner> GetOwners();
        Owner GetOwnerByID(int OwnerId);
        void InsertOwner(Owner Owner);
        void DeleteOwner(int OwnerID);
        void UpdateOwner(Owner Owner);
        void Save();
    }
}