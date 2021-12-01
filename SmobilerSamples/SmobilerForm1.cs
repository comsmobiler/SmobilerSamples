using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmobilerSamples.Layout;
using SmobilerSamples.ListView;
using SmobilerSamples.Transparent;
using SmobilerSamples.WebView;

namespace SmobilerSamples
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {

        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            //����ListMenuViewGroup
            ListMenuViewGroup grp1 = new ListMenuViewGroup();
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView�����ˢ��", "", "") { Tag = "demoListViewRefresh" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ListViewģ����� - �༭����", "", "") { Tag = "demoListViewUpdate" });
            grp1.Items.Add(new ListMenuViewItem("logon", "����ѡ��", "", "") { Tag = "userFilter" });
            grp1.Items.Add(new ListMenuViewItem("logon", "�ײ���������Dialog", "", "") { Tag = "userFooterDialog" });
            grp1.Items.Add(new ListMenuViewItem("logon", "�������������", "", "") { Tag = "userDialogPassword" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ShowDialog���ȡ����", "", "") { Tag = "demogetdata" });
            grp1.Items.Add(new ListMenuViewItem("logon", "WebView���ظ�����Դ", "", "") { Tag = "demoWebView" });
            grp1.Items.Add(new ListMenuViewItem("logon", "Image��̬����ͼ��IExtendHandler", "", "") { Tag = "demoCustomResource" });
            grp1.Items.Add(new ListMenuViewItem("logon", "Image��̬����ͼ��IHttpHandler", "", "") { Tag = "demoCustomHttpResource" });

            grp1.Items.Add(new ListMenuViewItem("logon", "���Բ���", "", "") { Tag = "demoLoginAbsoluteLayout" });
            grp1.Items.Add(new ListMenuViewItem("logon", "��Բ���", "", "") { Tag = "demoLoginRelativeLayout" });

            grp1.Items.Add(new ListMenuViewItem("logon", "͸����", "", "") { Tag = "demoTransparent" });

            grp1.Items.Add(new ListMenuViewItem("logon", "˫�����", "", "") { Tag = "demoTwoWayScrolling" });
            grp1.Items.Add(new ListMenuViewItem("logon", "���� TagPageView �� Toolbar", "", "") { Tag = "demoTabToolbar" });
            grp1.Items.Add(new ListMenuViewItem("logon", "WebView�ؼ�����ҳ���õ�ʾ��", "", "") { Tag = "demoHtmlInteraction" });


            //��ListMenuViewGroup��ӵ���ǰ��ListMenuView��
            this.listMenuView1.Groups.Add(grp1);
        }

        //������ʾһ�����˵��û��ؼ������FilterView�ļ���
        userFilter filter;
        //����Dialog����ʱ��ѡ��
        DialogOptions filterOptions;

        //������ʾ�ڵײ��������û��ؼ������ShowDialog�ļ���
        SmobilerSamples.ShowDialog.userFooterDialog footerDialog;
        //����Dialog����ʱ��ѡ��
        DialogOptions footerDialogOptions;

        /// <summary>
        /// ����ListMenuView��Ԫ�ص���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Tag.ToString())
            {
                case "demoListViewRefresh":
                    //��ʾdemoListViewRefresh����
                    this.Show(new demoListViewRefresh());
                    break;
                case "userFilter":
                    //Dialog��ʾ���Զ���ؼ�������ظ�ʹ�ã�����Ҫÿһ�ζ�ʵ�����������Ҫʵ�������ǵð�ԭ���ĸ�Destroy
                    if (filter == null)
                    {
                        //�����ڲ�ʹ����Flex���֣���Ҫ���ⲿ�����߶�
                        filter = new userFilter();
                        filter.Height = 400;
                        filter.BackColor = System.Drawing.Color.White;

                        /* DialogOptions����˵��
                         * justifyAlign: LayoutJustifyAlign.FlexEnd ������ʾ��������
                         * backColor: System.Drawing.Color.FromArgb(128, 128, 128, 128) ����Dialog�ı���ɫ
                         * padding: Padding.Empty �����ڱ߿�Ϊ�գ�����ȫ����ʾ
                         * touchClosed: true �Ƿ����հ״��ر�
                         */
                        filterOptions = new DialogOptions(justifyAlign: LayoutJustifyAlign.FlexEnd, backColor: System.Drawing.Color.FromArgb(128, 128, 128, 128), padding: Padding.Empty, touchClosed: true);
                    }
                    //����filter
                    this.ShowDialog(filter, filterOptions);
                    break;
                case "userFooterDialog":
                    //Dialog��ʾ���Զ���ؼ�������ظ�ʹ�ã�����Ҫÿһ�ζ�ʵ�����������Ҫʵ�������ǵð�ԭ���ĸ�Destroy
                    if (footerDialog == null)
                    {
                        //�����ڲ��ؼ������˸߶ȣ�����userFooterDialog�������ø߶ȣ����Զ��Ŵ�
                        footerDialog = new SmobilerSamples.ShowDialog.userFooterDialog();

                        //ͬcase "userFilter":�еĲ����趨
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    //����footerDialog
                    this.ShowDialog(footerDialog, footerDialogOptions);
                    break;
                case "userDialogPassword":
                    if (footerDialogOptions == null)
                    {
                        //ͬcase "userFilter":�еĲ����趨
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    //����userDialogPassword�û��ؼ�ʵ��
                    ShowDialog.userDialogPassword dialogPassowrd = new ShowDialog.userDialogPassword();
                    //��DialogPassword�¼�
                    dialogPassowrd.DialogPassword += (pass) => { MessageBox.Show(pass); };
                    //����dialogPassowrd
                    this.ShowDialog(dialogPassowrd, footerDialogOptions);
                    break;
                case "demogetdata":
                    //����demogetdata�û��ؼ�ʵ��
                    demogetdata dm = new demogetdata();
                    //��demogetdata��Selected�¼�
                    dm.Selected += (obj, args) => { Toast(args.Text); };
                    //����Dialog
                    this.ShowDialog(dm);
                    break;
                case "demoWebView":
                    //��ʾdemoWebView����
                    this.Show(new demoWebView());
                    break;
                case "demoCustomResource":
                    //��ʾdemoCustomResource����
                    this.Show(new demoCustomResource());
                    break;
                case "demoCustomHttpResource":
                    this.Show(new demoCustomHttpResource());
                    break;
                case "demoLoginRelativeLayout":
                    //��ʾdemoLoginRelativeLayout����
                    this.Show(new demoLoginRelativeLayout());
                    break;
                case "demoLoginAbsoluteLayout":
                    //��ʾdemoLoginAbsoluteLayout����
                    this.Show(new demoLoginAbsoluteLayout());

                    break;
                case "demoTransparent":
                    //��ʾdemoLoginAbsoluteLayout����
                    this.Show(new demoTransparent());
                    break;

                case "demoTwoWayScrolling":
                    //��ʾdemoTwoWayScrolling����
                    this.Show(new demoTwoWayScrolling());
                    break;

                case "demoTabToolbar":
                    //��ʾdemoTabToolbar����
                    this.Show(new demoTabToolbar());
                    break;

                case "demoHtmlInteraction":
                    //��ʾdemoTabToolbar����
                    this.Show(new demoHtmlInteraction());
                    break;
                case "demoListViewUpdate":
                    this.Show(new demoListViewTemplateUpdate());
                    break;
            }

        }
    }
}