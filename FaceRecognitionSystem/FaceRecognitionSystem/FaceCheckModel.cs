using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FaceRecognitionSystem.Common;

namespace FaceRecognitionSystem
{
    public class FaceCheckModel
    {
        /// <summary>
        /// 检测到的图片中的人脸数量
        /// </summary>
        public int Face_num { get; set; }
        /// <summary>
        /// 人脸信息列表
        /// </summary>
        public List<Face_listItem> Face_list { get; set; }
    }
    /// <summary>
    /// 人脸在图片中的位置
    /// </summary>
    public class Location
    {
        /// <summary>
        /// 人脸区域离左边界的距离
        /// </summary>
        public double Left { get; set; }
        /// <summary>
        /// 人脸区域离上边界的距离
        /// </summary>
        public double Top { get; set; }
        /// <summary>
        /// 人脸区域的宽度
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// 人脸区域的高度
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// 人脸框相对于竖直方向的顺时针旋转角，[-180,180]
        /// </summary>
        public int Rotation { get; set; }
    }
    /// <summary>
    /// 人脸旋转角度参数
    /// </summary>
    public class Angle
    {
        /// <summary>
        /// 三维旋转之左右旋转角[-90(左), 90(右)]
        /// </summary>
        public double Yaw { get; set; }
        /// <summary>
        /// 三维旋转之俯仰角度[-90(上), 90(下)]
        /// </summary>
        public double Pitch { get; set; }
        /// <summary>
        /// 平面内旋转角[-180(逆时针), 180(顺时针)]
        /// </summary>
        public double Roll { get; set; }
    }
    /// <summary>
    /// 4个关键点位置，左眼中心、右眼中心、鼻尖、嘴中心。face_field包含landmark时返回
    /// </summary>
    public class LandmarkItem
    {
        /// <summary>
        /// 
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Y { get; set; }
    }
    /// <summary>
    /// 72个特征点位置 face_field包含landmark72时返回
    /// </summary>
    public class Landmark72Item
    {
        /// <summary>
        /// 
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Y { get; set; }
    }
    /// <summary>
    /// 表情，当 face_field包含expression时返回
    /// </summary>
    public class Expression
    {
        /// <summary>
        /// none:不笑；smile:微笑；laugh:大笑
        /// </summary>
        public ExpressionEnum Type { get; set; }
        /// <summary>
        /// 表情置信度，范围【0~1】，0最小、1最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 性别，face_field包含gender时返回
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// male:男性 female:女性
        /// </summary>
        public GenderEnum Type { get; set; }
        /// <summary>
        /// 性别置信度，范围【0~1】，0代表概率最小、1代表最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 是否带眼镜，face_field包含glasses时返回
    /// </summary>
    public class Glasses
    {
        /// <summary>
        /// none:无眼镜，common:普通眼镜，sun:墨镜
        /// </summary>
        public GlassesEnum Type { get; set; }
        /// <summary>
        /// 眼镜置信度，范围【0~1】，0代表概率最小、1代表最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 人种 
    /// </summary>
    public class Race
    {
        /// <summary>
        /// yellow: 黄种人 white: 白种人 black:黑种人 arabs: 阿拉伯人
        /// </summary>
        public RaceEnum Type { get; set; }
        /// <summary>
        /// 人种置信度，范围【0~1】，0代表概率最小、1代表最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 脸型
    /// </summary>
    public class Face_shape
    {
        /// <summary>
        /// 	square: 正方形 triangle:三角形 oval: 椭圆 heart: 心形 round: 圆形
        /// </summary>
        public Face_shapeEnum Type { get; set; }
        /// <summary>
        /// 置信度，范围【0~1】，代表这是人脸形状判断正确的概率，0最小、1最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 真实人脸/卡通人脸
    /// </summary>
    public class Face_type
    {
        /// <summary>
        /// human: 真实人脸 cartoon: 卡通人脸
        /// </summary>
        public Face_typeEnum Type { get; set; }
        /// <summary>
        /// 置信度，范围【0~1】，代表这是人脸形状判断正确的概率，0最小、1最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 情绪 
    /// </summary>
    public class Emotion
    {
        /// <summary>
        ///angry:愤怒 disgust:厌恶 fear:恐惧 happy:高兴sad:伤心 surprise:惊讶 neutral:无情绪
        /// </summary>
        public EmotionEnum Type { get; set; }
        /// <summary>
        /// 置信度，范围【0~1】，代表这是人脸形状判断正确的概率，0最小、1最大。
        /// </summary>
        public double Probability { get; set; }
    }
    /// <summary>
    /// 左右眼 未闭合概率
    /// </summary>
    public class Eye_status
    {
        /// <summary>
        /// 左眼状态 [0,1]取值，越接近0闭合的可能性越大
        /// </summary>
        public double Left_eye { get; set; }
        /// <summary>
        /// 右眼状态 [0,1]取值，越接近0闭合的可能性越大
        /// </summary>
        public double Right_eye { get; set; }
    }
    /// <summary>
    /// 人脸各部分遮挡的概率，范围[0~1]，0表示完整，1表示不完整
    /// </summary>
    public class Occlusion
    {
        /// <summary>
        /// 左眼遮挡比例，[0-1] ，1表示完全遮挡
        /// </summary>
        public double Left_eye { get; set; }
        /// <summary>
        /// 右眼遮挡比例，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Right_eye { get; set; }
        /// <summary>
        /// 鼻子遮挡比例，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Nose { get; set; }
        /// <summary>
        /// 嘴巴遮挡比例，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Mouth { get; set; }
        /// <summary>
        /// 左脸颊遮挡比例，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Left_cheek { get; set; }
        /// <summary>
        /// 右脸颊遮挡比例，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Right_cheek { get; set; }
        /// <summary>
        /// 下巴遮挡比例，，[0-1] ， 1表示完全遮挡
        /// </summary>
        public double Chin { get; set; }
    }
    /// <summary>
    /// 人脸质量信息
    /// </summary>
    public class Quality
    {
        /// <summary>
        /// 人脸各部分遮挡的概率，范围[0~1]，0表示完整，1表示不完整
        /// </summary>
        public Occlusion Occlusion { get; set; }
        /// <summary>
        /// 人脸模糊程度，范围[0~1]，0表示清晰，1表示模糊
        /// </summary>
        public double Blur { get; set; }
        /// <summary>
        /// 取值范围在[0~255], 表示脸部区域的光照程度 越大表示光照越好
        /// </summary>
        public double Illumination { get; set; }
        /// <summary>
        /// 人脸完整度，0或1, 0为人脸溢出图像边界，1为人脸都在图像边界内
        /// </summary>
        public int Completeness { get; set; }
    }

