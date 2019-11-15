using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Schoolhub
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }     
        private string GetFileTypeByExtensions(string extensions)
        {
            switch (extensions.ToLower())
            {
                case ".doc":
                case ".docx":
                    return "MS Word Doc";
                case ".pdf":
                    return "PDF";
                case ".xlsx":
                case ".xls":
                    return "MS Excel Doc";
                case ".jpg":
                case ".png":
                    return "Image";
                default:
                    return "Unknown";


            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/200LDN/") + FileUpload1.FileName);
            }
            DataTable dd = new DataTable();
            dd.Columns.Add("File", typeof(string));
            dd.Columns.Add("Size", typeof(string));
            dd.Columns.Add("Type", typeof(string));
            foreach (string strFiles in Directory.GetFiles(Server.MapPath("~/200LDN/")))
            {
                FileInfo f = new FileInfo(strFiles);
                dd.Rows.Add(f.Name, f.Length, GetFileTypeByExtensions(f.Extension));
            }
            GridView1.DataSource = dd;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                Response.Clear();
                Response.ContentType = "application/octect-stream";
                Response.AppendHeader("content-disposition", "filename= " + e.CommandArgument);
                Response.TransmitFile(Server.MapPath("~/200LDN/") + e.CommandArgument);
                Response.End();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}