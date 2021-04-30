namespace PMRL
{
    partial class ZMRL
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZMRL));
            this.panel_main = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.panel_calendara = new System.Windows.Forms.Panel();
            this.lbl_liu = new System.Windows.Forms.Label();
            this.lbl_wu = new System.Windows.Forms.Label();
            this.lbl_si = new System.Windows.Forms.Label();
            this.lbl_san = new System.Windows.Forms.Label();
            this.lbl_er = new System.Windows.Forms.Label();
            this.lbl_yi = new System.Windows.Forms.Label();
            this.lbl_ri = new System.Windows.Forms.Label();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.年 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.panel_date = new System.Windows.Forms.Panel();
            this.lbl_year_nl = new System.Windows.Forms.Label();
            this.lbl_month_day_nl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_day_gl = new System.Windows.Forms.Label();
            this.lbl_Date_gl = new System.Windows.Forms.Label();
            this.panel_time = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.nf_xtyp = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_sz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tc = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.panel_date.SuspendLayout();
            this.panel_time.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.lbl_month);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.lbl_year);
            this.panel_main.Controls.Add(this.panel_calendara);
            this.panel_main.Controls.Add(this.lbl_liu);
            this.panel_main.Controls.Add(this.lbl_wu);
            this.panel_main.Controls.Add(this.lbl_si);
            this.panel_main.Controls.Add(this.lbl_san);
            this.panel_main.Controls.Add(this.lbl_er);
            this.panel_main.Controls.Add(this.lbl_yi);
            this.panel_main.Controls.Add(this.lbl_ri);
            this.panel_main.Location = new System.Drawing.Point(27, 56);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(280, 253);
            this.panel_main.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(235, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "月";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_month.Location = new System.Drawing.Point(215, 14);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(26, 16);
            this.lbl_month.TabIndex = 4;
            this.lbl_month.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(167, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "年";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_year.Location = new System.Drawing.Point(128, 14);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(44, 16);
            this.lbl_year.TabIndex = 2;
            this.lbl_year.Text = "0000";
            // 
            // panel_calendara
            // 
            this.panel_calendara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_calendara.Location = new System.Drawing.Point(0, 70);
            this.panel_calendara.Name = "panel_calendara";
            this.panel_calendara.Size = new System.Drawing.Size(280, 183);
            this.panel_calendara.TabIndex = 1;
            // 
            // lbl_liu
            // 
            this.lbl_liu.AutoSize = true;
            this.lbl_liu.ForeColor = System.Drawing.Color.Red;
            this.lbl_liu.Location = new System.Drawing.Point(243, 50);
            this.lbl_liu.Name = "lbl_liu";
            this.lbl_liu.Size = new System.Drawing.Size(17, 12);
            this.lbl_liu.TabIndex = 0;
            this.lbl_liu.Text = "六";
            // 
            // lbl_wu
            // 
            this.lbl_wu.AutoSize = true;
            this.lbl_wu.Location = new System.Drawing.Point(205, 50);
            this.lbl_wu.Name = "lbl_wu";
            this.lbl_wu.Size = new System.Drawing.Size(17, 12);
            this.lbl_wu.TabIndex = 0;
            this.lbl_wu.Text = "五";
            // 
            // lbl_si
            // 
            this.lbl_si.AutoSize = true;
            this.lbl_si.Location = new System.Drawing.Point(167, 50);
            this.lbl_si.Name = "lbl_si";
            this.lbl_si.Size = new System.Drawing.Size(17, 12);
            this.lbl_si.TabIndex = 0;
            this.lbl_si.Text = "四";
            // 
            // lbl_san
            // 
            this.lbl_san.AutoSize = true;
            this.lbl_san.Location = new System.Drawing.Point(129, 50);
            this.lbl_san.Name = "lbl_san";
            this.lbl_san.Size = new System.Drawing.Size(17, 12);
            this.lbl_san.TabIndex = 0;
            this.lbl_san.Text = "三";
            // 
            // lbl_er
            // 
            this.lbl_er.AutoSize = true;
            this.lbl_er.Location = new System.Drawing.Point(91, 50);
            this.lbl_er.Name = "lbl_er";
            this.lbl_er.Size = new System.Drawing.Size(17, 12);
            this.lbl_er.TabIndex = 0;
            this.lbl_er.Text = "二";
            // 
            // lbl_yi
            // 
            this.lbl_yi.AutoSize = true;
            this.lbl_yi.Location = new System.Drawing.Point(53, 50);
            this.lbl_yi.Name = "lbl_yi";
            this.lbl_yi.Size = new System.Drawing.Size(17, 12);
            this.lbl_yi.TabIndex = 0;
            this.lbl_yi.Text = "一";
            // 
            // lbl_ri
            // 
            this.lbl_ri.AutoSize = true;
            this.lbl_ri.ForeColor = System.Drawing.Color.Red;
            this.lbl_ri.Location = new System.Drawing.Point(15, 50);
            this.lbl_ri.Name = "lbl_ri";
            this.lbl_ri.Size = new System.Drawing.Size(17, 12);
            this.lbl_ri.TabIndex = 0;
            this.lbl_ri.Text = "日";
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(11, 25);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(18, 18);
            this.btn_pre.TabIndex = 1;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.pre_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(241, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(18, 18);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = ">";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.back_Click);
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(55, 23);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(50, 20);
            this.cbb_year.TabIndex = 3;
            this.cbb_year.TextChanged += new System.EventHandler(this.cbb_year_TextChanged);
            // 
            // cbb_month
            // 
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(142, 22);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(50, 20);
            this.cbb_month.TabIndex = 4;
            this.cbb_month.TextChanged += new System.EventHandler(this.cbb_month_TextChanged);
            // 
            // 年
            // 
            this.年.AutoSize = true;
            this.年.Location = new System.Drawing.Point(109, 28);
            this.年.Name = "年";
            this.年.Size = new System.Drawing.Size(17, 12);
            this.年.TabIndex = 5;
            this.年.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "月";
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.btn_back);
            this.panel_head.Controls.Add(this.label2);
            this.panel_head.Controls.Add(this.btn_pre);
            this.panel_head.Controls.Add(this.年);
            this.panel_head.Controls.Add(this.cbb_year);
            this.panel_head.Controls.Add(this.cbb_month);
            this.panel_head.Location = new System.Drawing.Point(27, 6);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(280, 52);
            this.panel_head.TabIndex = 7;
            // 
            // panel_date
            // 
            this.panel_date.Controls.Add(this.lbl_year_nl);
            this.panel_date.Controls.Add(this.lbl_month_day_nl);
            this.panel_date.Controls.Add(this.label6);
            this.panel_date.Controls.Add(this.lbl_day_gl);
            this.panel_date.Controls.Add(this.lbl_Date_gl);
            this.panel_date.Location = new System.Drawing.Point(313, 6);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(169, 193);
            this.panel_date.TabIndex = 8;
            // 
            // lbl_year_nl
            // 
            this.lbl_year_nl.AutoSize = true;
            this.lbl_year_nl.Location = new System.Drawing.Point(27, 167);
            this.lbl_year_nl.Name = "lbl_year_nl";
            this.lbl_year_nl.Size = new System.Drawing.Size(71, 12);
            this.lbl_year_nl.TabIndex = 4;
            this.lbl_year_nl.Text = "000 000 000";
            // 
            // lbl_month_day_nl
            // 
            this.lbl_month_day_nl.AutoSize = true;
            this.lbl_month_day_nl.Location = new System.Drawing.Point(72, 145);
            this.lbl_month_day_nl.Name = "lbl_month_day_nl";
            this.lbl_month_day_nl.Size = new System.Drawing.Size(29, 12);
            this.lbl_month_day_nl.TabIndex = 3;
            this.lbl_month_day_nl.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "农历";
            // 
            // lbl_day_gl
            // 
            this.lbl_day_gl.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_day_gl.Location = new System.Drawing.Point(61, 72);
            this.lbl_day_gl.Name = "lbl_day_gl";
            this.lbl_day_gl.Size = new System.Drawing.Size(75, 48);
            this.lbl_day_gl.TabIndex = 1;
            this.lbl_day_gl.Text = "00";
            // 
            // lbl_Date_gl
            // 
            this.lbl_Date_gl.AutoSize = true;
            this.lbl_Date_gl.Location = new System.Drawing.Point(27, 28);
            this.lbl_Date_gl.Name = "lbl_Date_gl";
            this.lbl_Date_gl.Size = new System.Drawing.Size(131, 12);
            this.lbl_Date_gl.TabIndex = 0;
            this.lbl_Date_gl.Text = "0000年00月00日 星期几";
            // 
            // panel_time
            // 
            this.panel_time.Controls.Add(this.label1);
            this.panel_time.Controls.Add(this.lbl_time);
            this.panel_time.Location = new System.Drawing.Point(313, 231);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(169, 78);
            this.panel_time.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前时间:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_time.Location = new System.Drawing.Point(60, 58);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(97, 19);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00:00";
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // nf_xtyp
            // 
            this.nf_xtyp.ContextMenuStrip = this.contextMenuStrip1;
            this.nf_xtyp.Icon = ((System.Drawing.Icon)(resources.GetObject("nf_xtyp.Icon")));
            this.nf_xtyp.Text = "桌面日历";
            this.nf_xtyp.Visible = true;
            this.nf_xtyp.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_sz,
            this.tsmi_tc});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            this.contextMenuStrip1.Text = "设置";
            // 
            // tsmi_sz
            // 
            this.tsmi_sz.Name = "tsmi_sz";
            this.tsmi_sz.Size = new System.Drawing.Size(94, 22);
            this.tsmi_sz.Text = "设置";
            this.tsmi_sz.Click += new System.EventHandler(this.tsmi_sz_Click);
            // 
            // tsmi_tc
            // 
            this.tsmi_tc.Name = "tsmi_tc";
            this.tsmi_tc.Size = new System.Drawing.Size(94, 22);
            this.tsmi_tc.Text = "退出";
            this.tsmi_tc.Click += new System.EventHandler(this.tsmi_tc_Click);
            // 
            // ZMRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 338);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.panel_date);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZMRL";
            this.Text = "ZMRL";
            this.SizeChanged += new System.EventHandler(this.ZMRL_SizeChanged);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.panel_time.ResumeLayout(false);
            this.panel_time.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.Button btn_pre;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.ComboBox cbb_year;
        public System.Windows.Forms.ComboBox cbb_month;
        public System.Windows.Forms.Label 年;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_ri;
        public System.Windows.Forms.Label lbl_liu;
        public System.Windows.Forms.Label lbl_wu;
        public System.Windows.Forms.Label lbl_si;
        public System.Windows.Forms.Label lbl_san;
        public System.Windows.Forms.Label lbl_er;
        public System.Windows.Forms.Label lbl_yi;
        public System.Windows.Forms.Panel panel_calendara;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_month;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_year;
        public System.Windows.Forms.Panel panel_head;
        public System.Windows.Forms.Panel panel_date;
        public System.Windows.Forms.Label lbl_Date_gl;
        public System.Windows.Forms.Label lbl_year_nl;
        public System.Windows.Forms.Label lbl_month_day_nl;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_day_gl;
        public System.Windows.Forms.Panel panel_time;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Timer timer_time;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NotifyIcon nf_xtyp;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem tsmi_sz;
        public System.Windows.Forms.ToolStripMenuItem tsmi_tc;
        public System.ComponentModel.ComponentResourceManager resources;
        private System.ComponentModel.IContainer components; 

    }
}