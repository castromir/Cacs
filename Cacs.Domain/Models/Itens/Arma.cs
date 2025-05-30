using System;

namespace Cacs.Models.Itens
{
    public enum enumProficienciaArma
    {
        eProficienciaArmaSimples,
        eProficienciaArmaTatica,
        eProficienciaArmaPesada
    }

    public enum enumTipoArma
    {
        eTipoArmaCorpo,
        eTipoArmaArremesso,
        eTipoArmaDisparo,
        eTipoArmaFogo
    }

    public enum enumTipoDanoArma
    {
        eTipoDanoArmaBalistico,
        eTipoDanoArmaConhecimento,
        eTipoDanoArmaCorte,
        eTipoDanoArmaEletricidade,
        eTipoDanoArmaEnergia,
        eTipoDanoArmaFogo,
        eTipoDanoArmaFrio,
        eTipoDanoArmaImpacto,
        eTipoDanoArmaMental,
        eTipoDanoArmaMedo,
        eTipoDanoArmaMorte,
        eTipoDanoArmaPerfuracao,
        eTipoDanoArmaSangue,
        eTipoDanoArmaQuimico
    }

    [Flags]
    public enum PropriedadesArma
    {
        Nenhuma = 0,
        Agil = 1 << 0,
        Automatica = 1 << 1,
        Coronha = 1 << 2,
        DuasMaos = 1 << 3,
        Leve = 1 << 4,
        UmaMao = 1 << 5,
        Versatil = 1 << 6,
    }
    public class Arma : Item
    {
        public enumProficienciaArma Proficiencia { get; set; }
        public enumTipoArma Tipo { get; set; }
        public enumTipoDanoArma TipoDano { get; set; }

        Pericia pericia;
        //Dano
        //Dano secundario
        //Critico
        //Multiplicador
        //Alcance
        public Arma()
        {

        }
    }
}
