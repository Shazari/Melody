using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Tools.Abstracts;
using Models;

namespace DataLayer
{
   public interface IPaymentUniqueNumberRepository 
    {
        IQueryable<PaymentUniqueNumber> All { get; }
        IQueryable<PaymentUniqueNumber> AllIncluding(params Expression<Func<PaymentUniqueNumber, object>>[] includeProperties);
        PaymentUniqueNumber Find(int id);
        void InsertOrUpdate(PaymentUniqueNumber Category);

        List<PaymentUniqueNumber> DropDownGetAll();
        void Dispose();
    }
}
