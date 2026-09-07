using System;
using System.Collections.Generic;
using System.Text;

namespace Cacs.Infrastructure.Persistence.MongoDB
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
