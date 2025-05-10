using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class cls
    {
        public void ej1()
        {

            Console.WriteLine("ingrese cuantos alumnos hay ");
            int n = int.Parse(Console.ReadLine());

            string[] nombres = new string[n];
            bool[] asistencias = new bool[n];
            int totalasistencias = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del alumno");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("asitio? (si/no)");
                asistencias[i] = Console.ReadLine().ToLower() == "si";
                if (asistencias[i])
                {
                    totalasistencias++;
                }

            }
            Console.WriteLine("la cantidad de alumnos que asistieron es: " + totalasistencias);
            double porcentajeasistecia = (double)totalasistencias / nombres.Length * 100;
            Console.WriteLine("el porcentaje de asistencia es: " + porcentajeasistecia + "%");



        }

        public void ej2()
        {
            int cantidadDeportistas;
            int indiceMasRapido = 0;
            int indiceMejorRendimiento = 0;

            Console.Write("Ingrese la cantidad de deportistas: ");
            cantidadDeportistas = int.Parse(Console.ReadLine());

            string[] nombres = new string[cantidadDeportistas];
            double[] tiempos = new double[cantidadDeportistas];
            double[] distancias = new double[cantidadDeportistas];
            double[] rendimientos = new double[cantidadDeportistas];

            // Registrar los datos de cada deportista
            for (int i = 0; i < cantidadDeportistas; i++)
            {
                Console.WriteLine($"\nDeportista {i + 1}");

                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Tiempo (en segundos): ");
                tiempos[i] = double.Parse(Console.ReadLine());

                Console.Write("Distancia (en metros): ");
                distancias[i] = double.Parse(Console.ReadLine());

                // Calcular rendimiento (metros por segundo)
                rendimientos[i] = distancias[i] / tiempos[i];
            }
            for (int i = 1; i < cantidadDeportistas; i++)
            {
                // Más rápido: menor tiempo total
                if (tiempos[i] < tiempos[indiceMasRapido])
                {
                    indiceMasRapido = i;
                }

                // Mejor rendimiento: mayor rendimiento (más metros por segundo)
                if (rendimientos[i] > rendimientos[indiceMejorRendimiento])
                {
                    indiceMejorRendimiento = i;
                }
            }

            // Resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"El deportista más rápido es {nombres[indiceMasRapido]} con un tiempo de {tiempos[indiceMasRapido]} segundos.");
            Console.WriteLine($"El deportista con mejor rendimiento es {nombres[indiceMejorRendimiento]} con un rendimiento de {rendimientos[indiceMejorRendimiento]:F2} metros por segundo.");

        }
        public void eje3()
        {
            int cempleados;

            int indicepeorpagado = 0;
            int sumasalarios = 0;

            Console.WriteLine("ingrese la cantidad de empleados");
            cempleados = int.Parse(Console.ReadLine());
            string[] nombres = new string[cempleados];
            string[] cargos = new string[cempleados];
            string[] salarios = new string[cempleados];

            for (int i = 0; i < cempleados; i++)
            {
                Console.WriteLine("ingrese el nombre del empleado");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese el cargo del empleado");
                cargos[i] = Console.ReadLine();
                Console.WriteLine("ingrese el salario del empleado");
                salarios[i] = Console.ReadLine();

            }


            int[] salariosInt = new int[cempleados];
            for (int i = 0; i < cempleados; i++)
            {
                salariosInt[i] = int.Parse(salarios[i]); 
                sumasalarios += salariosInt[i];
                if (salariosInt[i] < salariosInt[indicepeorpagado])
                {
                    indicepeorpagado = i;
                }
            }
            double salarioPromedio = sumasalarios / cempleados;

            Console.WriteLine($"el empleado peor pagado es {nombres[indicepeorpagado]} con el cargo de {cargos[indicepeorpagado]} y un salario de {salarios[indicepeorpagado]} soles");
            Console.WriteLine($"el salario promedio es {salarioPromedio}");

        }

    }
}
