namespace EduNET.Domain;

public class Comentario
{
    public Guid ComentarioId { get; set; }
    public Guid? ComentarioPaiId { get; set; }
    public Guid AutorId { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<Comentario> Respostas { get; set; }
}