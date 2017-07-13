using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class PathGetter
    {
        public static string GetCurrentPath()
        {
            string result = Assembly.GetExecutingAssembly().Location;
            int index = result.LastIndexOf(@"\");
            if (index >= 0)
            {
                result = result.Substring(0, index);
            }
            return result;
        }
    }
}
