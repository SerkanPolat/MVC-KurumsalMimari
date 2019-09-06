using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Nortwind.MvcWebUI.Infrastructure
{
    public static class WcfProxy<T>
    {
        //WCF'DE ABC AYARLANMALIDIR. A=ADRESS B=BINDING C=CHANNEL
        public static T CreateChannel()
        {
            string Adress = String.Format("http://localhost:50513/{0}.svc?wsdl",
                                                                typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();

            var channel = new ChannelFactory<T>(binding,Adress);

            return channel.CreateChannel();
        }

    }
}