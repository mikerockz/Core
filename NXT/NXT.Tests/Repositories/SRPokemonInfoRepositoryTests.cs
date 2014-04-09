using Xunit;
using NXT.DAL.Repositories.Impl;
using SharpRepository.Repository;
using NXT.DAL.Entities;
using NXT.DAL;
using Moq;
using NXT.Core.Pokemon;

namespace NXT.Tests.Repositories
{
    /// <summary>
    /// Tests for the SRPokemonInfoRepository.
    /// </summary>
    /// <remarks>
    /// We can test this because the DAL library is friends with this library
    /// </remarks>
    public class SRPokemonInfoRepositoryTests
    {
        [Fact]
        public void FromId_ValidId_ReturnPokemonInfo()
        {
            // Arrange
            var mockRepository = new Mock<IRepository<Pokemon>>();
            var mockConverter = new Mock<IEntityConverter>();
            var expectedEntity = new Pokemon
            {
                Id = 5
            };
            mockRepository.Setup(x => x.Get(5)).Returns(expectedEntity);
            var expectedInfo = new PokemonInfo
            {
                Id = 5
            };
            mockConverter.Setup(x => x.Convert<Pokemon, PokemonInfo>(expectedEntity)).Returns(expectedInfo);
            var repo = new SRPokemonInfoRepository(mockRepository.Object, mockConverter.Object);
            // Act
            var info = repo.FromId(5);
            // Assert
            Assert.Same(expectedInfo, info);
        }
    }
}
