using Prometheus.Exporters.MSSQL.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prometheus.Exporters.MSSQL.Options
{
    public class ConfigOptions : IConfig
    {
        public string DataSource { get; set; } 

        public string ConfigFile { get; set; } 

        public string ServerPath { get; set; } = "metrics";

        public int ServerPort { get; set; } = 80;

        public string Instance { get; set; }

        public string[] ConnectionString { get; set; }

        public string[] Instances { get; set; }

        public string ConfigUrl { get; set; } 

        public bool AddExporterMetrics { get; set; } = false;
    }
}
