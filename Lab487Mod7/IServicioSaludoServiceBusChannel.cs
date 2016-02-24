using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Lab487Mod7
{
    public interface IServicioSaludoServiceBusChannel : IServicioSaludoSb,
IClientChannel
    {}

    public class ServicioSaludoSb : IServicioSaludoSb
    {
        Dictionary<String, String> saludos = new Dictionary<string, string>()
        {
            { "es","Buenos dias"},
            {"en","Good morning"},
            {"fr","Bon jour"},
            { "de","Guten morgen"}
        };

        public string GetSaludo(string idioma)
        {
            if (saludos.ContainsKey(idioma)) return saludos[idioma];
            return saludos["en"];
        }

        public void Dispose()
        {
        }
    }
}