using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;
using SqlSugarDemo.Entity;
using SqlSugarDemo.IRepository;
using SqlSugarDemo.Repository;

using SqlSugarDemo.WinForm1._02_Common;

namespace SqlSugarDemo.WinForm1
{
    public partial class Form1 : Form
    {
        #region Property
        ICustomersRepository CustomersRepository { get { return new CustomersRepository(); } }
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ls = CustomersRepository.QueryAll();

            Tool.FillListView(ls, myListView1);
        }
    }
}
