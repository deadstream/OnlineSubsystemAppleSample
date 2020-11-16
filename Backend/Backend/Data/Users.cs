using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Users
    {
        public class Body
        {
            public string code { get; set; } = string.Empty;
            public string id_token { get; set; } = string.Empty;
            public string state { get; set; } = string.Empty;
            public string user { get; set; } = string.Empty;
            public string error { get; set; } = string.Empty;
        }

        public ConcurrentDictionary<string, (Body, DateTime)> Tokens = new ConcurrentDictionary<string, (Body, DateTime)>();
    }
}
