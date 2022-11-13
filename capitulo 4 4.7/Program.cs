namespace ejercicio4
{
    public class ejercicio4
    {
        public static void Main()
        {
            int numero1;
            int numero2;

            Console.WriteLine("ingrese el numero mayor ");
            numero1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero menor");
            numero2=int.Parse(Console.ReadLine());

            if (numero1%numero2== 0)
            {
                Console.WriteLine(numero2 + "es divisor de " + numero1);

            }
            else
            {
                Console.WriteLine(numero2 + "no es divisor de " + numero1 );
            }
        }
    }
}