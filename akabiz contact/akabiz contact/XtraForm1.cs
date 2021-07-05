using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using akabiz_contact.DataSet1TableAdapters;

namespace akabiz_contact
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        ContactTableAdapter kh = new ContactTableAdapter();
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int? t = int.Parse(textBox6.Text);
            kh.Insert(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, t, null);
            MessageBox.Show("Thêm thành công (^-^)");
            this.Close();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}