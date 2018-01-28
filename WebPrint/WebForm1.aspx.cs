using FastReport;
using FastReport.Export.Image;
using FastReport.Export.Pdf;
using FastReport.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPrint
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Method1();
            //Method2();
        }

        //获取数据源
        private DataSet GetDataSet()
        {
            string content = File.ReadAllText(Server.MapPath("~/Data.json"));
            return JsonConvert.DeserializeObject<DataSet>(content);
        }

        #region 方式一
        /* 用该方法需要在 WebConfig里增加以下代码
          <assemblies>
            <add assembly="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089" />
          </assemblies>
         */

        private void Method1()
        {
            WebReport1.ReportFile = @"BatchPurchase.frx";
            WebReport1.RtfAutoSize = true;
            WebReport1.AutoHeight = true;
            WebReport1.AutoWidth = true;
            WebReport1.Prepare();
        }

        protected void WebReport1_StartReport(object sender, EventArgs e)
        {
            Report FReport = (sender as WebReport).Report;
            FReport.RegisterData(GetDataSet());
        }

        #endregion

        #region 方式二

        private void Method2()
        {
            #region 加载打印模板
            Report report = new Report();
            report.Load(Server.MapPath("~/BatchPurchase.frx"));
            report.RegisterData(GetDataSet());
            report.Show();
            report.Prepare();

            #region 导出打印结果图片
            string filePath = @"D:\TEMP\1.jpg";
            ImageExport export = new ImageExport();
            report.Export(export, filePath);

            #endregion

            #region 导出PDF
            string pdfFilePath = @"D:\TEMP\1.pdf";
            PDFExport pdfExport = new PDFExport();
            report.Export(pdfExport, pdfFilePath);
            #endregion

            //using (MemoryStream strm = new MemoryStream())
            //{
            //    report.Export(pdfExport, strm);

            //    // Stream the PDF back to the client as an attachment
            //    Response.ClearContent();
            //    Response.ClearHeaders();
            //    Response.Buffer = true;
            //    Response.ContentType = "Application/PDF";
            //    Response.AddHeader("Content-Disposition", "attachment;filename=report.pdf");

            //    strm.Position = 0;
            //    strm.WriteTo(Response.OutputStream);
            //    Response.End();
            //}
            //report.Show();
            #endregion
        }

        #endregion

    }
}