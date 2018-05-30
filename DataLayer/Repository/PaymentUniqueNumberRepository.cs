using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Abstract;
using DataLayer.Tools.Abstracts;
using Models;

namespace DataLayer
{
   public class PaymentUniqueNumberRepository : IPaymentUniqueNumberRepository
    {
        ContextDB context = new ContextDB();
        public IGenericRepository<PaymentUniqueNumber> Implementedfunctions;

        public PaymentUniqueNumberRepository()
        {
            this.Implementedfunctions = new GLIRepository<PaymentUniqueNumber>();
        }
        //public PaymentUniqueNumberRepository(IGenericRepository<PaymentUniqueNumber> instance)
        //{
        //    this.Implementedfunctions = instance;
        //}



        public IQueryable<PaymentUniqueNumber> All
        {
            get { return context.PaymentUniqueNumbers; }
        }

        public IQueryable<PaymentUniqueNumber> AllIncluding(params Expression<Func<PaymentUniqueNumber, object>>[] includeProperties)
        {

            IQueryable<PaymentUniqueNumber> query = context.PaymentUniqueNumbers;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;


        }

        public PaymentUniqueNumber Find(int id)
        {

            return context.PaymentUniqueNumbers.Find(id);

        }

        public void InsertOrUpdate(PaymentUniqueNumber PaymentUniqueNumber)
        {
            //***********************************************************************************//
            // 0 Must be solved
            //***********************************************************************************//
            if (PaymentUniqueNumber.Id == 0)
            {
                // New entity
                context.PaymentUniqueNumbers.Add(PaymentUniqueNumber);
            }
            else
            {
                // Existing entity
                context.Entry(PaymentUniqueNumber).State = System.Data.Entity.EntityState.Modified;
            }


        }

        public void Delete(int id)
        {
            var PaymentUniqueNumber = context.PaymentUniqueNumbers.Find(id);
            context.PaymentUniqueNumbers.Remove(PaymentUniqueNumber);
            context.SaveChanges();
        }



        public void Save()
        {
            context.SaveChanges();
        }



        public void Dispose()
        {
            context.Dispose();
        }

        public void Add(PaymentUniqueNumber entity)
        {
            Implementedfunctions.Add(entity);
            Implementedfunctions.Save();
        }

        public void Delete(PaymentUniqueNumber entity)
        {
            Implementedfunctions.Delete(entity);
            Implementedfunctions.Save();
        }

        public void Edit(PaymentUniqueNumber entity)
        {
            Implementedfunctions.Edit(entity);
            Implementedfunctions.Save();
        }

        public void Edit(PaymentUniqueNumber entity, params Expression<Func<PaymentUniqueNumber, object>>[] propsToUpdate)
        {
            Implementedfunctions.Edit(entity, propsToUpdate);
            Implementedfunctions.Save();
        }

        public void EditAll(PaymentUniqueNumber[] entities)
        {
            Implementedfunctions.EditAll(entities);
            Implementedfunctions.Save();
        }

        public IQueryable<PaymentUniqueNumber> GetAll()
        {
            return Implementedfunctions.GetAll();
        }

        public List<PaymentUniqueNumber> DropDownGetAll()
        {
            return context.PaymentUniqueNumbers.ToList();
        }

        public IQueryable<PaymentUniqueNumber> FindBy(Expression<Func<PaymentUniqueNumber, bool>> predicate)
        {
            throw new NotImplementedException();
        }


    }
}
