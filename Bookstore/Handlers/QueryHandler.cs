using System;
using System.Text.Json;
using Bookstore.Common.Enums;
using Bookstore.Common.Serv;

namespace Bookstore.Handlers
{
    public static class QueryHandler<T>
    {
        public static string Serialize(T obj, QueryType type, string someTypeAction)
        {
            ServerQuery query = new ServerQuery
            {
                Type = type,
                TypeAction = someTypeAction,
                Object = JsonSerializer.Serialize<T>(obj)
            };
            var json = JsonSerializer.Serialize<ServerQuery>(query);
            return json;
        }
        
        public static string QueryTypeSerialize(T someType)
        {
            return JsonSerializer.Serialize<T>(someType);
        }
    }
}

