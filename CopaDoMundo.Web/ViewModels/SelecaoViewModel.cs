using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CopaDoMundo.Web.ViewModels
{
    public class SelecaoViewModel
    {
        public SelecaoViewModel()
        {
            this.Jogadores = new List<JogadorViewModel>();
        }

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }

        public int QuantidadeTitulos { get; set; }

        public virtual IList<JogadorViewModel> Jogadores { get; set; }
    }
}
