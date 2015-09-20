using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTime_Stories
{
    public class Globalvars
    {
        public static string _Items;

        public string value()
        {
            StoryList str = new StoryList();

            _Items = str.curItem;


            return _Items;
        }
    }
}
