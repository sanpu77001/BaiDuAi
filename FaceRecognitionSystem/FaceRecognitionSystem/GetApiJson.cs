using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognitionSystem
{
    public class GetApiJson<T>
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int Error_code { get; set; }
        /// <summary>
        /// 返回消息 成功还是失败
        /// </summary>
        public string Error_msg { get; set; }
        public string Log_id { get; set; }
        public string Timestamp { get; set; }
        public string Cached { get; set; }

        public T Result { get; set; }
    }
}