    public class Face_listItem
    {
        /// <summary>
        /// 人脸图片的唯一标识
        /// </summary>
        public string Face_token { get; set; }
        /// <summary>
        /// 人脸在图片中的位置
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// 人脸置信度，范围【0~1】，代表这是一张人脸的概率，0最小、1最大。
        /// </summary>
        public double Face_probability { get; set; }
        /// <summary>
        /// 人脸旋转角度参数
        /// </summary>
        public Angle Angle { get; set; }
        /// <summary>
        /// 4个关键点位置，左眼中心、右眼中心、鼻尖、嘴中心
        /// </summary>
        public List<LandmarkItem> Landmark { get; set; }
        /// <summary>
        /// 72个特征点位置
        /// </summary>
        public List<Landmark72Item> Landmark72 { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public double Age { get; set; }
        /// <summary>
        /// 美丑打分
        /// </summary>
        public double Beauty { get; set; }
        /// <summary>
        /// 表情
        /// </summary>
        public Expression Expression { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 是否带眼镜
        /// </summary>
        public Glasses Glasses { get; set; }
        /// <summary>
        /// 人种
        /// </summary>
        public Race Race { get; set; }
        /// <summary>
        /// 脸型
        /// </summary>
        public Face_shape Face_shape { get; set; }
        /// <summary>
        /// 真实人脸/卡通人脸
        /// </summary>
        public Face_type Face_Type { get; set; }
        /// <summary>
        /// 人脸质量信息
        /// </summary>
        public Quality Quality { get; set; }
        /// <summary>
        /// 情绪
        /// </summary>
        public Emotion Emotion { get; set; }
        /// <summary>
        /// 双眼状态（睁开/闭合） face_field包含eye_status时返回
        /// </summary>
        public Eye_status Eye_status { get; set; }
    }
}
