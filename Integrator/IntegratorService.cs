using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Integrator.BL;
using System.Configuration;
using System.Xml.Linq;
using System.Timers;
using System.Net;

namespace Integrator
{
    using System.IO;

    
    using System.Collections;

    // Start the service and browse to http://<machine_name>:<port>/Service1/help to view the service's generated help page
    // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
    // a single instance of the service to process all calls.	
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class IntegratorService
    {

        public IntegratorService()
        {
        }

        [OperationContract]
        [WebGet(UriTemplate = "/startmicrositetimer?password={password}", ResponseFormat = WebMessageFormat.Xml)]
        [XmlSerializerFormat(Style = OperationFormatStyle.Document, Use = OperationFormatUse.Literal)]
        public string startmicrositetimer(string password)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
            
                return "Microsite timer started it will read the xml file";
          
        }
        
        [OperationContract]
        [WebInvoke(UriTemplate = "/getproducts?minid={minid}&maxid={maxid}", Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public List<string> GetProducts(string minid,string maxid)
        {
            if (string.IsNullOrEmpty(minid))
            {
                minid = "0";
            }
            if (string.IsNullOrEmpty(maxid))
            {
                maxid = "0";
            }

           List<string> somthing = new List<string>();
            return somthing;
        }

    }
}

