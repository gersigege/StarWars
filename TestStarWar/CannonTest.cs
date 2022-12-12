using StarWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestStarWar
{
    public class CannonTest
    {
        [Fact]
        public void NullList()
        {
            ICannonLoader cannon = new CannonLoader();
            List<int> ints = null;

            Assert.Throws<ArgumentNullException>(()=> cannon.GetMaxCannon(ints));
        }
        [Fact]
        public void OneElementList()
        {
            ICannonLoader cannon = new CannonLoader();
            List<int> ints = new List<int> { 1};

            Assert.Equal(1, cannon.GetMaxCannon(ints));
        }
        [Fact]
        public void ProblemElementList()
        {
            ICannonLoader cannon = new CannonLoader();
            var heights = new List<int> { 1, 6, 4, 5, 4, 5, 1, 2, 3, 4, 7, 2 };

            Assert.Equal(3, cannon.GetMaxCannon(heights));
        }
        [Fact]
        public void NoHeightsElementList()
        {
            ICannonLoader cannon = new CannonLoader();
            var heights = new List<int> { 1, 1, 1, 1 };

            Assert.Equal(0, cannon.GetMaxCannon(heights));
        }
        [Fact]
        public void TwoElementList()
        {
            ICannonLoader cannon = new CannonLoader();
            var heights = new List<int> { 2, 1 };

            Assert.Equal(1, cannon.GetMaxCannon(heights));
        }
    }
}
