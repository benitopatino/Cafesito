using System;

namespace Cafesito.Models
{
    public class Env
    {
        public string DbUrl { get; set; }
        public string DbUser { get; set; }
        public string DbPass { get; set; }
        
        public Env()
        {
            DbUrl = Environment.ExpandEnvironmentVariables("%DB_URL%");
            DbUser = Environment.ExpandEnvironmentVariables("%DB_USER%");
            DbPass = Environment.ExpandEnvironmentVariables("%DB_PASS%");
        }
    }
}
