using System;
namespace Model.GestaoAssociados
{
    public class Md_Endereco
    {
        public int IdEndereco { get; set; }
        public virtual MD_TipoEndereco _TipoEndereco { get; set; }
        public string IdentificacaoLougradouro { get; set; }
        public string Lougradouro { get; set; }
        public string NumeroLougradouro { get; set; }
        public string ComplementoLougradouro { get; set; }
        public bool status { get; set; }
        public string cep { get; set; }

    }
}
