using System;
using System.Web.Mvc;
using log4net;

namespace Buceo.Web.Core
{
    public class BaseController : Controller
    {
        #region Variables Privadas

        protected static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Métodos

        protected void LogError(Exception exception)
        {
            Logger.Error(string.Format("Mensaje: {0} Trace: {1}", exception.Message, exception.StackTrace));
        }

        #endregion
    }
}