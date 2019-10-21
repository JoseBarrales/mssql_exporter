using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prometheus.Exporters.MSSQL.Abstractions
{
    public interface IConfig
    {
        int ServerPort { get; set; }
        bool AddExporterMetrics { get; set; }
        string DataSource { get; set; }
        string ConfigFile { get; set; }
        string ServerPath { get; set; }
        string ConfigUrl { get; set; }
        string Instance { get; set; }
        string[] Instances { get; set; }
        string[] ConnectionString { get; set; }
    }
}
