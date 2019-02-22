using System;
using Smobiler.Core;
namespace SmobilerSamples.Layout.UserControl
{
    partial class frmMenu : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup9 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem45 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem46 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem47 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem48 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem49 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem50 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup10 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem51 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem52 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem53 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem54 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem55 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.plWareHouse = new Smobiler.Core.Controls.Panel();
            this.btnWareHouse = new Smobiler.Core.Controls.Button();
            this.iconMenu = new Smobiler.Core.Controls.IconMenuView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "仓库";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plWareHouse,
            this.iconMenu});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            // 
            // plWareHouse
            // 
            this.plWareHouse.BackColor = System.Drawing.Color.White;
            this.plWareHouse.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWareHouse});
            this.plWareHouse.Name = "plWareHouse";
            this.plWareHouse.Size = new System.Drawing.Size(0, 35);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackColor = System.Drawing.Color.White;
            this.btnWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWareHouse.BorderRadius = 0;
            this.btnWareHouse.ForeColor = System.Drawing.Color.Black;
            this.btnWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnWareHouse.Location = new System.Drawing.Point(200, 0);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnWareHouse.Size = new System.Drawing.Size(100, 35);
            this.btnWareHouse.Text = "全部仓库   > ";
            this.btnWareHouse.Press += new System.EventHandler(this.btnWareHouse_Press);
            // 
            // iconMenu
            // 
            this.iconMenu.GridLines = true;
            iconMenuViewGroup9.FontSize = 0F;
            iconMenuViewGroup9.IconBorderRadius = 0;
            iconMenuViewGroup9.ItemHeight = 0;
            iconMenuViewItem45.Icon = "zichan";
            iconMenuViewItem45.ID = "0";
            iconMenuViewItem45.Text = "资产管理";
            iconMenuViewItem45.Value = "Assets";
            iconMenuViewItem46.Icon = "muban";
            iconMenuViewItem46.ID = "1";
            iconMenuViewItem46.Text = "资产模板";
            iconMenuViewItem46.Value = "AssTemplate";
            iconMenuViewItem47.Icon = "ruku";
            iconMenuViewItem47.ID = "2";
            iconMenuViewItem47.Text = "入库";
            iconMenuViewItem47.Value = "AssIn";
            iconMenuViewItem48.Icon = "chuku";
            iconMenuViewItem48.ID = "3";
            iconMenuViewItem48.Text = "出库";
            iconMenuViewItem48.Value = "AssOut";
            iconMenuViewItem49.Icon = "diaobo";
            iconMenuViewItem49.ID = "5";
            iconMenuViewItem49.Text = "调拨";
            iconMenuViewItem49.Value = "AssTransfer";
            iconMenuViewItem50.Icon = "pandian";
            iconMenuViewItem50.ID = "4";
            iconMenuViewItem50.Text = "盘点";
            iconMenuViewItem50.Value = "AssInventory";
            iconMenuViewGroup9.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem45,
            iconMenuViewItem46,
            iconMenuViewItem47,
            iconMenuViewItem48,
            iconMenuViewItem49,
            iconMenuViewItem50});
            iconMenuViewGroup9.ShowTitle = true;
            iconMenuViewGroup9.Text = "资产";
            iconMenuViewGroup10.FontSize = 0F;
            iconMenuViewGroup10.IconBorderRadius = 0;
            iconMenuViewGroup10.ItemHeight = 0;
            iconMenuViewItem51.Icon = "haocai";
            iconMenuViewItem51.ID = "0";
            iconMenuViewItem51.Text = "耗材管理";
            iconMenuViewItem51.Value = "ConManage";
            iconMenuViewItem52.Icon = "ruku";
            iconMenuViewItem52.ID = "1";
            iconMenuViewItem52.Text = "入库";
            iconMenuViewItem52.Value = "ConIn";
            iconMenuViewItem53.Icon = "chuku";
            iconMenuViewItem53.ID = "2";
            iconMenuViewItem53.Text = "出库";
            iconMenuViewItem53.Value = "ConOut";
            iconMenuViewItem54.Icon = "diaobo";
            iconMenuViewItem54.ID = "2";
            iconMenuViewItem54.Text = "调拨";
            iconMenuViewItem54.Value = "ConTransfer";
            iconMenuViewItem55.Icon = "pandian";
            iconMenuViewItem55.ID = "3";
            iconMenuViewItem55.Text = "盘点";
            iconMenuViewItem55.Value = "ConInventory";
            iconMenuViewGroup10.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem51,
            iconMenuViewItem52,
            iconMenuViewItem53,
            iconMenuViewItem54,
            iconMenuViewItem55});
            iconMenuViewGroup10.ShowTitle = true;
            iconMenuViewGroup10.Text = "耗材";
            this.iconMenu.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup9,
            iconMenuViewGroup10});
            this.iconMenu.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(300, 425);
            this.iconMenu.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenu_ItemPress);
            // 
            // frmMenu
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 500);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Name = "frmMenu";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel plWareHouse;
        internal Smobiler.Core.Controls.Button btnWareHouse;
        private Smobiler.Core.Controls.IconMenuView iconMenu;
    }
}