using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Tools.Infrastructure;

namespace DataLayer.Abstract
{
    public class GLIRepository<T> : GenericRepository<ContextDB,T> where T:class
    {
    }
}
