using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using KMA.APZRP2019.WalletSimulator.DBModels;

namespace KMA.APZRP2019.WalletSimulator.Providers.DB.EntityFramework
{
    public class EntityFrameworkDBProvider:IDBProvider
    {
        private bool _disposed;
        private readonly WalletDBContext _context;
        public EntityFrameworkDBProvider()
        {
            _context = new WalletDBContext();
        }

        ~EntityFrameworkDBProvider()
        {
            Dispose(false);
        }

        #region IDBProviderImplementation
        public IEnumerable<TObject> SelectAll<TObject>(Func<TObject, bool> selectFunc=null) where TObject : class, IDBModel
        {
            return selectFunc != null ? _context.Set<TObject>().Where(selectFunc).ToList() : _context.Set<TObject>().ToList();
        }
        public TObject Select<TObject>(Func<TObject, bool> selectFunc) where TObject : class, IDBModel
        {
            return _context.Set<TObject>().FirstOrDefault(selectFunc);
        }
        public void Update<TObject>(IEnumerable<TObject> objects) where TObject : class, IDBModel
        {
            foreach (var model in objects)
            {
                if (_context.Set<TObject>().Any(obj => obj.Guid==model.Guid))
                {
                    _context.Entry(model).State = EntityState.Modified;
                }
            }
            _context.SaveChanges();
        }

        public void Update<TObject>(TObject obj) where TObject : class, IDBModel
        {
            if (_context.Set<TObject>().Any(o => o.Guid == obj.Guid))
            {
                _context.Entry(obj).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void Delete<TObject>(IEnumerable<TObject> objects) where TObject : class, IDBModel
        {
            foreach (var model in objects)
            {
                if (_context.Set<TObject>().Any(obj => obj.Guid == model.Guid))
                {
                    _context.Set<TObject>().Remove(model);
                }
            }
            _context.SaveChanges();
        }

        public void Delete<TObject>(TObject obj) where TObject : class, IDBModel
        {
            if (_context.Set<TObject>().Any(o => o.Guid == obj.Guid))
            {
                _context.Set<TObject>().Remove(obj);
            }
            _context.SaveChanges();
        }

        public void Add<TObject>(IEnumerable<TObject> objects) where TObject : class, IDBModel
        {
            foreach (var model in objects)
            {
                if (!_context.Set<TObject>().Any(obj => obj.Guid == model.Guid))
                {
                    _context.Set<TObject>().Add(model);
                }
            }
            _context.SaveChanges();
        }

        public void Add<TObject>(TObject obj) where TObject : class, IDBModel
        {
            if (!_context.Set<TObject>().Any(o => o.Guid == obj.Guid))
            {
                _context.Set<TObject>().Add(obj);
            }
            _context.SaveChanges();
        }
        #endregion









        #region IDisposableImplementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context?.Dispose();
            }

            // Free any unmanaged objects here.
            _disposed = true;
        }
        #endregion

    }
}
