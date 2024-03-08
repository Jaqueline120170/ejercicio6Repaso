namespace ejercicio6Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cadena de texto");
            string texto = Console.ReadLine();
            string[] auxiliar = texto.Split(' ');
            Array.Reverse(auxiliar);
            string texto2 = String.Join(" ", auxiliar);

            Console.WriteLine(texto2);
            
           

             static string InvertirManualmente(string cadena)
            {
                string cadenaInvertida = "";
                // Recorrer cadena letra por letra
                foreach (char letra in cadena)
                {
                    // Anteponer la letra a la cadena invertida
                    cadenaInvertida = letra + cadenaInvertida;
                }
                return cadenaInvertida;
            }
            Console.WriteLine(InvertirManualmente(texto));

            static string Invertir(string cadena)
            {
                // Convertir a arreglo
                char[] cadenaComoCaracteres = cadena.ToCharArray();
                // Invertir el arreglo usando métodos incorporados
                Array.Reverse(cadenaComoCaracteres);
                // Convertir de nuevo el arreglo a cadena
                return new string(cadenaComoCaracteres);
            }
            Console.WriteLine(Invertir(texto));
        }
    }
}