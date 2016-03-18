using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDb.enums;

namespace AuroraDb
{
    public static class AuroraConfig
    {
        public static Dictionary<ConnectionTypes, string> ConnectionStrings = new Dictionary<ConnectionTypes, string>();
    }
}
