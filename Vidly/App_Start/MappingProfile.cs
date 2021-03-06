﻿using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<MovieImage, MovieImageDto>();
            Mapper.CreateMap<AdminNews, AdminNewsDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieImageDto, MovieImage>()
                .ForMember(i => i.Id, opt => opt.Ignore());
            Mapper.CreateMap<AdminNewsDto, AdminNews>()
                .ForMember(a => a.Id, opt => opt.Ignore());
        }
    }
}