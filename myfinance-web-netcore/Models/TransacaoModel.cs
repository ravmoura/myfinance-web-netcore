using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Models
{
    public class TransacaoModel
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "* Histórico da Transação é obrigatório!")]
	    public String Historico { get; set; }

        [Required(ErrorMessage = "* Data da Transação é obrigatória!")]
	    public DateTime Data { get; set; }

        [Required(ErrorMessage = "* Valor da Transação é obrigatório!")]
        [Range(0.01,999999.99, ErrorMessage="* Valor deve ser maior que zero!")]
	    public decimal Valor { get; set; }

        [Required(ErrorMessage = "* Plano Conta é obrigatório!")]
        public int PlanoContaId {get; set;} 
	    
        public PlanoContaModel? ItemPlanoConta { get; set; }

        public IEnumerable<SelectListItem>? PlanoContas {get; set; }
    }
}