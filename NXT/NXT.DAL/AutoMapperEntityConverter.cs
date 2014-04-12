using AutoMapper;
using System.Linq;
using NXT.Core.Pokemon;
using NXT.DAL.Entities.Pokemons;
namespace NXT.DAL
{
    /// <summary>
    /// An entity converter that uses auto mapper.
    /// </summary>
    internal class AutoMapperEntityConverter : IEntityConverter
    {
        private readonly IMappingEngine _engine;

        public AutoMapperEntityConverter()
        {
            // TODO: Avoid the static methods if at all possible
            // Create mappings here
            Mapper.Initialize(m =>
            { 
                // Pokemon -> PokemonInfo
                m.CreateMap<Pokemon, PokemonInfo>()
                    // Pokemon
                    .ForMember(p => p.Id, x => x.MapFrom(i => i.Id))
                    .ForMember(p => p.Height, x => x.MapFrom(i => i.Height))
                    .ForMember(p => p.Weight, x => x.MapFrom(i => i.Weight))
                    .ForMember(p => p.IsDefault, x => x.MapFrom(i => i.IsDefault))
                    .ForMember(p => p.Order, x => x.MapFrom(i => i.Order))
                    .ForMember(p => p.BaseExperience, x => x.MapFrom(i => i.BaseExperience))
                    .ForMember(p => p.Abilities, x => x.MapFrom(i => i.Abilities))
                    .ForMember(p => p.Moves, x => x.MapFrom(i => i.Moves))
                    .ForMember(p => p.Types, x => x.MapFrom(i => i.Types))

                    // Species
                    .ForMember(p => p.Name, x => x.MapFrom(i => i.Species.Names.First(n => n.LanguageId == 9)))
                    .ForMember(p => p.Habitat, x => x.MapFrom(i => i.Species.Habitat))
                    .ForMember(p => p.DefaultForm, x => x.MapFrom( i => i.Forms.First(y => y.IsDefault)))
                    .ForMember(p => p.ExtraForms, x => x.MapFrom(i => i.Forms.Where(y => !y.IsDefault)))
                    ;
            });

            _engine = Mapper.Engine;
        }

        public TOut Convert<TIn, TOut>(TIn input)
        {
            return _engine.Map<TIn, TOut>(input);
        }
    }
}
