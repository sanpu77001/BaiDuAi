using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognitionSystem
{
    public class ImageRecognitionModel
    {
        /// <summary>
        /// 唯一的log id，用于问题定位
        /// </summary>
        public UInt64 Log_id { get; set; }
        /// <summary>
        ///返回结果数目，及result数组中的元素个数
        /// </summary>
        public UInt32 Result_num { get; set; }
        /// <summary>
        /// 标签结果数组
        /// </summary>
        public List<ResultItem> Result { get; set; }
    }
    public class Baike_info
    {
        /// <summary>
        /// 对应识别结果百度百科页面链接
        /// </summary>
        public string Baike_url { get; set; }
        /// <summary>
        /// 对应识别结果百科图片链接
        /// </summary>
        public string Image_url { get; set; }
        /// <summary>
        /// 对应识别结果百科内容描述
        /// </summary>
        public string Description { get; set; }
    }

    public class ResultItem
    {
        /// <summary>
        /// 置信度，0-1
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 识别结果的上层标签，有部分钱币、动漫、烟酒等tag无上层标签
        /// </summary>
        public string Root { get; set; }
        /// <summary>
        /// 对应识别结果的百科词条名称
        /// </summary>
        public Baike_info Baike_info { get; set; }
        /// <summary>
        /// 图片中的物体或场景名称
        /// </summary>
        public string Keyword { get; set; }
    }
}
