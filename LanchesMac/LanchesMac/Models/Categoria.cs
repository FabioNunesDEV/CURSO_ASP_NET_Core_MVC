using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100,ErrorMessage="Tamanho máximo é de 100 caracteres.")]
    [Required(ErrorMessage ="Informe o nome da categoria.")]
    [Display(Name ="Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage = "Tamanho máximo é de 200 caracteres.")]
    [Required(ErrorMessage = "Informe a descrição da categoria.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    // Relacionamento com entidade Lanche
    public List<Lanche> Lanches { get; set; }
}
