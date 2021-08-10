using System;
using System.ComponentModel.DataAnnotations;

namespace OrdemServicoAspNetMVC.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public int IdTipoServico { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdColaborador { get; set; }
        public int IdDefeitoReclamado { get; set; }
        public int IdDefeitoIdentificado { get; set; }
        public int IdSolucaoAplicada { get; set; }
        [Display (Name = "Data Abertura")]
        public DateTime DataAbertura { get; set; }
        [Display (Name = "Data Fechamento")]
        public DateTime DataFechamento { get; set; }
        public char Status { get; set; }

    }
}
