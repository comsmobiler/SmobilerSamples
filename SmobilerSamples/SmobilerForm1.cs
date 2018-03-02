using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamples
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup grp1=new ListMenuViewGroup();
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView服务端刷新", "", "") { Tag = "demoListViewRefresh" });
            grp1.Items.Add(new ListMenuViewItem("logon", "数据选择", "", "") { Tag = "userFilter" });
            grp1.Items.Add(new ListMenuViewItem("logon", "底部弹出输入Dialog", "", "") { Tag = "userFooterDialog" });
            this.listMenuView1.Groups.Add(grp1);
        }

        userFilter filter;
        DialogOptions filterOptions;

        SmobilerSamples.ShowDialog.userFooterDialog footerDialog;
        DialogOptions footerDialogOptions;

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch(e.Item.Tag.ToString ())
            {
                case "demoListViewRefresh":
                    {
                        this.Show(new demoListViewRefresh());
                    }
                    break;
                case "userFilter":
                    {
                        //Dialog显示的自定义控件，如果重复使用，不需要每一次都实例化，如果需要实例化，记得把原来的给Destroy
                        if (filter == null)
                        {
                            //由于内部使用了Flex布局，需要在外部给定高度
                            filter= new userFilter();
                            filter.Height = 400;
                            filter.BackColor = System.Drawing.Color.White;
                            //最后一个参数代表支持点击空白处关闭
                            filterOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                        }
                        this.ShowDialog(filter, filterOptions);
                    }
                    break;
                case "userFooterDialog":
                    {
                        //Dialog显示的自定义控件，如果重复使用，不需要每一次都实例化，如果需要实例化，记得把原来的给Destroy
                        if (footerDialog == null)
                        {
                            //由于内部控件都有了高度，所以userFooterDialog不用设置高度，会自动撑大
                            footerDialog = new SmobilerSamples.ShowDialog.userFooterDialog();
                            //最后一个参数代表支持点击空白处关闭
                            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                        }
                        this.ShowDialog(footerDialog, footerDialogOptions);
                    }
                    break;
            }
        }
    }
}