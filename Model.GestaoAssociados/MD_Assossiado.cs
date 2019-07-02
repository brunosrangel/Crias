using System;
using System.Collections.Generic;
namespace Model.GestaoAssociados
{
    public class MD_Assossiado
    {

        public int idAssociado { get; set; }
        public string Nome { get; set; }
        public string email
        {
            get;
            set;
        }
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
		public int idOrisaEleda { get; set; }
		public int idOrisaJunto { get; set; }
		public int idFormacao { get; set; }
        public int idAreaAtuacao { get; set; }
		public int idContribuicaoMensal { get; set; }
		public DateTime DataProximaObrigacao { get; set; }
		public string ComoConheceu { get; set; }
        public int IdMotivoProcura { get; set; }
    }
}
