namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op= 0;
            cls cls = new cls();


            do
            {
                Console.WriteLine("selecione un ejerccicio. 1-2-3-4salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cls.ej1();
                        break;
                    case 2:
                        cls.ej2();
                        break;
                    case 3:
                        cls.eje3();
                        break;
                    case 4:
                        Console.WriteLine("saliendo");

                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            } while (op != 4);

        }
    }
}
