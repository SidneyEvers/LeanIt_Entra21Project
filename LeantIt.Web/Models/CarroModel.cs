namespace LeantIt.Web.Models;

public class CarroModel
{
    public Guid Id { get; set; }
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Year { get; set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public string UrlImagem { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public Categoria Categoria { get; set; }
    public bool Status { get; set; }
}
