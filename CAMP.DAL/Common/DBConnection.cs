using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CAMP.Model;

namespace CAMP.DAL.Common
{
    public class DBConnection : IDisposable
    {
        #region Fields

        private InstaScalerEntities _dataContext;

        #endregion Fields


        #region Properties

        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        public InstaScalerEntities DataContext
        {
            get
            {
                return this._dataContext;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        public DBConnection()
        {
            this._dataContext = new InstaScalerEntities();

        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Flushes this instance.
        /// </summary>
        public void Flush()
        {
            //_dataContext.SaveChanges();

            _dataContext.Dispose();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            Flush();
        }

        #endregion Methods
    }
}