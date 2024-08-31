

namespace Principio_ISP
{
      public class Pato : IAves, IAves2
    {
        public Pato()
        {
            Console.WriteLine("Soy un Pato");

        }
        
        public void Nadar()
        {
            Console.WriteLine("Puedo Nadar");

        }
        public void Cazar()
        {
            Console.WriteLine("Puedo Cazar para alimentarme");

        }
        public void PonerHuevos()
        {
            Console.WriteLine("Tengo la capacidad de poner Huevos");

        }
        public void cantar()
        {
            Console.WriteLine("Puedo cantar");

        }
        public void volar()
        {
            Console.WriteLine("Puedo volar");
        }
    }
}
