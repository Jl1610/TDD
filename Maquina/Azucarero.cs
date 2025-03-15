using System;

public class Azucarero
{
    private int azucarDisponible;

    public Azucarero(int azucarDisponible = 50)
    {
        this.azucarDisponible = azucarDisponible;
    }

    public int SeleccionarAzucar(int cantidad)
    {
        if (cantidad > azucarDisponible) throw new InvalidOperationException("No hay suficiente azúcar disponible");
        azucarDisponible -= cantidad;
        return cantidad;
    }

    public bool HayAzucar()
    {
        return azucarDisponible > 0;
    }
}
