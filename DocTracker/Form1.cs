using DocTracker.BLL;
using DocTracker.DAL;
using DocTracker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocTracker
{
    public partial class Form1 : Form
    {
        //private MainContext db = new MainContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateANewOffDoc();
        }

        private void CreateANewOffDoc()
        {
            var newDoc = new Doc
            {
                YearNumber = 2018,
                ReceiveDate = new DateTime(2018, 1, 1, 0, 0, 0),
                DocNumber = "测试自动[2018]1号",
                SecretLv = SecretLevel.NormalSecret,
                Copies = 50,
                Title = "测试自动生成公文",
                SendDate = new DateTime(2018, 5, 1, 11, 59, 59),
                Scope = "测试组only",
                Remark = "测试备注"
            };
            DocCtrl.Add(newDoc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doc lastDoc = DocCtrl.Last();
            MessageBox.Show(lastDoc.Title + lastDoc.ID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show all doc
            List<Doc> docs = DocCtrl.List();
            string result = "";
            docs.ForEach(doc =>
            {
                result += doc.ID + "\n";
            });
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DocCtrl.Delete(22).ToString());
            //MessageBox.Show(DocCtrl.Delete(3).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show((db.OffDocs.Find(22) == null).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var doc = DocCtrl.Find(1);
        }
    }
}
