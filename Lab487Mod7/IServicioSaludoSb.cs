using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab487Mod7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioSaludoSb" in both code and config file together.
    [ServiceContract(Namespace = "urn:ps")]
    public interface IServicioSaludoSb : IDisposable
    {
        [OperationContract]
        string GetSaludo(String idioma);
    }
}
