using System;
using System.Collections.Generic;
namespace Model.GestaoAssociados
{
    public class MD_Assossiado
    {

        public int idAssociado { get; set; }
        public string NomeCompleto { get; set; }
        public virtual MD_TipoTelefone Telefone { get; set; }
        public virtual MD_TipoUsuario TipoUsuario { get; set; }
        public string Foto { get; set; }
        public string email{get;set;}
        public string EnderecoFb { get; set; }
        public virtual List<Md_Endereco> Enderecos {get; set;}
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string telefone { get; set; }
        public DateTime DataEntradaCrias { get; set; }
        public int IdPosicao { get; set; }
        public int IdObrigacao { get; set; }
        public string Orunko { get; set; }
        public string OrunkoTraducao { get; set; }
        public DateTime DataOjoOrunko { get; set; }
        public string OrisaEleda { get; set; }
        public string OrisaJunto { get; set; }
        public virtual Md_Orixa _OrisaEleda { get; set; }
        public virtual Md_Orixa _OrisaJunto { get; set; }
        public virtual Md_Formacao Formacao { get; set; }
        public virtual Md_AreaAtuacao AreaAtuacao { get; set; }
		public virtual Md_ValorContribuicao ContribuicaoMensal { get; set; }
		public DateTime DataProximaObrigacao { get; set; }
		public string ComoConheceu { get; set; }
        public virtual Md_MotivoProcura MotivoProcura { get; set; }
    }
}
