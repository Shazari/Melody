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
   public class InstituteRepository: Repository<Institute>, IInstituteRepository
    {
        public InstituteRepository(ContextDB contextDB):base(contextDB)
        {

        }

    }
}
