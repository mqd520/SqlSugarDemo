using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.Common;

using Common;
using SqlSugarDemo.Entity;
using SqlSugarDemo.IRepository;
using SqlSugarDemo.Repository;
using MySql.Data.MySqlClient;

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
            //string sql = "select * from Customers";
            //var dt = MySqlDb.GetTable(sql, null);
        }


        #region Query
        private void button1_Click(object sender, EventArgs e)
        {
            var ls = new List<Customers>();
            var customer = CustomersRepository.QuerySingleById<string>("ANTON");
            ls.Add(customer);

            Tool.FillListView(ls, myListView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ls = new List<Customers>();
            var customer = CustomersRepository.QuerySingle(x => x.CompanyName == "Blauer See Delikatessen");
            ls.Add(customer);

            Tool.FillListView(ls, myListView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ls = new List<Customers>();
            var wheres = new List<Expression<Func<Customers, bool>>>();
            wheres.Add(x => x.Country == "USA");
            wheres.Add(x => x.ContactName == "Howard Snyder");
            var customer = CustomersRepository.QuerySingle(wheres);
            ls.Add(customer);

            Tool.FillListView(ls, myListView1);
        }
        #endregion

        private async void button4_Click(object sender, EventArgs e)
        {
            //var ls = new List<Customers>();
            //var customer = await CustomersRepository.QuerySingleByIdAsync<string>("ALFKI");
            //ls.Add(customer);

            //Tool.FillListView(ls, myListView1);


            string sql = "select * from Customers";
            var dt = await MySqlDb.GetTableAsync(sql, null);
        }

        private async Task TestAsync()
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(3 * 1000);
            });
        }
    }
}
