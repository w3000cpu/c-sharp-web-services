using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.ServiceModel.Web;

namespace RestFul_Example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestFulDemo" in both code and config file together.
    [ServiceContract]
    public interface IRestFulDemo
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "/GetDefaultFormat/{id}")]
        string GetDefaultFormat(string id);

        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetJsonFormat/{id}")]
        string GetJsonFormat(string id);
    }
}
