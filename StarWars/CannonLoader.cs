using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StarWars
{
    public class CannonLoader : ICannonLoader
    {
        public int GetMaxCannon(IReadOnlyCollection<int> heights)
        {
            if (heights is null)
            {
                throw new ArgumentNullException(nameof(heights));
            }
            if (heights.Count <= 1)
            {
                return 1;
            }
            var Indexes = GetIndex(heights);

            if (Indexes.Count == 0)
            {
                return 0;
            }else if(Indexes.Count== 1)
            {
                return 1;
            }
            var optimalNumber=Math.Floor( Math.Sqrt(heights.Count));
            var maxNumber = NrOfCannon(Indexes,(int)optimalNumber);
            return maxNumber;
        }

        private List<int> GetIndex(IReadOnlyCollection<int> heights)
        {
            List<int> indexes = new List<int>();
            for(int i = 0; i < heights.Count-1;i++)
            {
                if ((heights.ElementAt(i+1) - heights.ElementAt(i)) < 0)
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }




        private int NrOfCannon(List<int> possib, int optimalNr)
        {
           int cannonCount = 1;
            int lastPossition = possib[0];
            for(int i= 1; i < possib.Count;i++)
            {
                if(possib[i]- lastPossition>= optimalNr)
                {
                    cannonCount++;
                    lastPossition= possib[i];
                }
            }
            if (cannonCount >= optimalNr )
            {
                return optimalNr;
            }
            else
            {
                var nrOfCannons1 = NrOfCannon(possib, optimalNr - 1);
                return nrOfCannons1;
            }
        }

    }
}
