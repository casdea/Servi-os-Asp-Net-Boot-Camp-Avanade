using System;

namespace OrdemServicoAspNetMVC.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int idTipoServico { get; set; }
        public int idTipoContrato { get; set; }
        public int idColaborador { get; set; }
        public int idDefeitoReclamado { get; set; }
        public int idDefeitoIdentificado { get; set; }
        public int idSolucaoAplicada { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public char status { get; set; }

    }
}
