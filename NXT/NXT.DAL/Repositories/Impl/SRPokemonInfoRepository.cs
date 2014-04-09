using NXT.Core.Pokemon;
using NXT.DAL.Entities;
using SharpRepository.Repository;
namespace NXT.DAL.Repositories.Impl
{
    /// <summary>
    /// A PokemonInfoRepository implementation that uses SharpRepository.
    /// </summary>
    /// <remarks>
    /// Do not expose this outside of the assembly. And note that this should be
    /// an immutable repository (i.e, you cannot write to it).
    /// </remarks>
    internal class SRPokemonInfoRepository : IPokemonInfoRepository
    {
        private readonly IRepository<Pokemon> _base;
        private readonly IEntityConverter _converter;

        public SRPokemonInfoRepository(IRepository<Pokemon> pokemonRepository, 
            IEntityConverter converter)
        {
            _base = pokemonRepository;
            _converter = converter;
        }

        public PokemonInfo FromId(int id)
        {
            var entity = _base.Get(id);
            var dto = _converter.Convert<Pokemon, PokemonInfo>(entity);
            return dto;
        }
    }
}
