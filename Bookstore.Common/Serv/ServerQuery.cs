using System;
using Bookstore.Common.Enums;

namespace Bookstore.Common.Serv
{
    [Serializable]
    public class ServerQuery
    {
            public QueryType Type { get; set; }

            public string TypeAction { get; set; }

            public string Object { get; set; }
    }
}

