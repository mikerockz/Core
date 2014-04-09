using AutoMapper;
using System.Linq;
using NXT.Core.Pokemon;
using NXT.DAL.Entities;
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
                    .ForMember(p => p.Id, x => x.MapFrom(i => i.Id))
                    .ForMember(p => p.Height, x => x.MapFrom(i => i.Height))
                    .ForMember(p => p.Weight, x => x.MapFrom(i => i.Weight))
                    .ForMember(p => p.Name, x => x.MapFrom(i => i.Species.Names.First(n => n.LanguageId == 9)))
                    .ForMember(p => p.IsDefault, x => x.MapFrom(i => i.IsDefault))
                    .ForMember(p => p.Order, x => x.MapFrom(i => i.Species.Order))
                    .ForMember(p => p.BaseExperience, x => x.MapFrom(i => i.BaseExperience));
            });

            _engine = Mapper.Engine;
        }

        public TOut Convert<TIn, TOut>(TIn input)
        {
            return _engine.Map<TIn, TOut>(input);
        }
    }
}
