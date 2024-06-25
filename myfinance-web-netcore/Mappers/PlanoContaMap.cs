using AutoMapper;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_netcore.Mappers
{
    public class PlanoContaMap : Profile
    {
        public PlanoContaMap() {
            CreateMap<PlanoConta, PlanoContaModel>().ReverseMap();
        }
    }
}