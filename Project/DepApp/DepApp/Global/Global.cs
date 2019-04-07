using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Global
{
    public static Logger GLogger = NLog.LogManager.GetCurrentClassLogger();
}

