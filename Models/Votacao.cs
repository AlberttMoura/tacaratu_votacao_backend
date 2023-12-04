using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TacaratuBackend.Models
{
  [Table("votacao")]
  public class Votacao
  {
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_app_id")]
    public int AppId { get; set; }
  }
}