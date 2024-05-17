using System.ComponentModel.DataAnnotations;

namespace Teste.Models;

public class Cartao
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
}