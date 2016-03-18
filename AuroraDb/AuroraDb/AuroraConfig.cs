using System.Collections.Generic;
using AuroraDb.enums;

namespace AuroraDb
{
    internal static class AuroraConfig
    {
        internal static Dictionary<ConnectionTypes, string> ConnectionStrings = new Dictionary<ConnectionTypes, string>();
    }
}
