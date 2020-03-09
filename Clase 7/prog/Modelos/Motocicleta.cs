namespace prog.Modelos
{
    public class Motocicleta : Ivehiculo
    {
             public void Arrancar() 
             {
                 System.Console.WriteLine("Colocar primera, clutch y llave");
             }
    public void cambiarAceite()
        {
           System.Console.WriteLine("Abrir moto, sacar combustible y poner nuevo");
        }

        public void afinarVehiculo()
        {
            System.Console.WriteLine("afinando Motocicleta");
        }
    }
}