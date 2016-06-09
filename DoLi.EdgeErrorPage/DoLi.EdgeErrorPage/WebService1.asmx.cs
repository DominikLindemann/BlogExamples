using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DoLi.EdgeErrorPage
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string A_HelloWorld()
        {
            return $"Hello World {DateTime.Now}";
        }

        [WebMethod]
        public string B_NoErrorMessage()
        {
            throw GetDefaultException();
        }

        [WebMethod]
        public string C_ErrorMessage()
        {
            Exception exception = GetDefaultException();

            int byteToShowInEdgeAnError = 512;
            if (exception.Message.Length < byteToShowInEdgeAnError)
            {
                string extraData = string.Concat(Enumerable.Repeat(" ", byteToShowInEdgeAnError - exception.Message.Length));
                throw new InvalidOperationException(exception.Message + extraData);
            }
            else
            {
                throw exception;
            }
        }

        private Exception GetDefaultException()
        {
            return new Exception($"World's End at {DateTime.Now}");
        }
    }
}
