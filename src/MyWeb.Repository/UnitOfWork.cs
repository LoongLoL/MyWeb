using System;
using MyWeb.Models;


namespace MyWeb.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly MyWebDbContext context;
        public UnitOfWork(MyWebDbContext context)
        {
            this.context = context;
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