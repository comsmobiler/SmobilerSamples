using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Net;
using Smobiler.Core.Web;

namespace SmobilerSamples
{
    partial class demoCustomHttpResource : Smobiler.Core.Controls.MobileForm
    {

        private const string resourceUrl = "custom/resource";

        static demoCustomHttpResource()
        {
            //在此处，注册的为url地址
            MobileServer.RegisterHttpHandler(resourceUrl, new HttpCustomHttpResourceHandler());
        }

        private void demoCustomHttpResource_Load(object sender, EventArgs e)
        {

        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateImage_Press(object sender, EventArgs e)
        {
            //刷新图像
            this.image1.ResourceID = MobileResourceManager.GetResourceURL(this.Client.SessionID, resourceUrl + "?id=test");
            this.image1.Refresh();
        }
    }


    class HttpCustomHttpResourceHandler : IHttpHandler
    {

        void IHttpHandler.ProcessRequest(HttpListenerContext context, HttpHandlerData handlerdata)
        {
            //var client = ClientVariables.GetCurrentClient(handlerdata.SessionID); //使用此各方式获取当前client
            //var form = client.GetActiveForm(); //使用此种方式获取客户端

            //解析当前的query，即上面ResourceID中的等号中的内容
            var utf8Requests = System.Web.HttpUtility.ParseQueryString(context.Request.Url.Query, System.Text.Encoding.UTF8);
            var id = utf8Requests["id"];
            //这里动态生成一个图像
            var image = new System.Drawing.Bitmap(300, 300);
            var g = System.Drawing.Graphics.FromImage(image);
            //写上当前时间
            g.DrawString(id + DateTime.Now.ToString(), new System.Drawing.Font("宋体", 14), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 0, 0);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                //获取图像资源
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                var imageData = ms.GetBuffer();
                //向客户端写入数据
                context.Response.ContentType = "image/png"; //这里需要给定图片类型
                context.Response.ContentLength64 = imageData.Length;
                context.Response.OutputStream.Write(imageData, 0, imageData.Length);
            }
        }
    }
}