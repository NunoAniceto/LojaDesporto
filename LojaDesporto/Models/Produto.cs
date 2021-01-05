using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDesporto.Models
{
    public class Produto
    {
        
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="Deve preencher o nome")]
        [StringLength(200,MinimumLength =4, ErrorMessage ="O nome deve ter pelo menos 4 carateres e nao deve exceder os 200 carateres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Deve preencher o preço")]
        public decimal Preco { get; set; }
    }
}
