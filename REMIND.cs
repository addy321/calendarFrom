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
    public partial class REMIND : Form
    {
        public REMIND()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Value.ToString("yyyyMMdd");
            string text = this.richTextBox1.Text;
            if (text == "")
            {
                MessageBox.Show("请输入提示内容");
                return;
            }

            SQLiteSamples sQLite = new SQLiteSamples();
            sQLite.addTixing(date, text);
            sQLite.closeDatabase();
            MessageBox.Show("设置成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            SQLiteSamples sQLite = new SQLiteSamples();
            sQLite.delTixing(date);
            sQLite.closeDatabase();
            this.richTextBox1.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            SQLiteSamples sQLite = new SQLiteSamples();
            string content = sQLite.getTixing(date);
            sQLite.closeDatabase();
            this.richTextBox1.Text = content;
        }
    }
}
