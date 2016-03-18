using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDb.enums;

namespace AuroraDb
{
    internal static class AuroraConfig
    {
        internal static Dictionary<ConnectionTypes, string> ConnectionStrings = new Dictionary<ConnectionTypes, string>();
    }
}
