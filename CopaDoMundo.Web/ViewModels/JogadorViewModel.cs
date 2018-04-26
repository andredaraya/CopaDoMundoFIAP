using CopaDoMundo.Web.Enum;
using System.ComponentModel.DataAnnotations;

namespace CopaDoMundo.Web.ViewModels
{
    public class JogadorViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        public string Apelido { get; set; }

        [Required(ErrorMessage ="Idade é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Posição é obrigatória")]
        public ePosicao Posicao { get; set; }

        public SelecaoViewModel Selecao { get; set; }
    }
}
