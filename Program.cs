using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Progra2_JoseChan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de empleados y salario
            String[] empleado = new[] { "Jose", "Diana", "Sofia", "Luis", "Felix" };
            int[] salario = new[] { 4000, 2000, 900, 800, 500 };
            var empSal = empleado.Zip(salario, (e, s) => new { empleado = e , salario = s });

            //Métodos
            foreach (var es in empSal)
            {
                Console.WriteLine("Nombre del empleado " + es.empleado + " - Salario de " + es.empleado + " " + es.salario + " - Aguinaldo de " + es.empleado + " " + es.salario*12);
            }
        }
    }
}
