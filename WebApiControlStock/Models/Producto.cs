using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using WebApiControlStock.Validaciones;

namespace WebApiControlStock.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(1)")]

        [LineaProductoAttribute]
        public string LineaProducto { get; set; }
        [PrecioAttribute]
   
        public decimal Money { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set;}


    }
}
