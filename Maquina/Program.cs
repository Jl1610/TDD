using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var maquina = new MaquinaCafe();
        Console.WriteLine("Bienvenido a la Máquina de Café");

        while (true)
        {
            Console.WriteLine("\nSeleccione el tamaño del vaso (pequeño, mediano, grande) o 'salir' para terminar:");
            string tamaño = Console.ReadLine().ToLower();
            if (tamaño == "salir") break;

            try
            {
                int cantidadCafe = maquina.SeleccionarVaso(tamaño);
                Console.WriteLine("Preparando café...");
                Thread.Sleep(2000);
                Console.WriteLine($"Se ha seleccionado un vaso de {cantidadCafe} oz de café.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            Console.WriteLine("\n¿Cuánta azúcar desea agregar? (0-5)");
            int cantidadAzucar;
            while (!int.TryParse(Console.ReadLine(), out cantidadAzucar) || cantidadAzucar < 0 || cantidadAzucar > 5)
            {
                Console.WriteLine("Ingrese un valor válido (0-5):");
            }

            try
            {
 
                Console.WriteLine("Agregando azúcar...");
                Thread.Sleep(1500); 
                maquina.AgregarAzucar(cantidadAzucar);
                Console.WriteLine($"Se ha agregado {cantidadAzucar} cucharadas de azúcar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Estado del stock: " + maquina.VerificarStock());
        }
    }
}
