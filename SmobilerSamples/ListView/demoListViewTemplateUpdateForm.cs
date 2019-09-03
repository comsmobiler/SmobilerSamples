using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamples.ListView
{
    partial class demoListViewTemplateUpdateForm : Smobiler.Core.Controls.MobileForm
    {
        public demoListViewTemplateUpdateForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private string text1;
        private string text2;
        public demoListViewTemplateUpdateForm(string textbox1,string textbox2) : base()
        {
            text1 = textbox1;
            text2 = textbox2;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void demoListViewTemplateUpdateForm_Load(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            if (!string.IsNullOrEmpty(text1) & !string.IsNullOrEmpty(text2))
            {
                textBox1.Text = text1;
                textBox2.Text = text2;
            }
        }
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            this.Close();
        }


    }
}