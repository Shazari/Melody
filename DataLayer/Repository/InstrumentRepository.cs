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
   public class InstrumentRepository: Repository<Instrument> ,  IInstrumentRepository
    {
        public InstrumentRepository(ContextDB contextDB):base(contextDB)
        {

        }
    }
}
