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
            //�ڴ˴���ע���Ϊurl��ַ
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
            //ˢ��ͼ��
            this.image1.ResourceID = MobileResourceManager.GetResourceURL(this.Client.SessionID, resourceUrl + "?id=test");
            this.image1.Refresh();
        }
    }


    class HttpCustomHttpResourceHandler : IHttpHandler
    {

        void IHttpHandler.ProcessRequest(HttpListenerContext context, HttpHandlerData handlerdata)
        {
            //var client = ClientVariables.GetCurrentClient(handlerdata.SessionID); //ʹ�ô˸���ʽ��ȡ��ǰclient
            //var form = client.GetActiveForm(); //ʹ�ô��ַ�ʽ��ȡ�ͻ���

            //������ǰ��query��������ResourceID�еĵȺ��е�����
            var utf8Requests = System.Web.HttpUtility.ParseQueryString(context.Request.Url.Query, System.Text.Encoding.UTF8);
            var id = utf8Requests["id"];
            //���ﶯ̬����һ��ͼ��
            var image = new System.Drawing.Bitmap(300, 300);
            var g = System.Drawing.Graphics.FromImage(image);
            //д�ϵ�ǰʱ��
            g.DrawString(id + DateTime.Now.ToString(), new System.Drawing.Font("����", 14), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 0, 0);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                //��ȡͼ����Դ
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                var imageData = ms.GetBuffer();
                //��ͻ���д������
                context.Response.ContentType = "image/png"; //������Ҫ����ͼƬ����
                context.Response.ContentLength64 = imageData.Length;
                context.Response.OutputStream.Write(imageData, 0, imageData.Length);
            }
        }
    }
}