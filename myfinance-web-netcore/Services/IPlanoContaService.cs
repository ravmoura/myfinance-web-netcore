using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Services
{
    public interface IPlanoContaService
    {
        List<PlanoContaModel> Listar();
        void Salvar(PlanoContaModel model);
        void Excluir(int id);
        PlanoContaModel Consultar(int id);
    }
}