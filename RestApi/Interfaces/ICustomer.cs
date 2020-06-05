using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace RestApi.Interfaces
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,

               BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetCustomers")]

        List<Customer> GetCustomerList();
    }
}