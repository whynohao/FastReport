using FastReport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //获取数据源
        private DataSet GetDataSet()
        {
            string content = File.ReadAllText("Data.json");
            return JsonConvert.DeserializeObject<DataSet>(content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打印报表数据源
            //DataSet dataSet = new WS.PrintReportSoapClient().BatchProof("CowboyBatchProofPurchase");
            //string content = JsonConvert.SerializeObject(dataSet);
            //File.WriteAllText("Data.json", content);
            DataSet dataSet = GetDataSet();

            //创建打印报表对象
            Report report = new Report();

            //加载打印模板
            report.Load(@"BatchPurchase.frx");

            //注册打印数据
            report.RegisterData(dataSet);
            foreach (DataTable dt in dataSet.Tables)
            {
                //当设计打印模板时，设定数据源中的数据表显示
                report.GetDataSource(dt.TableName).Enabled = true;
            }

            //打印设计
            report.Design();

            //打印预览
            report.Show();

            //直接打印
            report.Print();
        }
    }
}
