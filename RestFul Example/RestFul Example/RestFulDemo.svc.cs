using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestFul_Example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestFulDemo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestFulDemo.svc or RestFulDemo.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(AddressFilterMode =AddressFilterMode.Any)]
    public class RestFulDemo : IRestFulDemo
    {
        public string GetDefaultFormat(string id) => $"This is XmlFormat {id}";

        public string GetJsonFormat(string id) => $"This is Json Format {id}";

    }
}
