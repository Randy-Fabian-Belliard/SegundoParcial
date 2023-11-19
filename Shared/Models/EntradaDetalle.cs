using System.ComponentModel.DataAnnotations;
public class EntradaDetalle
{
    [Key]
    public int DetalleId {get; set;}
    public int EntradaId {get; set;}
    public int ProductoId {get; set;}
    [Required(ErrorMessage = "Este campo es necesario")]
    public int CantidadUtilizada {get; set;}
}