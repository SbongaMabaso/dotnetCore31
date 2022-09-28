using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnetCore31.Dtos.Character;
using dotnetCore31.Models;

namespace dotnetCore31
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>(); 
            CreateMap<AddCharacterDto, Character>();
        }
    }
}