using CopaDoMundo.Web.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CopaDoMundo.Web.ViewModels
{
    public class JogadorViewModel
    {
        public JogadorViewModel()
        {
            this.Selecoes = new List<SelecaoViewModel>();
        }

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        public string Apelido { get; set; }

        [Required(ErrorMessage = "Idade é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Posição é obrigatória")]
        [Display(Name = "Posição")]
        public ePosicao Posicao { get; set; }

        [Display(Name = "Seleção")]
        public int Selecao { get; set; }

        public List<SelecaoViewModel> Selecoes { get; set; }
    }
}
