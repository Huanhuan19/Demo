using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log4net;

namespace log4
{
    public class LogMgr
    {
        public static readonly LogMgr Instance = new LogMgr();

        private static log4net.ILog logger;

        public LogMgr()
        {
            string pathTemp = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(pathTemp, "LogConfig.txt");
            FileInfo fin = new FileInfo(filePath);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(fin);
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Info(string message)
        {
            LogMgr.logger.Info(DealLog(message));
        }

        //public void Error(string logMessage, Exception ex)
        //{

        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(logMessage);
        //    //错误信息，追加程序堆栈，用于后续分析
        //    sb.AppendLine("=== 堆栈信息：");
        //    System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
        //    System.Diagnostics.StackFrame[] sfs = st.GetFrames();
        //    for (int u = 0; u < sfs.Length && u < 10; ++u)
        //    {
        //        System.Reflection.MethodBase mb = sfs[u].GetMethod();
        //        if (mb != null && mb.DeclaringType != null)
        //        {
        //            sb.AppendLine(string.Format("[STACK][{0}]: {1}.{2}", u, mb.DeclaringType.FullName, mb.Name));
        //        }
        //    }
        //    sb.AppendLine("====");

        //    LogMgr.logger.Error(this.DealLog(sb.ToString()), ex);
        //}
        private string DealLog(String log)
        {
            return log;
        }
    }
}
