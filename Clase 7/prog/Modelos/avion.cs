namespace prog.Modelos
{
    public class avion : Ivehiculo
    {
        public int CantidadAlas { get; set; }
        public bool TieneTurbina { get; set; }
        public string TipoDeAvion { get; set; }
    
        public void Volar()
        {
            System.Console.WriteLine("Estoy volando");
        }

        public void Aterrizar()
        {
            System.Console.WriteLine("Estoy aterrizando");
        }

        public  void Arrancar() 
             {
                 System.Console.WriteLine("Presionar botones");
             }

        public void cambiarAceite()
        {
           System.Console.WriteLine("Abrir avion, sacar combustible y poner nuevo");
        }

        public void afinarVehiculo()
        {
            System.Console.WriteLine("afinando Avion");
        }
    }
}