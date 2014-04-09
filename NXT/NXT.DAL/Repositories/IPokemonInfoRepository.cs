using NXT.Core.Pokemon;
namespace NXT.DAL.Repositories
{
    /// <summary>
    /// A repository that provides PokemonInfo objects.
    /// </summary>
    public interface IPokemonInfoRepository
    {
        /// <summary>
        /// Returns a PokemonInfo instance by the given ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PokemonInfo FromId(int id);
    }
}
