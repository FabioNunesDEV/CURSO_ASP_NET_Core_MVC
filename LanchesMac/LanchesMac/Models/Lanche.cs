using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace LanchesMac.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required]
    [Display(Name ="Nome")]
    [StringLength(80, MinimumLength =20,ErrorMessage ="O {0} deve ter no minimo {1} e no máximo {2} caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage ="A descrição do lanche deve ser informada.")]
    [Display(Name = "Descrição do lanche")]
    [StringLength(200, MinimumLength = 20, ErrorMessage = "A {0} deve ter no minimo {1} e no máximo {2} caracteres.")]
    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada.")]
    [Display(Name = "Descrição detalhada do lanche")]
    [MinLength (20, ErrorMessage = "A {0} deve ter no minimo {1} caracteres.")]
    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o preço do lanche.")]
    [Display(Name = "Preço do lanche")]
    [Column(TypeName ="decimal(5,2)")]
    [Range(1,999.99)]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracters ")]
    public string ImagemUrl { get; set; }


    [Display(Name = "Caminho Imagem Miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracters ")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    // Relacionamento com Categoria
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}
