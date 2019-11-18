using FidelityPension.Models.Core;
using FidelityPension.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;


namespace FidelityPension.Reports
{
    public partial class WelcomeLetter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //ReportViewer viewer = new ReportViewer();

                string searchText = string.Empty;

                if (Request.QueryString["searchText"] != null)
                {
                    searchText = Request.QueryString["searchText"].ToString();
                }

                List<EMPLOYEE> employee = null;
                using (var _context = new PfaDbContext1())
                {
                    employee = _context.EMPLOYEES.Where(t => t.PIN.Contains(searchText)).OrderBy(a => a.PIN).ToList();
                    WLReportViewer.LocalReport.ReportPath = Server.MapPath("http://fpmlwebsvr.fidelitypensionmanagers.com/thehub/branch_portal/reports/wl_new_format.rdlc");
                    WLReportViewer.LocalReport.DataSources.Clear();
                    ReportDataSource rdc = new ReportDataSource("new_wlDataSet", employee);
                    WLReportViewer.LocalReport.DataSources.Add(rdc);
                    ReportParameter[] rp = new ReportParameter[2];
                    rp[0] = new ReportParameter("report_pin", "");
                    rp[1] = new ReportParameter("pwdparam", "");
                    WLReportViewer.LocalReport.SetParameters(rp);
                    WLReportViewer.LocalReport.Refresh();
                    WLReportViewer.DataBind();
                }
            }
        }
    }
}