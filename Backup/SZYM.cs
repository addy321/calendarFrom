/************************************************************************************
*源码来自(C#源码世界)  www.HelloCsharp.com
*如果对该源码有问题可以直接点击下方的提问按钮进行提问哦
*站长将亲自帮你解决问题
*C#源码世界-找到你需要的C#源码，交流和学习
************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
//download by http://www.mycodes.net
namespace PMRL
{
    public partial class SZYM : Form
    {
        [DllImport("shell32.dll")]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
 
        string path;
        string exe_name;
        ZMRL parent;
        Struct_FormState state;
        public SZYM()
        {
            InitializeComponent();
        }

        public SZYM(ZMRL parent)
        {
            InitializeComponent();

            this.parent = parent;
            Data data = new Data();
            this.state = data.ReadFile(path);

            path = Application.ExecutablePath;
            exe_name = path.Substring(path.LastIndexOf("\\") + 1);
            path = path.Substring(0, path.LastIndexOf("\\") + 1);
            Init();
        }

        //初始化状态
        public void Init()
        {
            
            if (state.bool_tran)
            {
                btn_qxzmbj.Enabled = true;
                btn_swzmbj.Enabled = false;
            }
            else
            {
                btn_swzmbj.Enabled = true;
                btn_qxzmbj.Enabled = false;
            }
            if (state.bool_autorun)
            {
                btn_qxkjqd.Enabled = true;
                btn_swkjqd.Enabled = false;
            }
            else
            {
                btn_swkjqd.Enabled = true;
                btn_qxkjqd.Enabled = false;
            }
            if (state.bool_head)
            {
                btn_ycrqxz.Enabled = true;
                btn_xsrqxz.Enabled = false;
            }
            else
            {
                btn_xsrqxz.Enabled = true;
                btn_ycrqxz.Enabled = false;
            }
            if (state.bool_date)
            {
                btn_ycxxrl.Enabled = true;
                btn_xsxxrl.Enabled = false;
            }
            else
            {
                btn_xsxxrl.Enabled = true;
                btn_ycxxrl.Enabled = false;
            }
            if (state.bool_time)
            {
                btn_ycsjxs.Enabled = true;
                btn_xssjxs.Enabled = false;
            }
            else
            {
                btn_xssjxs.Enabled = true;
                btn_ycsjxs.Enabled = false;
            }
        }

        //预览
        private void btn_yl_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized || parent.Visible == false)
            {
                parent.Show();
                parent.WindowState = FormWindowState.Normal;
            }
            
        }
        //下载于 www.mycodes.net
        //确定
        private void btn_qd_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            //state = new Struct_FormState();
            state.point_x = parent.Location.X;
            state.point_y = parent.Location.Y;
            state.bool_head = parent.Controls["panel_head"].Visible;
            state.bool_date = parent.Controls["panel_date"].Visible;
            state.bool_time = parent.Controls["panel_time"].Visible;
            state.bool_autorun = data.IsRegistry(exe_name);
            if (parent.TransparencyKey == parent.BackColor && parent.BackgroundImage==null)
            {
                state.bool_tran = true;
            }
            else
            {
                state.bool_tran = false;
            }

            data.WriteFile(path, state);
            this.Hide();
            parent.Show();
            MessageBox.Show("设置成功！");
        }

        //设为桌面背景
        private void btn_swzmbj_Click(object sender, EventArgs e)
        {
            parent.TransparencyKey = this.BackColor;
            parent.FormBorderStyle = FormBorderStyle.None;
            parent.BackgroundImage = null;
            SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero); 
            btn_swzmbj.Enabled = false;
            btn_qxzmbj.Enabled = true;
            
        }

        //取消桌面背景
        private void btn_qxzmbj_Click(object sender, EventArgs e)
        {
            parent.FormBorderStyle = FormBorderStyle.FixedSingle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZMRL));
            parent.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            //parent.BackColor = Color.White;
            SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero); 
            btn_qxzmbj.Enabled = false;
            btn_swzmbj.Enabled = true;
            
        }
        //下载于 www.mycodes.net
        //设为开机启动
        private void btn_swkjqd_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            string path = Application.ExecutablePath;
            string name = path.Substring(path.LastIndexOf(@"\")+1);
            data.AutoRunWhenStrat(true, name, path);
            btn_swkjqd.Enabled = false;
            btn_qxkjqd.Enabled = true;
        }

        //取消开机启动
        private void btn_qxkjqd_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            string path = Application.ExecutablePath;
            string name = path.Substring(path.LastIndexOf(@"\") + 1);
            data.AutoRunWhenStrat(false, name, path);
            btn_qxkjqd.Enabled = false;
            btn_swkjqd.Enabled = true;
        }

        //隐藏日期选择
        private void btn_ycrqxz_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_head"].Visible = false;
            btn_ycrqxz.Enabled = false;
            btn_xsrqxz.Enabled = true;
            if (parent.panel_date.Visible)
            {
                parent.panel_date.Location = new Point(parent.panel_date.Location.X, parent.panel_main.Location.Y - 16);
            }
        }

        //显示日期选择
        private void btn_xsrqxz_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_head"].Visible = true;
            btn_xsrqxz.Enabled = false;
            btn_ycrqxz.Enabled = true;
            if (parent.panel_date.Visible)
            {
                parent.panel_date.Location = new Point(parent.panel_date.Location.X, parent.panel_head.Location.Y);
            }
        }

        //隐藏详细日历
        private void btn_ycxxrl_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_date"].Visible = false;
            btn_ycxxrl.Enabled = false;
            btn_xsxxrl.Enabled = true;
        }

        //显示详细日历
        private void btn_xsxxrl_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_date"].Visible = true;
            btn_xsxxrl.Enabled = false;
            btn_ycxxrl.Enabled = true;
            if (parent.panel_head.Visible)
            {
                parent.panel_date.Location = new Point(parent.panel_date.Location.X, parent.panel_head.Location.Y);
            }
            else
            {
                parent.panel_date.Location = new Point(parent.panel_date.Location.X, parent.panel_main.Location.Y - 16); 
            }
        }

        //隐藏时间显示
        private void btn_ycsjxs_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_time"].Visible = false;
            btn_ycsjxs.Enabled = false;
            btn_xssjxs.Enabled = true;
        }

        //显示时间显示
        private void btn_xssjxs_Click(object sender, EventArgs e)
        {
            parent.Controls["panel_time"].Visible = true;
            btn_xssjxs.Enabled = false;
            btn_ycsjxs.Enabled = true;
            
        }

        private void SZYM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data data = new Data();
            //state = new Struct_FormState();
            state.point_x = parent.Location.X;
            state.point_y = parent.Location.Y;
            state.bool_head = parent.Controls["panel_head"].Visible;
            state.bool_date = parent.Controls["panel_date"].Visible;
            state.bool_time = parent.Controls["panel_time"].Visible;
            state.bool_autorun = data.IsRegistry(exe_name);
            if (parent.TransparencyKey == parent.BackColor && parent.BackgroundImage == null)
            {
                state.bool_tran = true;
            }
            else
            {
                state.bool_tran = false;
            }

            data.WriteFile(path, state);
            this.Hide();
            parent.Show();
            
        }

    }
}
