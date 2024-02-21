using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera.Negocio.Connection
{
    public static class StringConnection
    {

        public static IConfiguration Configuracion { get; set; }

        /// <summary>
        /// Cadena de Conexión tomado del json
        /// </summary>
        public static string stringConnection;

        public static string GetStringConnection()
        {
            // Archivo el cual contiene la cadena de conexión
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuracion = builder.Build();

            stringConnection = Configuracion.GetConnectionString(Configuracion["ConexionSql"]);
            return stringConnection;
        }
    }
}
