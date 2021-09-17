using System;

namespace VowelsCounterApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### -- CONTAR VOCALES -- ####");
            VowelsCounter();
        }

        public static void VowelsCounter()
        {
            var text = "";
            while(text != "@")
            {
                Console.WriteLine("Si desea salir pulse [@] \n Digite una cadena para obtener sus vocales :  ");
                text = Console.ReadLine();

                var parameter = Counter.VowelsCounter.Count(text);
                foreach (var item in parameter)
                {
                    Console.WriteLine($"{item} - \n");
                }


            }



        }


    }
}
