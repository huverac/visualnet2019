using System;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine(" ------------------------------------------\n| PROGRAMA PARA LA LONGITUD DE DOS DIGITOS |\n ------------------------------------------");
            Console.WriteLine("Digite un número");
            numero = int.Parse(Console.ReadLine());
            if(numero > 9){
                Console.WriteLine("El número tiene dos dígitos");
            }else{
                Console.WriteLine("El número no tiene dos digitos");
            }
            Console.ReadKey();
        }
    }
}
