using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognitionSystem
{
    public static class Common
    {
        /// <summary>
        /// 获取当前枚举描述
        /// </summary>
        /// <param name="enumValue"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum enumValue)
        {
            try
            {
                Type type = enumValue.GetType();
                MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
                if (null != memInfo && memInfo.Length > 0)
                {
                    object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (null != attrs && attrs.Length > 0)
                        return ((DescriptionAttribute)attrs[0]).Description;
                }
                return enumValue.ToString();
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }
        /// <summary>
        /// 表情
        /// </summary>
        public enum ExpressionEnum
        {
            [Description("不笑")]
            none,
            [Description("微笑")]
            smile,
            [Description("大笑")]
            laugh,
            End
        }
        /// <summary>
        /// 脸型
        /// </summary>
        public enum Face_shapeEnum
        {
            [Description("正方形")]
            square,
            [Description("三角形")]
            triangle,
            [Description("椭圆")]
            oval,
            [Description("心形")]
            heart,
            [Description("圆形")]
            round,
            End
        }
        /// <summary>
        /// 性别
        /// </summary>
        public enum GenderEnum
        {
            [Description("男性")]
            male,
            [Description("女性")]
            female,
            End
        }
        /// <summary>
        /// 是否戴眼镜
        /// </summary>
        public enum GlassesEnum
        {
            [Description("无眼镜")]
            none,
            [Description("普通眼镜")]
            common,
            [Description("墨镜")]
            sun,
            End
        }
        /// <summary>
        /// 人种
        /// </summary>
        public enum RaceEnum
        {
            [Description("黄种人")]
            yellow,
            [Description("白种人")]
            white,
            [Description("黑种人")]
            black,
            [Description("阿拉伯人")]
            arabs,
            End
        }
        /// <summary>
        /// 真实人脸/卡通人脸 
        /// </summary>
        public enum Face_typeEnum
        {
            [Description("真实人脸")]
            human,
            [Description("卡通人脸")]
            cartoon
        }
        /// <summary>
        /// 情绪
        /// </summary>
        public enum EmotionEnum
        {
            [Description("愤怒")]
            angry,
            [Description("厌恶")]
            disgust,
            [Description("恐惧")]
            fear,
            [Description("高兴")]
            happy,
            [Description("伤心")]
            sad,
            [Description("惊讶")]
            surprise,
            [Description("无情绪")]
            neutral,
            [Description("痛苦,厌恶")]
            grimace,
            End
        }
    }
}
