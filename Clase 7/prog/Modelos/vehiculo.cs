namespace prog.Modelos
{
    public class vehiculo : Ivehiculo //Indicador de la interfaz. ABAJO SE TIENE QUE IDENTIFICAR.
    {
        private bool TieneClima;
        public int Asientos { get; set; }
        public string Color { get; set; }

        public virtual void Arrancar()
        {
            System.Console.WriteLine("El vehículo está arrancando");
    }
        public void Apagar()
        {
            System.Console.WriteLine("El vehículo se está apagando");
        }

        public void cambiarAceite()
        {
            System.Console.WriteLine("Cambiando aceite del vehiculo");
        }

        public void afinarVehiculo()
        {
            System.Console.WriteLine("Afinando Vehiculo");
        }
    }
}