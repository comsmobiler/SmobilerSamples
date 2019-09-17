using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamples.WebView
{
    partial class demoHtmlInteraction : Smobiler.Core.Controls.MobileForm
    {
        public demoHtmlInteraction() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void btnSetCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage(@"var Days = 30;
    var exp = new Date();
    exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
    document.cookie = 'name=' + escape('smopwd') + ';expires=' + exp.toGMTString();
     document.getElementById('smoMessage').innerHTML =
              '从Smobiler接收的消息: ' + 'SetCookie';
    var result = JSON.stringify({
      code: 0,
      message:'',
      data:'设置成功'
    });
    window.ReactNativeWebView.postMessage(result);
");
        }

        private void btnGetCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage(@"var arr, reg = new RegExp('(^| )' + 'name' + '=([^;]*)(;|$)');
    var cookie = null;
    if (arr = document.cookie.match(reg)) {
      cookie = unescape(arr[2]);
    }
     document.getElementById('smoMessage').innerHTML =
              '从Smobiler接收的消息: ' + 'GetCookie';
    var result = JSON.stringify({
      code: 0,
      message:'',
      data:cookie
    });
    window.ReactNativeWebView.postMessage(result);
");
        }

        private void btnDelCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage(@"var exp = new Date();
    exp.setTime(exp.getTime() - 1);
            var arr, reg = new RegExp('(^| )' + 'name' + '=([^;]*)(;|$)');
            var cookie = null;
     document.getElementById('smoMessage').innerHTML =
              '从Smobiler接收的消息: ' + 'DelCookie';
            if (arr = document.cookie.match(reg))
            {
                cookie = unescape(arr[2]);
            }
            if (cookie != null)
            {
                document.cookie = 'name=' + cookie + ';expires=' + exp.toGMTString();
            }
            var result = JSON.stringify({
                code: 0,
      message: '删除成功'
            });
            window.ReactNativeWebView.postMessage(result);
            ");
        }

        //此方法用于处理OnMessage事件，此事件会在从网页上向控件发送消息时触发，详见jsCookie.html中的说明。
        private void webView1_OnMessage(object sender, WebViewMessageEventArgs e)
        {
            //这里直接弹出消息框显示接收到的数据
            MessageBox.Show("OnMessage: " + e.Message);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoHtmlInteraction_Load(object sender, EventArgs e)
        {
            //在项目中的Resources/Web文件夹下，有jsCookie.html，里面有对JS的说明。
            this.webView1.Url = MobileResourceManager.GetResourceURL(this.Client.SessionID, "jsCookie.html", MobileResourceManager.DefaultWebResourceName);
        }
    }
}