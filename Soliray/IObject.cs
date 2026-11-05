using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliray
{
    interface ISetrifact
    {
        int price { get; }
        int mounts { get; }
        byte sale { get; }

        DateTime time { get; protected set; }
        DateTime datepay { get; protected set; }

        void Impruve()
        {
            Console.WriteLine("Улучшение абонимента ::");
        }
    }
    

}
