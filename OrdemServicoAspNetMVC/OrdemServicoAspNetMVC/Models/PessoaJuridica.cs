using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemServicoAspNetMVC.Models
{
    public class PessoaJuridica : Pessoa
    {
        public String NomeFantansia { get; set; }

        public String Cnpj { get; set; }
    }
}
