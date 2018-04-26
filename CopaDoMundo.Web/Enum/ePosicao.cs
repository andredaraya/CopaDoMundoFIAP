using System.ComponentModel;

namespace CopaDoMundo.Web.Enum
{
    public enum ePosicao 
    {
        [Description("G")]
        Goleiro,
        [Description("ZD")]
        ZagueiroDireito,
        [Description("ZC")]
        ZagueiroCentral = 1,
        [Description("ZE")]
        ZagueiroEsquerdo = 1,
        [Description("L")]
        Líbero = 1,
        [Description("LD")]
        LateralDireito = 1,
        [Description("LE")]
        LateralEsquerdo = 1,
        [Description("V")]
        Volante = 1,
        [Description("MC")]
        MeiaCentral = 1,
        [Description("A")]
        Armador = 1,
        [Description("MO")]
        MeiaOfensivo = 1,
        [Description("MEO")]
        MeiaEsquerdaOfensivo = 1,
        [Description("MDO")]
        MeiaDireitaOfensivo = 1,
        [Description("ME")]
        MeiaEsquerda = 1,
        [Description("MD")]
        MeiaDireita = 1,
        [Description("MAE")]
        MeioAlaEsquerdo = 1,
        [Description("MAD")]
        MeioAlaDireito = 1,
        [Description("AD")]
        AlaDireito = 1,
        [Description("AE")]
        AlaEsquerto = 1,
        [Description("ATE")]
        AtacanteEsquerdo = 1,
        [Description("ATD")]
        AtacanteDireito = 1,
        [Description("AT")]
        Atacante = 1,
        [Description("CA")]
        CentroAvante = 1
    }
}
