using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class Factory:Building
    {
        public Factory()
        {

            Thumb = @"C:\Users\Sven\source\repos\Saftfresse\Townships\Townships\Townships\Resources\factory_1.png";
            ThumbBackup = @"C:\Users\Greinert\source\repos\Saftfresse\Townships\Townships\Townships\Resources\factory_1.png";
        }

        public override void Update()
        {
            Console.WriteLine("lala");
        }
    }
}
