using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Newtonsoft.Json;
using System.Net;

using static FaceRecognitionSystem.Common;
using CCWin;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;

namespace FaceRecognitionSystem
{
    public partial class Main : Skin_Mac
    {
        /// <summary>
        /// 总摄像头
        /// </summary>
        private FilterInfoCollection VideoDevices { get; set; }
        /// <summary>
        /// 当前选中的摄像头
        /// </summary>
        private VideoCaptureDevice VideoDevice { get; set; }
        /// <summary>
        /// 当前选中摄像头的所有分辨率
        /// </summary>
        private VideoCapabilities[] VideoCapabilities { get; set; }
        private VideoCapabilities[] SnapshotCapabilities { get; set; }

        private delegate void SetTextCallback(TextBox textBox, object result, string title, bool IsClearText = false);
        private static int Max_face_num = 2;
        private static int Result_num = 1;
        private static readonly string API_KEY = "s5V0Nz2kFFRhx1u8NyeW0je1";
        private static readonly string SECRET_KEY = "QC9gFbiGe96GTUAwpzv2OViyEcTZr7yx";
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CanResize = false;
        }
        /// <summary>
        /// 初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (VideoDevices.Count != 0)
            {
                foreach (FilterInfo device in VideoDevices)
                {
                    skincbxCamera.Items.Add(device.Name);
                }
            }
            else
            {
                skincbxCamera.Items.Add("没有找到摄像头");
            }
            skincbxCamera.SelectedIndex = 0;
            this.skincbxnumber.SelectedIndex = 1;
            this.skinComboBox1.SelectedIndex = 0;
            this.skinComboBox2.SelectedIndex = 0;
        }
        /// <summary>
        /// 选择摄像头改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skincbxCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VideoDevices.Count != 0)
            {
                VideoDevice = new VideoCaptureDevice(VideoDevices[skincbxCamera.SelectedIndex].MonikerString);
                GetDeviceResolution(VideoDevice);
            }
        }
        /// <summary>
        /// 获取摄像头分辨率
        /// </summary>
        /// <param name="videoCaptureDevice"></param>
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            skincbxRP.Items.Clear();
            VideoCapabilities = videoCaptureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilty in VideoCapabilities)
            {
                skincbxRP.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            if (skincbxRP != null && skincbxRP.Items != null && skincbxRP.Items.Count > 0)
                skincbxRP.SelectedIndex = skincbxRP.Items.Count - 1;
            else
                skincbxRP.SelectedIndex = 0;
        }
        /// <summary>
        /// 连接摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (VideoDevice != null)
            {
                if ((VideoCapabilities != null) && (VideoCapabilities.Length != 0))
                {
                    VideoDevice.VideoResolution = VideoCapabilities[skincbxRP.SelectedIndex];

                    vispShoot.VideoSource = VideoDevice;
                    vispShoot.Start();
                    EnableControlStatus(false);
                }
            }
        }
        /// <summary>
        /// 设置控件属性
        /// </summary>
        /// <param name="status"></param>
        private void EnableControlStatus(bool status)
        {
            skincbxCamera.Enabled = status;
            skincbxRP.Enabled = status;
            btnConnect.Enabled = status;
            btnShoot.Enabled = !status;
            btnPhotograph.Enabled = !status;
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShoot_Click(object sender, EventArgs e)
        {
            DisConnect();
            EnableControlStatus(true);
        }
        /// <summary>
        /// 断开连接,删除vdieo影像
        /// </summary>
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }
        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //断开摄像头连接
            DisConnect();
            //关闭当前应用程序
            Application.Exit();
        }
        /// <summary>
        /// 拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPhotograph_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            picbPreview.Image = img;
        }
        /// <summary>
        /// 图像转base64编码
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public string ImgToBase64String(Bitmap bmp)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ImgToBase64String 转换失败 Exception:" + ex.Message);
                return "";
            }
        }
        /// <summary>
        /// 人脸检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (picbPreview.Image is null)
            {
                MessageBox.Show("请先拍照或者选取一张图片,再进行检测操作");
                return;
            }
            // var APP_ID = "17894506";
            Thread threadadd = new Thread(() =>
            {
                try
                {
                    var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY)
                    {
                        Timeout = 60000  // 修改超时时间
                    };
                    var image = ImgToBase64String((Bitmap)this.picbPreview.Image);
                    var imageType = "BASE64";

                    // 调用人脸检测，可能会抛出网络等异常，请使用try/catch捕获
                    var result = client.Detect(image, imageType);
                    // 如果有可选参数
                    var options = new Dictionary<string, object>
                    {
                        {"face_field","age,beauty,expression,face_shape,gender,glasses," +
                        ",race,quality,eye_status,emotion,face_type,eye_status"},
                        {"max_face_num", Max_face_num},
                        {"face_type", "LIVE"},
                        {"liveness_control", "LOW"}
                    };
                    // 带参数调用人脸检测
                    result = client.Detect(image, imageType, options);
                    if (result != null && result.ToString() != null && result.ToString().Length > 0)
                    {
                        var json = JsonConvert.SerializeObject(result);
                        FaceCheckModel model = DeserializeJsonToObject<GetApiJson<FaceCheckModel>>(json)?.Result ?? new FaceCheckModel();
                        FaceTestBind(model);
                    };


                    var picclient = new Baidu.Aip.ImageClassify.ImageClassify("NpBGfUR6qBGtFo5bIFbiPCO9", "S0L7LXAewfW7BBKmbXd0EQ8iRzEYRGqc")
                    {
                        Timeout = 60000  // 修改超时时间
                    };
                    Image img = this.picbPreview.Image;
                    MemoryStream ms = new MemoryStream();
                    byte[] imagedata = null;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagedata = ms.GetBuffer();

                    var picoptions = new Dictionary<string, object> { { "baike_num",Result_num } };

                    var results = picclient.AdvancedGeneral(imagedata, picoptions);
                    if (results != null && results.ToString() != null && results.ToString().Length > 0)
                    {

                        var json = JsonConvert.SerializeObject(results);
                        ImageRecognitionModel model = DeserializeJsonToObject<ImageRecognitionModel>(json) ?? new ImageRecognitionModel();
                        ImageRecognitionBind(model);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("网络错误！错误信息:"+ex.Message);
                }
            });
            threadadd.Start();
        }
        /// <summary>
        /// 图片转换为字节数组
        /// </summary>
        /// <param name="image">图片</param>
        /// <returns>字节数组</returns>
        public byte[] ImageToBytes(Image image)
        {
            var ms = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(ms, image);
            ms.Close();
            return ms.ToArray();
        }
        /// <summary>
        /// 绑定检测信息
        /// </summary>
        public void FaceTestBind(FaceCheckModel model)
        {
            //清空文本框
            TestTextBoxAdd(textBox1, "", "", true);
            if (model.Face_num > 0) 
            {
                if (model.Face_list != null && model.Face_list.AsEnumerable() != null && model.Face_list.AsEnumerable().Any())
                {
                    TestTextBoxAdd(textBox1, model.Face_num, "人脸数量为:");
                    TestTextBoxAdd(textBox1, "", "--------------------------------------");
                    int count = 0;
                    foreach (var item in model.Face_list)
                    {
                        count++;
                        TestTextBoxAdd(textBox1, "", $"当前检测第{count}张人脸{item.Face_probability * 100}%为一张真实人脸");
                        TestTextBoxAdd(textBox1,   $"{item.Quality.Blur * 100}%", "人脸模糊程度 :");
                        TestTextBoxAdd(textBox1, item.Age, "年龄 :");
                        TestTextBoxAdd(textBox1, item.Beauty, "美丑打分 :");
                        TestTextBoxAdd(textBox1, item.Gender.Type.GetEnumDescription() + $"  概率为{item.Expression.Probability * 100}%", "性别 :");
                        TestTextBoxAdd(textBox1, item.Expression.Type.GetEnumDescription() + $"  概率为{item.Expression.Probability * 100}%", "表情 :");
                        TestTextBoxAdd(textBox1, item.Emotion.Type.GetEnumDescription() + $"  概率为{item.Emotion.Probability * 100}%", "情绪 :");
                        TestTextBoxAdd(textBox1, item.Glasses.Type.GetEnumDescription() + $"  概率为{item.Glasses.Probability * 100}%", "是否带眼镜 :");
                        TestTextBoxAdd(textBox1, $"左眼未闭合概率为{item.Eye_status.Left_eye*100}%,\r\n\r\n右眼未闭合概率为{item.Eye_status.Right_eye * 100}%", "右眼闭合状态 :");
                        TestTextBoxAdd(textBox1, item.Race.Type.GetEnumDescription() + $"  概率为{item.Race.Probability * 100}%", "人种 :");
                        TestTextBoxAdd(textBox1, item.Face_shape.Type.GetEnumDescription() + $"  概率为{item.Face_shape.Probability * 100}%", "脸型 :");
                        TestTextBoxAdd(textBox1, item.Face_Type.Type.GetEnumDescription() + $"  概率为{item.Face_Type.Probability * 100}%", "真实人脸/卡通人脸 :");
                        TestTextBoxAdd(textBox1, "", "--------------------------------------");
                    }
                }
            }
            else
            {
                TestTextBoxAdd(textBox1, "", "未获取到人脸信息,或者网络异常!");
            }
            
        }
        /// <summary>
        /// 图像识别绑定信息
        /// </summary>
        /// <param name="model"></param>
        public void ImageRecognitionBind(ImageRecognitionModel model)
        {
            //清空文本框
            TestTextBoxAdd(textBox2, "", "", true);
            if (model != null && model.Log_id != 0)
            {
                if (model.Result_num > 0 && model.Result != null && model.Result.Count > 0)
                {
                    int count = 0;
                    foreach (var item in model.Result)
                    {
                        count++;
                        TestTextBoxAdd(textBox2, $"{item.Root}-{item.Keyword}-置信度{item.Score * 100}%",count+"" );
                        if (item.Baike_info != null)
                        {
                            TestTextBoxAdd(textBox2, $"{item.Baike_info.Baike_url}", "百科页面链接:");
                            TestTextBoxAdd(textBox2, $"{item.Baike_info.Image_url}", "百科图片链接:");
                            TestTextBoxAdd(textBox2, $"{item.Baike_info.Description}", "百科内容描述:");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 多行文本框
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="result"></param>
        /// <param name="title"></param>
        /// <param name="IsClearText"></param>
        private void TestTextBoxAdd(TextBox textBox, object result, string title,bool IsClearText=false)
        {
            // InvokeRequired需要比较调用线程ID和创建线程ID
            // 如果它们不相同则返回true
            if (textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(TestTextBoxAdd);
                textBox.Invoke(d, new object[] { textBox, result, title, IsClearText });
            }
            else
            {
                if (IsClearText)
                    textBox.Text = "";
                else
                    textBox.Text += $"{title}{result}{Environment.NewLine}{Environment.NewLine}";
            }
        }
        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T DeserializeJsonToObject<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
            {
                Bitmap image = new Bitmap(openfile.FileName);
                picbPreview.Image = image;
            }
            openfile.Dispose();
        }
        /// <summary>
        /// 下拉框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skincbxnumber_TextChanged(object sender, EventArgs e)
        {
            Max_face_num = Convert.ToInt32(this.skincbxnumber.SelectedItem+"");
        }
        /// <summary>
        /// 通过打开一个文件来进行图像识别
        /// </summary>
        public void EasyPicRecognition()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string _path = ofd.FileName;
            var picclient = new Baidu.Aip.ImageClassify.ImageClassify("NpBGfUR6qBGtFo5bIFbiPCO9", "S0L7LXAewfW7BBKmbXd0EQ8iRzEYRGqc")
            {
                Timeout = 60000 // 修改超时时间
            };
            var image = File.ReadAllBytes(_path);
            var picoptions = new Dictionary<string, object> { };
            var results = picclient.AdvancedGeneral(image, picoptions);
            if (results != null && results.ToString() != null && results.ToString().Length > 0)
            {

                var json = JsonConvert.SerializeObject(results);
                ImageRecognitionModel model = DeserializeJsonToObject<ImageRecognitionModel>(json) ?? new ImageRecognitionModel();
                ImageRecognitionBind(model);
            }
        }
        /// <summary>
        /// 识别类型处理,其他例如菜品识别,logo识别,可参考https://ai.baidu.com/ai-doc/IMAGERECOGNITION/ek3bcxh2q百度ai SDK调用文档查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.skinComboBox1.SelectedIndex != 0)
            {
                MessageBox.Show("功能暂未开发");
                this.skinComboBox1.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 返回词条数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinComboBox2_TextChanged(object sender, EventArgs e)
        {
            Result_num = Convert.ToInt32(this.skinComboBox2.SelectedItem);
        }
    }
}
