namespace EduNET.Domain;

public class Aula
{
    public string Nome { get; set; }
    public TipoAula TipoAula { get; set; }
    public List<Comentario> Comentarios { get; set; }
    public List<Anexo> Anexos { get; set; }
}