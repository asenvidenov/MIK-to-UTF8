using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    internal class ACT
    {
        internal ACT(ref List<IDataMap> mapper)
        {
            mapper = new()
        {
                new DataMap(8, 'S'),
                new DataMap(30, 'S'),
                new DataMap(3, 'S'),
                new DataMap(3, 'S'),
                new DataMap(8, 'S'),
                new DataMap(4, 'S'),
                new DataMap(4, 'S'),
                new DataMap(30, 'S'),
                new DataMap(30, 'S'),
                new DataMap(15, 'S'),
                new DataMap(15, 'S'),
                new DataMap(5, 'S'),
                new DataMap(12, 'S'),
                new DataMap(15, 'S'),
                //new DataMap(3, 'N'),
                new DataMap(3, 'S'),
                //new DataMap(3, 'N'),
                new DataMap(3, 'S'),
                //new DataMap(8, 'N'),
                new DataMap(8, 'S'),
                //new DataMap(8, 'N'),
                new DataMap(8, 'S'),
                //new DataMap(8, 'M'),
                new DataMap(8, 'S'),
                //new DataMap(8, 'N'),
                new DataMap(8, 'S'),
                new DataMap(15, 'S'),
                new DataMap(15, 'S'),
                new DataMap(30, 'S'),
                new DataMap(8, 'S'),
                new DataMap(7, 'S'),
                new DataMap(2, 'S'),
                //new DataMap(10, 'L'),
                new DataMap(10, 'S'),
                //new DataMap(15, 'L'),
                new DataMap(15, 'S'),
                //new DataMap(2, 'D'),
                new DataMap(2, 'S'),
                //new DataMap(2, 'D'),
                new DataMap(2, 'S'),
                new DataMap(92, 'S')

        };
        }
    }
}
