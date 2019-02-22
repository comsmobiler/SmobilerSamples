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
            Smobiler.Core.Controls.ToolBarItem toolBarItem56 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem57 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem58 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem59 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem60 = new Smobiler.Core.Controls.ToolBarItem();
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
            toolBarItem56.IconID = "cangku";
            toolBarItem56.Name = "仓库";
            toolBarItem56.SelectIconID = "cangku_sel";
            toolBarItem56.Text = "仓库";
            toolBarItem57.IconID = "dingdan";
            toolBarItem57.Name = "订单";
            toolBarItem57.SelectIconID = "dingdan_sel";
            toolBarItem57.Text = "订单";
            toolBarItem58.IconID = "shuju";
            toolBarItem58.Name = "主数据";
            toolBarItem58.SelectIconID = "shuju_sel";
            toolBarItem58.Text = "主数据";
            toolBarItem59.IconID = "tongji";
            toolBarItem59.Name = "统计";
            toolBarItem59.SelectIconID = "tongji_sel";
            toolBarItem59.Text = "统计";
            toolBarItem60.IconID = "shezhi";
            toolBarItem60.Name = "设置";
            toolBarItem60.SelectIconID = "shezhi_sel";
            toolBarItem60.Text = "设置";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem56,
            toolBarItem57,
            toolBarItem58,
            toolBarItem59,
            toolBarItem60});
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