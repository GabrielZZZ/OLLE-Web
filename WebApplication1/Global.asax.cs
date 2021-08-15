using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        //global variables
        public static string host_url = "https://www.olle-nottingham.xyz/theAppDB/api/";


        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public class UserData
        {
            //store the information that the server returns after successful login

            public int user_id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string username { get; set; }
            public string language { get; set; }
            public string user_account_status { get; set; }
            public string profile_photo { get; set; }
            public string token { get; set; }


        };

        public class WrapperClass
        {
            public UserData userData { get; set; }
        }

        public static UserData TransferJson(string jsonMessage)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();   //实例化一个能够序列化数据的类

            WrapperClass wrapperclass = js.Deserialize<WrapperClass>(jsonMessage);    //将json数据转化为对象类型并赋值给list

            UserData userDataDetails = new UserData();

            userDataDetails.user_id = wrapperclass.userData.user_id;
            userDataDetails.name = wrapperclass.userData.name;
            userDataDetails.surname = wrapperclass.userData.surname;
            userDataDetails.email = wrapperclass.userData.email;
            userDataDetails.username = wrapperclass.userData.username;
            userDataDetails.language = wrapperclass.userData.language;
            userDataDetails.profile_photo = wrapperclass.userData.profile_photo;
            userDataDetails.token = wrapperclass.userData.token;
            userDataDetails.user_account_status = wrapperclass.userData.user_account_status;



            return userDataDetails;

        }

        public static string PostToServer(string url, string paramStr, string Method)//method for posting data to server
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);



            req.Method = Method;

            req.Timeout = 80000;//设置请求超时时间，单位为毫秒

            req.ContentType = "application/json";

            byte[] data = Encoding.UTF8.GetBytes(paramStr);

            req.ContentLength = data.Length;

            if (Method.Equals("POST"))
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);

                    reqStream.Close();
                }
            }



            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Stream stream = resp.GetResponseStream();


            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string result = reader.ReadToEnd();
                return result;
            }


        }

        /**
        public static void LTooltip(System.Windows.Forms.Label label, int length)
        {
            String value = label.Text;
            if (value.Length > length)
            {
                label.Text = label.Text.Substring(0, length) + "...";
            }
            var tip = new ToolTip();
            tip.IsBalloon = false;
            tip.ShowAlways = true;
            tip.SetToolTip(label, value);
        }


        public static void ChbTooltip(System.Windows.Forms.CheckBox ck, int length, string value)
        {
            ck.Text = value;
            if (value.Length > length)
            {
                ck.Text = ck.Text.Substring(0, length) + "...";
            }
            var tip = new ToolTip();
            tip.IsBalloon = false;
            tip.ShowAlways = true;
            tip.SetToolTip(ck, value);
        }

        public static void saveRTFfile(RichTextBox rtb, string path)
        {
            rtb.SaveFile(path);
        }
    **/


        //replace \n with special character
        public static string changeCharacter(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                //将特殊字符全部替换为下划线
                string pattern = "\n";
                return Regex.Replace(str, pattern, "<br>");
            }
            else
            {
                return "";
            }
        }

        //replace \n with special character
        public static string changeCharacterBack(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                //将特殊字符全部替换为下划线
                string pattern = "<br>";
                return Regex.Replace(str, pattern, "\n");
            }
            else
            {
                return "";
            }
        }

        //reverse string
        public static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static UserData userData;//global user data

    }
}