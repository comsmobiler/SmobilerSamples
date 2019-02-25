using System;
using Smobiler.Core;
namespace SmobilerSamples.Layout
{
    partial class demoTabToolbar : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem6 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem7 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem8 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem9 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem10 = new Smobiler.Core.Controls.ToolBarItem();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(0, 300);
            this.tabPageView1.PageIndexChanged += new System.EventHandler(this.tabPageView1_PageIndexChanged);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolBar.ItemCount = 5;
            toolBarItem6.IconID = "cangku";
            toolBarItem6.Name = "仓库";
            toolBarItem6.SelectIconColor = System.Drawing.Color.DarkGray;
            toolBarItem6.SelectIconID = "cangku_sel";
            toolBarItem6.Text = "仓库";
            toolBarItem7.IconID = "dingdan";
            toolBarItem7.Name = "订单";
            toolBarItem7.SelectIconID = "dingdan_sel";
            toolBarItem7.Text = "订单";
            toolBarItem8.IconID = "shuju";
            toolBarItem8.Name = "主数据";
            toolBarItem8.SelectIconID = "shuju_sel";
            toolBarItem8.Text = "主数据";
            toolBarItem9.IconID = "tongji";
            toolBarItem9.Name = "统计";
            toolBarItem9.SelectIconID = "tongji_sel";
            toolBarItem9.Text = "统计";
            toolBarItem10.IconID = "shezhi";
            toolBarItem10.Name = "设置";
            toolBarItem10.SelectIconID = "shezhi_sel";
            toolBarItem10.Text = "设置";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem6,
            toolBarItem7,
            toolBarItem8,
            toolBarItem9,
            toolBarItem10});
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(0, 50);
            this.toolBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar_ToolbarItemClick);
            // 
            // demoTabToolbar
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1,
            this.toolBar});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Load += new System.EventHandler(this.demoTabToolbar_Load);
            this.Name = "demoTabToolbar";

        }
        #endregion

        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.ToolBar toolBar;
    }
}