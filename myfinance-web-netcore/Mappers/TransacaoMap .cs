using AutoMapper;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_netcore.Mappers
{
    public class TransacaoMap : Profile
    {
        public TransacaoMap() {
            CreateMap<Transacao, TransacaoModel>()
            .ForMember(dest => dest.ItemPlanoConta  , opt => opt.MapFrom(src => src.PlanoConta))
            .ReverseMap();
        }
    }
}