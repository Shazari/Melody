using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Tools.Infrastructure;

namespace Melody.Infrastructure
{
    public class BaseUnitOfWorkController : BaseController
    {
        public BaseUnitOfWorkController()
        {
        }

        private UnitOfWork _unitOfWork;

        protected virtual UnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork == null)
                {
                    _unitOfWork = new UnitOfWork();
                }
                return (_unitOfWork);
            }
        }

        /// <summary>
        /// Version: 1.0.2
        /// Update Date: 1394/02/16
        /// Changed In Version: 1.9.2
        /// Developer: Mr. Dariush Tasdighi
        /// </summary>
        protected virtual void DisposeCurrentUnitOfWorkAndCreateANewOne()
        {
            if (_unitOfWork != null)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }

            _unitOfWork =
                new UnitOfWork();
        }

        protected override void Dispose(bool disposing)
        {
            if (_unitOfWork != null)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }

            base.Dispose(disposing);
        }
    }
}