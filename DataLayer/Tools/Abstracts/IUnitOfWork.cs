using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tools.Abstracts
{
    public interface IUnitOfWork:IDisposable
    {
        ICourseRepository CourseRepository { get; }


        void Save();
    }
}
