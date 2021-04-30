
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PMRL.RLSQLite;

namespace PMRL
{
    public partial class ZMRL : Form
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        //下面是可用的常量，根据不同的动画效果声明自己需要的
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展
        private const int AW_HIDE = 0x10000;//隐藏窗口
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果
        


        bool boolyear = false;
        bool boolmonth = false;
        public Struct_FormState state;

        public ZMRL()
        {

            this.DoubleBuffered = true;//设置本窗体
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);




            Data data = new Data();

            InitializeComponent();
            blind();
            CreatCalendar(Convert.ToInt32(cbb_year.SelectedValue), Convert.ToInt32(cbb_month.SelectedValue));
            boolyear = true;
            boolmonth = true;
            InitCalendar();
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            //对当前时间的初始化
            timer_time.Start();
            timer_time.Interval = 1000;


            #region 窗体初始状态的判断
            string path = Application.ExecutablePath;
            string name = path.Substring(path.LastIndexOf("\\") + 1);
            path = path.Substring(0, path.LastIndexOf("\\") + 1);

            if (data.IsExistFile(path))
            {
               
                state = data.ReadFile(path);
                if (state.bool_head)
                {
                    panel_head.Visible = true;
                }
                else
                {
                    panel_head.Visible = false;
                }

                if (!state.bool_date)
                {
                    panel_date.Visible = false;
                }
                else if (state.bool_date && state.bool_head)
                {
                    panel_date.Visible = true;
                    panel_date.Location = new Point(panel_date.Location.X, panel_head.Location.Y);
                }
                else if (state.bool_date && !state.bool_head)
                {
                    panel_date.Visible = true;
                    panel_date.Location = new Point(panel_date.Location.X, panel_main.Location.Y-16);
                }

                if (state.bool_time)
                {
                    panel_time.Visible = true;
                }
                else
                {
                    panel_time.Visible = false;
                }
                if (state.bool_tran)
                {
                    this.TransparencyKey = this.BackColor;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.BackgroundImage = null;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZMRL));
                    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage"))); 
                }

                this.Location = new Point(state.point_x, state.point_y);
            }
            else
            {
                state = new Struct_FormState();
                state.point_x = 0;
                state.point_y = 0;
                state.bool_head = true;
                state.bool_date = true;
                state.bool_time = true;
                state.bool_autorun = false;

                data.WriteFile(path, state);
            }

            #endregion


            this.panel_main.BackColor = Color.Transparent;
            this.panel_calendara.BackColor = Color.Transparent;
            this.panel_date.BackColor = Color.Transparent;
            this.panel_head.BackColor = Color.Transparent;
            this.panel_time.BackColor = Color.Transparent;


        }

        //初始化
        public void InitCalendar()
        {
            Data data = new Data();
            DateTime currenttime = DateTime.Now;
            int year=currenttime.Year;
            int month=currenttime.Month;
            int day=currenttime.Day;

            //初始化当前公历日历
            lbl_Date_gl.Text = DateTime.Now.ToLongDateString().ToString()+"  "+data.GetWeekOfDay(year,month,day);
            lbl_day_gl.Text = currenttime.Day.ToString();
            //初始化当前农历日历
            lbl_month_day_nl.Text=data.GetNLMonth(year,month,day)+""+data.GetNLDay(year,month,day)+"日";
            lbl_year_nl.Text = data.GetNLYear(year,month,day);
            lbl_xz.Text = data.GetConstellation(month, day); // 设置星座

            SQLiteSamples sQLite = new SQLiteSamples();
            string monthstr = "" + month;
            if (month < 10)
            {
                monthstr = "0" + month;
            }
            string daystr = "" + day;
            if (day < 10)
            {
                daystr = "0" + day;
            }
            string date = year + monthstr + daystr;
            label_jieri.Text = sQLite.getJieRi(date);//设置节日
            richTextBox1.Text = sQLite.getTixing(date);// 设置提醒
            sQLite.closeDatabase();
        }
        //恢复日历控件
        public void RecoverCalendar(object sender, EventArgs e)
        {
            Data data = new Data();
            DateTime currenttime = DateTime.Now;
            int year = currenttime.Year;
            int month = currenttime.Month;
            int day = currenttime.Day;

            //初始化当前公历日历
            lbl_Date_gl.Text = DateTime.Now.ToLongDateString().ToString() + "  " + data.GetWeekOfDay(year, month, day);

            

            lbl_day_gl.Text =currenttime.Day.ToString();
            //初始化当前农历日历
            lbl_month_day_nl.Text = data.GetNLMonth(year, month, day) + "" + data.GetNLDay(year, month, day) + "日";
            lbl_year_nl.Text = data.GetNLYear(year, month, day);
            lbl_xz.Text = data.GetConstellation(month, day);// 设置星座

            SQLiteSamples sQLite = new SQLiteSamples();
            string monthstr = "" + month;
            if (month < 10)
            {
                monthstr = "0" + month;
            }
            string daystr = "" + day;
            if (day < 10)
            {
                daystr = "0" + day;
            }
            string date = year + monthstr + daystr;
            label_jieri.Text = sQLite.getJieRi(date);//设置节日
            richTextBox1.Text = sQLite.getTixing(date);// 设置提醒
            sQLite.closeDatabase();
        }

        //根据年月日设置日历控件
        public void SetCalendar(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cbb_year.SelectedValue);
            int month = Convert.ToInt32(cbb_month.SelectedValue);
            int day = Convert.ToInt32(((Label)sender).Text);
            Data data = new Data();
            DateTime currenttime = new DateTime(year,month,day);

            //设置当前公历日历
            lbl_Date_gl.Text = year+"年"+month+"月"+day+"日"+ "  " + data.GetWeekOfDay(year, month, day);
            lbl_day_gl.Text =currenttime.Day.ToString();

            //设置当前农历日历
            lbl_month_day_nl.Text = data.GetNLMonth(year, month, day) + "" + data.GetNLDay(year, month, day) + "日";
            lbl_year_nl.Text = data.GetNLYear(year, month, day);
            lbl_xz.Text = data.GetConstellation(month, day); // 设置星座

            SQLiteSamples sQLite = new SQLiteSamples();
            string monthstr = ""+ month;
            if (month < 10) {
                monthstr = "0" + month;
            }
            string daystr = "" + day;
            if (day < 10)
            {
                daystr = "0" + day;
            }
            string date = year + monthstr + daystr;
            label_jieri.Text = sQLite.getJieRi(date);//设置节日
            richTextBox1.Text = sQLite.getTixing(date);// 设置提醒
            sQLite.closeDatabase();

        }
        //动态生成当年月的日历
        public void CreatCalendar(int year,int month)
        {
            lbl_year.Text = year.ToString();
            lbl_month.Text = month.ToString();

            DateTime currenttime = DateTime.Now; 
            Data data = new Data();
            int totaldayofmonth = data.GetMonthCount(year,month);
            //公历日
            Label[] lbl_array_gl = new Label[totaldayofmonth];
            for (int k = 0; k < totaldayofmonth; k++)
            {
                lbl_array_gl[k] = new Label();
                lbl_array_gl[k].Text = (k + 1).ToString();
                lbl_array_gl[k].Name = "lbl_gl" + (k + 1).ToString();
            }
            //农历日
            Label[] lbl_array_nl = new Label[totaldayofmonth];
            for (int q = 0; q < totaldayofmonth; q++)
            {
                lbl_array_nl[q] = new Label();
                lbl_array_nl[q].Name = "lbl_nl" + (q + 1).ToString();
            }
            int firstdayofweekofmonth = data.FirstDayOfWeekOfMonth(year,month);
            int index = 0;
            for (int i = 0; i <6; i++)
            {
                for (int j = 0; j <7; j++)
                {
                    if (i == 0 && j < firstdayofweekofmonth)
                    {}
                    else
                    {
                        if (index < totaldayofmonth)
                        {
                            this.panel_calendara.Controls.Add(lbl_array_gl[index]);
                            this.panel_calendara.Controls.Add(lbl_array_nl[index]);
                            lbl_array_gl[index].AutoSize = true;
                            
                            lbl_array_gl[index].Location = new Point(38 * j + 15, i * 36 + 10);
                            lbl_array_gl[index].MouseHover += new EventHandler(SetCalendar);
                            lbl_array_gl[index].MouseLeave += new EventHandler(RecoverCalendar);
                            lbl_array_gl[index].BackColor = Color.Transparent;

                            lbl_array_nl[index].AutoSize = true;
                            lbl_array_nl[index].Text = data.GetNLDay(year,month,Convert.ToInt32(lbl_array_gl[index].Text));
                            lbl_array_nl[index].Location = new Point(38 * j + 5, i * 36 + 25);
                            lbl_array_nl[index].BackColor = Color.Transparent;

                            if (j == 6 || j == 0)
                            {
                                lbl_array_gl[index].ForeColor =Color.Red;
                            }
                            if ((new DateTime(year, month, Convert.ToInt32(lbl_array_gl[index].Text))).ToShortDateString() == DateTime.Now.ToShortDateString())
                            {
                                lbl_array_gl[index].BackColor = Color.LightSeaGreen;
                            }
                            index++;
                        }
                    }
                }
            }
        }
        //绑定年月的下拉框
        public void blind()
        {
            
            Data data=new Data();
            cbb_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_year.DataSource= data.Year();
            cbb_year.Text= DateTime.Now.Year.ToString();
            
            //cbb_year.Show();
            cbb_month.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_month.DataSource = data.Month();
            cbb_month.Text = DateTime.Now.Month.ToString();
        }
        //日期往前翻滚
        private void pre_Click(object sender, EventArgs e)
        {
            if (cbb_year.SelectedIndex >= 0)
            {
                if (cbb_month.SelectedIndex != 0)
                {
                    cbb_month.SelectedIndex--;
                }
                else
                {
                    if (cbb_year.SelectedIndex != 0)
                    {
                        cbb_month.SelectedIndex = cbb_month.Items.Count - 1;
                        cbb_year.SelectedIndex--;
                    }
                }
            }

        }
        //日期往后翻滚
        private void back_Click(object sender, EventArgs e)
        {
            if (cbb_year.SelectedIndex <= cbb_year.Items.Count-1)
            {
                if (cbb_month.SelectedIndex != cbb_month.Items.Count - 1)
                {
                    cbb_month.SelectedIndex++;
                }
                else
                {
                    if (cbb_year.SelectedIndex != cbb_year.Items.Count - 1)
                    {
                        cbb_month.SelectedIndex = 0;
                        cbb_year.SelectedIndex++;
                    }
                }
            }
        }
        //年份下拉框变化
        private void cbb_year_TextChanged(object sender, EventArgs e)
        {
            if (boolyear)
            {

                this.panel_calendara.Visible = false;
                panel_calendara.Controls.Clear();
                CreatCalendar(Convert.ToInt32(cbb_year.SelectedValue), Convert.ToInt32(cbb_month.SelectedValue));
                System.Threading.Thread.Sleep(500);
                this.panel_calendara.Visible = true;
            }
        }
        //月份下拉框变化
        private void cbb_month_TextChanged(object sender, EventArgs e)
        {
            if (boolmonth)
            {
                this.panel_calendara.Visible = false;
                panel_calendara.Controls.Clear();
                CreatCalendar(Convert.ToInt32(cbb_year.SelectedValue), Convert.ToInt32(cbb_month.SelectedValue));
                System.Threading.Thread.Sleep(500);
                this.panel_calendara.Visible = true;
                AnimateWindow(this.panel_calendara.Handle, 1000, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_NEGATIVE);
            }
        }
        //当前时间的显示
        private void timer_time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        //双击系统图盘还原
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
            {
                
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            AnimateWindow(this.Handle, 1000, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_NEGATIVE);
        }

        //最小化到系统托盘
        private void ZMRL_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }

        }
        //设置
        private void tsmi_sz_Click(object sender, EventArgs e)
        {
            SZYM szym = new SZYM(this);
            szym.Show();
            this.Hide();
        }

        //退出
        private void tsmi_tc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem_jieri_Click(object sender, EventArgs e)
        {
            GALA gala = new GALA();
            gala.Show();
        }

        private void toolStripMenuItem_warn_Click(object sender, EventArgs e)
        {
            REMIND remind = new REMIND();
            remind.Show();
        }
    }
}
