using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BookEasy.Models;


namespace BookEasy.DAL
{
    public class OwnerRepository : IOwnerRepository, IDisposable
    {
        private PropertyContext context;

        public OwnerRepository(PropertyContext context)
        {
            this.context = context;
        }

        public IEnumerable<Owner> GetOwners()
        {
            return context.Owners.ToList();
        }

        public Owner GetOwnerByID(int id)
        {
            return context.Owners.Find(id);
        }

        public void InsertOwner(Owner Owner)
        {
            context.Owners.Add(Owner);
        }

        public void DeleteOwner(int OwnerID)
        {
            Owner Owner = context.Owners.Find(OwnerID);
            context.Owners.Remove(Owner);
        }

        public void UpdateOwner(Owner Owner)
        {
            context.Entry(Owner).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}