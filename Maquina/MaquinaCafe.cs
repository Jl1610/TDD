using System;

public class MaquinaCafe
{
    private int vasosDisponibles;
    private int cafeDisponible;
    private Azucarero azucarero;

    public MaquinaCafe(int vasosDisponibles = 10, int cafeDisponible = 100, int azucarDisponible = 50)
    {
        this.vasosDisponibles = vasosDisponibles;
        this.cafeDisponible = cafeDisponible;
        this.azucarero = new Azucarero(azucarDisponible);
    }

    public int SeleccionarVaso(string tamaño)
    {
        if (vasosDisponibles <= 0) throw new InvalidOperationException("No hay vasos disponibles");

        int tamañoVaso;

       
        if (tamaño == "pequeño")
        {
            tamañoVaso = 3;
        }
        else if (tamaño == "mediano")
        {
            tamañoVaso = 5;
        }
        else if (tamaño == "grande")
        {
            tamañoVaso = 7;
        }
        else
        {
            throw new ArgumentException("Tamaño no válido");
        }

        if (cafeDisponible < tamañoVaso) throw new InvalidOperationException("No hay suficiente café disponible");

        vasosDisponibles--;
        cafeDisponible -= tamañoVaso;
        return tamañoVaso;
    }

    public void AgregarAzucar(int cantidad)
    {
        azucarero.SeleccionarAzucar(cantidad);
    }

    public string VerificarStock()
    {
        if (vasosDisponibles <= 0) return "No hay vasos disponibles";
        if (cafeDisponible <= 0) return "No hay café disponible";
        if (!azucarero.HayAzucar()) return "No hay azúcar disponible";
        return "Stock suficiente";
    }
}