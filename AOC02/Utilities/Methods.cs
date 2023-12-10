using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC02.Utilities;

public static class Methods
{
    public static List<int> GetValuesWithOffsettFromList(this List<string> data, string identifier, int indexOffset)
    {
        var occurances = new List<int>();

        while (true)
        {
            var index = data.IndexOf(identifier);

            if (index != -1)
            {
                var values = int.Parse(data[index + indexOffset]);
                occurances.Add(values);

                var startIndex = index + indexOffset;
                var amountToRemove = 2;

                if (indexOffset > 0)
                {
                    startIndex = index;
                    amountToRemove = indexOffset;
                }

                data.RemoveRange(startIndex, amountToRemove);

                continue;
            }
            break;
        }

        return occurances;
    }
}
