using System;
using prog.Modelos;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARA CREAR UN PROYECTO EN CONSOLA ES: dotnet new console -o NombreProyecto
            //PARA CORRER LA CONSOLA ES dotnet run Y PARA LIMPIAR es cls 
            


            /*var carro = new vehiculo();
            carro.Asientos=4;
            carro.Arrancar();

            avion cargo = new avion();
            cargo.Color = "blanco";
            cargo.Asientos = 100;
            cargo.CantidadAlas = 4;
            cargo.TieneTurbina = true;

            cargo.Arrancar();
            cargo.Volar();*/


            //********************************ABSTRACCIÓN********************************//
            /*
                    ES LA MANERA EN LA QUE CADA OBJETO REACCIONA DIFERENTE A UN METODO PADRE

            avion avioneta = new avion();
            avioneta.Arrancar();

            Motocicleta moto = new Motocicleta();
            moto.Arrancar();*/

            //*************************POLIMORFISMO E INTERFACES*************************//
            /*
                EL POLIMORFISMO ES MUY SIMILAR A LA ABSTRACCIÓN, PERO SE DA EN INTERFACES
            
            */

        }
    }
}