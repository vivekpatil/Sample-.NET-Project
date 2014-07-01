using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


namespace PersonalWeb
{
    public partial class Bug_Log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                txtLoggedDate.Text = System.DateTime.Now.ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Exception exCustom = new Exception("Defect not created");
            Boolean isInserted = false;
            DAL_CE DataAccessLayer = new DAL_CE();
            string strDefName = txtName.Text;
            string strDefDesc = txtDescription.Text;
            string strType = txtType.Text;
            string strSeverity = DropDownList1.SelectedValue.ToString();
            string strPriority = DropDownList2.SelectedValue.ToString();
            string strRaisedBy = txtRaisedBy.Text;
            DateTime dtLogged = System.DateTime.Now;
            string strComments = txtComments.Text;
            string strSubject = txtSubject.Text;
            string strAttachment = fileUpload.FileName.ToString();

            try
            {
                isInserted = DataAccessLayer.CreateDefect(strDefName, strDefDesc, strType, strSeverity, strPriority, strRaisedBy, dtLogged, strComments, strSubject, strAttachment);
                if (isInserted)
                {
                    //Upload the attachment to the attachment folder
                    if (strAttachment != "" || strAttachment != null)
                        fileUpload.SaveAs(Server.MapPath("/_attachments/") + strAttachment);
                    lblResult.Text = "Defect created Successfully!";
                }
                else
                {
                    throw exCustom;
                }
            }
            catch(Exception ex)
            {
                lblResult.Text = ex.Message.ToString();
            }
        }
    }
}