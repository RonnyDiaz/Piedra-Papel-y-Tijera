using System;

namespace Juego_piedra_papel_tijera
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            string pc = "";
            string player = "";
            string respuesta ="";
            
            Random a = new Random();
            aleatorio = a.Next(1, 4);

            Console.Write("Elije: Piedra, Papel o Tijera: ");
            player = Console.ReadLine().ToLower();
            if (aleatorio == 1)
            {
                pc = "tijera";
            }
            if (aleatorio == 2)
            {
                pc = "piedra";
            }
            if (aleatorio == 3)
            {
                pc = "papel";
            }
           
            if(player == "piedra" && pc == "piedra" || player == "papel" && pc == "papel" || player == "tijera" && pc == "tijera")
            {
                respuesta = "Empate";
            }
            
                if (player == "piedra" && pc == "tijera" || player == "tijera" && pc == "papel" || player == "papel" && pc == "piedra")
                {
                    respuesta = "Has Ganado!";
                }
                 if(pc == "piedra" && player == "tijera" || pc == "tijera" && player == "papel" || pc == "papel" && player == "piedra")
                 {
                    respuesta = "Has Perdido";
                 }

            Console.WriteLine("Yo: {0}", player);
            Console.WriteLine("PC: {0}", pc);
            Console.WriteLine(respuesta);
        
        }
          
           
    }
}
 

