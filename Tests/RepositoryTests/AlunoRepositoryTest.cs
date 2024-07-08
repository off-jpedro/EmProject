using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repository;
using Xunit;

namespace RepositoryTests
{
    public class AlunoRepositoryTest
    {
        public AlunoRepository repository = new AlunoRepository();

        [Fact]
        public void WhenGetAll_ReturnsAllAlunos()
        {
            //Arrange
            //Act
            //Assert

            Assert.True(true);
        }
    }
}