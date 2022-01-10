using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OperateXML
{
    public class XMLOperate
    {
        XMLFileDAL dal = new XMLFileDAL();
        public T GetSystemConfig<T>(string path,string fileName)
        {
            T sysConf = (T)this.GetConfig(path, fileName, typeof(T));

            return sysConf;
        }
        public object GetConfig(string path, string fileName, Type fileType)
        {
            if (path == null || path == string.Empty)
            {
                return null;
            }
            return this.dal.DeSerialize(path, fileName, fileType);
        }
        public bool SaveSystemConfig<T>(T config,string fullPath)
        {
            try
            {
                this.dal.Serialize(fullPath, config, typeof(T), false);
            }
            catch (Exception e)
            {
                //LogMgr.Instance.Error("系统配置保存失败！", e);
                return false;
            }
            return true;
        }
    }
}
