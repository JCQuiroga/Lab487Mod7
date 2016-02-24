using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;

namespace Lab487Mod7
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(ServicioSaludoSb));
            
            sh.AddServiceEndpoint(typeof(IServicioSaludoSb), new NetTcpBinding(), "net.tcp://localhost:9358/saludo");
            sh.AddServiceEndpoint(typeof(IServicioSaludoSb), new NetTcpRelayBinding(), ServiceBusEnvironment.CreateServiceUri("sb", "lab487mod7sb", "saludo")).Behaviors.Add(new TransportClientEndpointBehavior
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", "xc/k9keil4yuD9dCw2+8UxsCnIz1+18mlqeTfX2KayU=")
            });
            sh.Open();
            Console.WriteLine("Pulsa enter para terminar");
            Console.ReadLine();
            sh.Close();
        }
    }
}
