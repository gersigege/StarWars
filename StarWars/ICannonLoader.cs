using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public interface ICannonLoader
    {
        int GetMaxCannon(IReadOnlyCollection<int> heights);
    }
}
