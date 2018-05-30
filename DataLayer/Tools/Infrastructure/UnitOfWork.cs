using DataLayer.Tools.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tools.Infrastructure
{
    public class UnitOfWork : object, IUnitOfWork
    {

        public UnitOfWork()
        {
            IsDisposed = false;
        }

        protected bool IsDisposed { get; set; }

        private ContextDB contextDB;
        protected ContextDB ContextDB
        {
            get
            {
                if(contextDB==null)
                {
                    contextDB = new ContextDB();
                }
                return contextDB;
            }
        }

        private ICourseRepository courseRepository;

        public ICourseRepository CourseRepository
        {
            get
            {
                if(courseRepository==null)
                {
                    courseRepository = new CourseRepository(ContextDB);
                }
                return courseRepository;

            }
        }
        public void Save()
        {
            try
            {
                ContextDB.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed == false)
            {
                if (disposing)
                {
                    contextDB.Dispose();
                }
            }
            IsDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
