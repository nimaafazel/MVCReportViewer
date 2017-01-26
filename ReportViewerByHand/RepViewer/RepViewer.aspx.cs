using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Microsoft.Reporting.WebForms;

namespace ReportViewerByHand.RepViewer
{
    public partial class RepViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // check the parameters to see which report are we going to show
                string param = Request["repLoc"];

                // load the report after the page loads
                if (!string.IsNullOrEmpty(param))
                {
                    if (param == "local")
                        showLocalReport();
                    if (param == "remote")
                        showRemoteReport();
                }                               
            }
            
        }

        private void showRemoteReport()
        {
            try
            {
                // report url
                string urlReportServer = "http://05505337DT/ReportServer";

                // processing mode
                rptViewer.ProcessingMode = ProcessingMode.Remote;

                // set the report server url
                rptViewer.ServerReport.ReportServerUrl = new Uri(urlReportServer);

                // setting report path
                // passing the report path with report name, no need to add report extension
                rptViewer.ServerReport.ReportPath = "/Report Project1/Report1";

                // refresh the report
                rptViewer.ServerReport.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void showLocalReport()
        {
            try
            {
                // report url
                //string localReportPath = "LocalReports/Report1.rdlc";
                string localReportPath = "LocalReports/VacancyByDiv.rdlc";

                // processing mode
                rptViewer.ProcessingMode = ProcessingMode.Local;

                // set the report path
                rptViewer.LocalReport.ReportPath = localReportPath;

                //var dataSource = new Local2DataSetTableAdapters.tblBudItemNumTableAdapter().GetData();
                //rptViewer.LocalReport.DataSources.Add(new ReportDataSource("LocalDataSet", (object)dataSource));

                var dataSource = new VacancyDataSetTableAdapters.View_VacancyByDivisionOrderedTableAdapter().GetData();
                rptViewer.LocalReport.DataSources.Add(new ReportDataSource("VacancyDataSet", (object)dataSource));

                // refresh the report
                rptViewer.LocalReport.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}