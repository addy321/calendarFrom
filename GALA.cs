using PMRL.RLSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PMRL
{
    public partial class GALA : Form
    {
        public GALA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            string text = this.textBox1.Text;
            if (text == "")
            {
                MessageBox.Show("请输入节日名称");
                return;
            }
            SQLiteSamples sQLite = new SQLiteSamples();
            sQLite.addJieRi(date.ToString("yyyyMMdd"),text);
            sQLite.printHighscores();
            sQLite.closeDatabase();
            MessageBox.Show("设置成功");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            SQLiteSamples sQLite = new SQLiteSamples();
            string content = sQLite.getJieRi(date);
            sQLite.closeDatabase();
            this.textBox1.Text = content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            SQLiteSamples sQLite = new SQLiteSamples();
            sQLite.delJieRi(date);
            sQLite.closeDatabase();
            this.textBox1.Text = "";
        }
    }
}
