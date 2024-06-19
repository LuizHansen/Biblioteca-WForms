using System;
using System.ComponentModel;
using System.Reflection;

namespace Biblioteca
{
    public enum EnumExemplarGeneroTipo
    {
        [Description("Romance")]
        Romance = 1,
        [Description("Novela")]
        Novela = 2,
        [Description("Conto")]
        Conto = 3,
        [Description("Cronica")]
        Cronica = 4,
        [Description("Poema")]
        Poema = 5,
        [Description("Cancao")]
        Cancao = 6,
        [Description("Drama historico")]
        DramaHistorico = 7,
        [Description("Teatro de vanguarda")]
        TeatroVanguarda = 8,
        [Description("Misterio")]
        Misterio = 9,
        [Description("Esportes")]
        Esportes = 10,
    }

    public enum EnumExemplarTipoCapa
    {
        [Description("Capa Dura")]
        CapaDura = 1,
        [Description("Capa Flexível ou Brochura")]
        CapaFlexivelBrochura = 2,
        [Description("Capa de Papel Cartão")]
        CapaPapelCartao = 3,
        [Description("Capa com Sobrecapa (Jacket)")]
        CapaSobrecapa = 4,
        [Description("Capa com Relevo")]
        CapaRelevo = 5,
        [Description("Capa com Verniz UV")]
        CapaVernizUV = 6,
        [Description("Capa Metalizada")]
        CapaMetalizada = 7,
        [Description("Capa de Tecido")]
        CapaTecido = 8,
        [Description("Capa com Janela")]
        CapaJanela = 9,
        [Description("Capa Transparente")]
        CapaTransparente = 10,
        [Description("Capa Digital")]
        CapaDigital = 11,
    }

    public enum EnumEbookFormato
    {
        [Description("PDF")]
        PDF = 1,
        [Description("EPUB")]
        EPUB = 2,
        [Description("MOBI")]
        MOBI = 3,
        [Description("AZW")]
        AZW = 4,
        [Description("Outro")]
        Outro = 5,
    }

    public enum EnumExemplarStatus
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Lido")]
        Lido = 2,
        [Description("Emprestado")]
        Emprestado = 3,
        [Description("Devolvido")]
        Devolvido = 4,
        [Description("Perdido")]
        Perdido = 5,
    }

    public enum EnumGenericoTipo
    {
        [Description("Jornais")]
        Jornais = 1,
        [Description("Calendários e Agendas")]
        CalendariosAgendas = 2,
        [Description("Mapas e Atlas")]
        MapasAtlas = 3,
        [Description("Postais e Cartões de Saudação")]
        PostaisCartoesSaudacao = 4,
        [Description("Papéis de Presente e Material de Embalagem")]
        PapeisPresenteMaterialEmbalagem = 5,
        [Description("DVDs e Blu-rays")]
        DVDsBlurays = 6,
        [Description("CDs e Vinis")]
        CDsVinis = 7,
        [Description("K7")]
        K7 = 8,
        [Description("Jogos de Tabuleiro e Quebra-Cabeças")]
        JogosTabuleiroQuebraCabecas = 9,
        [Description("Material de Papelaria e Escritório")]
        MaterialPapelariaEscritorio = 10,
        [Description("Produtos Relacionados à Cultura Pop")]
        ProdutosRelacionadosCulturaPop = 11,
        [Description("Audiolivros")]
        Audiolivros = 12,
        [Description("Outros")]
        Outros = 13,
    }
    public enum EnumFuncionarioCargo
    {
        [Description("Gerente")]
        Gerente = 1,
        [Description("Atendente")]
        Atendente = 2,
        [Description("Caixa")]
        Caixa = 3,
        [Description("Estagiário")]
        Estagiário = 4,
    }

    public enum EnumTipoLeitor
    {
        [Description("Leitor Casual")]
        LeitorCasual = 1,
        [Description("Leitor Avido")]
        LeitorAvido = 2,
        [Description("Leitor de Ficção")]
        LeitordeFicção = 3,
        [Description("Leitor Critico")]
        LeitorCritico = 4,
        [Description("Leitor de Classicos")]
        LeitordeClassicos = 5,
        [Description("Leitor Academico")]
        LeitorAcademico = 6
    }
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
