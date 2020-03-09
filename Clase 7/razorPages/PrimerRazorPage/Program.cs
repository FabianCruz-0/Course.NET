using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PrimerRazorPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //***************************************************************************//
            /*
                        PARA CREAR UN PROYECTO DE RAZOR PAGES ES: dotnet new mvc -o NombreProyecto
                        Para escribir un codigo de c# es necesario @{ --codigo-- }.
                        
                        ------------ DOCUMENTACION DE MICROSOFT ---------------
                        CONTROLADORES: CLICK DERECHO, CREAR CLASE."nombreCONTROLLER.cs
                        LOS CONTROLADORES SON LAS DISTINTAS URL'S.
                        Para acceder es: localhost:5001/NombreDelControlador (Sin la palabra Controller)

                        ------------------ VISTAS (VIEWS)-------------------------
                        LAS VISTAS SON LOS DOCUMENTOS .CSHTML.

                        PARA CADA CONTROLADOR SE DEBE CREAR UNA CARPETA CON EL MISMO NOMBRE EN LA 
                        CARPETA DE VIEWS.

                        PARA ABRIR EL VIEW DE UN CONTROLADOR, EN EL CONTROLADOR DEBES PONER IActionResult.

                        DESPUÉS SOLO ES CUESTION DE ABRIR CON localhost:5001/NombreDelControlador

                        SI HAY MÁS DE UNA ACCIÓN( INDEX) ENTONCES SE UTILIZA: 
                        localhost:5001/NombreDelControlador/Nombredelaaccion
            */
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
