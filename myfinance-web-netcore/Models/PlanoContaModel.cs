using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Models
{
    public class PlanoContaModel
    {   
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage="* Descrição do item de Plano de Conta é obrigatória!")]
	    public String Descricao { get; set; }

        [Required(ErrorMessage="* Tipo do item de Plano de Conta é obrigatório!")]
	    public String Tipo { get; set; }
    }
}