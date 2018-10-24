using System;
using System.Collections.Generic;
using System.Text;

namespace FodyPermissionsSpike
{
    public class ExampleBusinessService
    {
        [BizAuthorized]
        public void ReleaseTheHounds()
        {
            Console.WriteLine("Smithers....Release the hounds.");
        }

        public void FreeForAll()
        {
            Console.WriteLine("Anyone can call this.");
        }

        [BizAuthorized]
        public void NoPermission()
        {
            Console.WriteLine("This should not happen");
        }
    }
}
