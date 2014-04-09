using AutoMapper;
using NXT.Core.Pokemon;
using NXT.DAL.Entities;
using System.Linq;

namespace NXT.DAL
{
    /// <summary>
    /// A helper class that registers the mapping between database entities and their
    /// data transfer objects (DTO) for AutoMapper.
    /// </summary>
    public static class EntityMapping
    {
        public static void Initialize()
        {
            Mapper.Initialize(m =>
            {
                // Pokemon -> PokemonInfo
                m.CreateMap<Pokemon, PokemonInfo>()
                    .ForMember(p => p.Id, x => x.MapFrom(i => i.Id))
                    .ForMember(p => p.Height, x => x.MapFrom(i => i.Height))
                    .ForMember(p => p.Weight, x => x.MapFrom(i => i.Weight))
                    .ForMember(p => p.Name, x => x.MapFrom(i => i.Species.Names.First(n => n.LanguageId == 9)))
                    .ForMember(p => p.IsDefault, x => x.MapFrom(i => i.IsDefault))
                    .ForMember(p => p.Order, x => x.MapFrom(i => i.Species.Order))
                    .ForMember(p => p.BaseExperience, x => x.MapFrom(i => i.BaseExperience));
            });
        }
    }
}
