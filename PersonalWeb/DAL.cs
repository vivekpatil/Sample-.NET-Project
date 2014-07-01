using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlServerCe;
using System.Configuration;

namespace PersonalWeb
{
    public class DAL_CE
    {
        public static string strConnection1;
        public static SqlCeConnection conn;

        public DAL_CE()
        {
            strConnection1 = ConfigurationManager.ConnectionStrings["Bug_Monitor"].ConnectionString;
            conn = new SqlCeConnection(strConnection1);
        }

        public Boolean CreateDefect(string pName, string pDescription, string pType, string pSeverity, string pPriority, string pRaisedBy, DateTime dtLoggedAt,
            string pComments, string pSubject, string pAttachment)
        {
            int iDefect_id = fnGetDefectID();
            int iResult = 0;
            Boolean retValue = false;
            //In line queries since SQL Compact edition does not offer stored procedures - Create defect code
            string strCommand = "Insert into dtDefects(Defect_Name,Defect_Description,Defect_Type,Defect_Severity,Defect_Priority,Defect_Raised_By,Defect_Logged_Date,Defect_Comments,Defect_Subject,Defect_Attachment)";
            strCommand = strCommand + " Values ('" + pName + "','" + pDescription + "','" + pType + "','" + pSeverity + "','" + pPriority + "','" + pRaisedBy + "','" + dtLoggedAt.ToString() + "','" + pComments + "','" + pSubject + "','" + pAttachment + "')";
            try
            {
                SqlCeCommand Sqlcmd = new SqlCeCommand(strCommand, conn);
                conn.Open();
                iResult = Sqlcmd.ExecuteNonQuery();
                if (iResult != 0)
                {
                    retValue = true;
                }

                return retValue;
            }
            catch (SqlCeException sqlEx)
            {
                return retValue;
            }
            catch (Exception ex)
            {
                return retValue;
            }
            finally
            {
                conn.Close();
            }
        }

        private int fnGetDefectID()
        {
            int iCount = 0;
            string strCommand = "SELECT COUNT(Defect_ID) FROM dtDefects";
            try
            {
                SqlCeCommand Sqlcmd = new SqlCeCommand(strCommand, conn);
                conn.Open();
                iCount = Convert.ToInt32(Sqlcmd.ExecuteScalar());
                return iCount;
            }
            catch (SqlCeException sqlEx)
            {
                return iCount;
            }
            catch (Exception ex)
            {
                return iCount;
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}