using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeManager.Controllers
{
    class Anim
    {
        public static void testc( int first, int second)
        {
            
            Task.Run(() =>
            {
                for (int i = 0; i < second; i++)
                {
                    first += 1;
                    Thread.Sleep(1);
                }
            });
        }
    }
}
