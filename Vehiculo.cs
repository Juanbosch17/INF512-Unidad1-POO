using System;

public class Vehiculo 
{
    // Atributos (Propiedades)
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Método coherente con POO
    public void Encender() 
    {
        Console.WriteLine("El vehículo ha encendido correctamente.");
    }
    public void MostrarInformacion()
    {
        Console.Writeline($"Marca: {Marca}, Modelo: {Modelo}");
}
