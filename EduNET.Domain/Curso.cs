using System.Numerics;

namespace EduNET.Domain;

public class Curso
{
    public string Nome { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<Modulo> Modulos { get; set; }
}