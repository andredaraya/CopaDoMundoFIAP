using System.ComponentModel;

namespace CopaDoMundo.Web.Enum
{
    public enum ePosicao 
    {
        [Description("Goleiro")]
        Goleiro = 1,
        [Description("Zagueiro Direito")]
        ZagueiroDireito = 2,
        [Description("Zagueiro Central")]
        ZagueiroCentral = 3,
        [Description("Zagueiro Esquerdo")]
        ZagueiroEsquerdo = 4,
        [Description("Líbero")]
        Libero = 5,
        [Description("Lateral Direito")]
        LateralDireito = 6,
        [Description("Lateral Esquerdo")]
        LateralEsquerdo = 7,
        [Description("Volante")]
        Volante = 8,
        [Description("Meia Central")]
        MeiaCentral = 9,
        [Description("Armador")]
        Armador = 10,
        [Description("Meia Ofensivo")]
        MeiaOfensivo = 11,
        [Description("Meia Esquerda Ofensivo")]
        MeiaEsquerdaOfensivo = 12,
        [Description("Meia Direita Ofensivo")]
        MeiaDireitaOfensivo = 13,
        [Description("Meia Esquerda")]
        MeiaEsquerda = 14,
        [Description("Meia Direita")]
        MeiaDireita = 15,
        [Description("Meio Ala Esquerdo")]
        MeioAlaEsquerdo = 16,
        [Description("Meio Ala Direito")]
        MeioAlaDireito = 17,
        [Description("Ala Direito")]
        AlaDireito = 18,
        [Description("Ala Esquerto")]
        AlaEsquerto = 19,
        [Description("Atacante Esquerdo")]
        AtacanteEsquerdo = 20,
        [Description("Atacante Direito")]
        AtacanteDireito = 21,
        [Description("Atacante")]
        Atacante = 22,
        [Description("Centro Avante")]
        CentroAvante = 23
    }
}
