namespace ClinicaSalud.Models;

public class Pacientes
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int Edad { get; set; }
    
    public string Sintoma { get; set; }

    public Pacientes(int id, string name, int edad, string sintoma)
    {
        Id = id;
        Name = name;
        Edad = edad;
        Sintoma = sintoma;
    }
}