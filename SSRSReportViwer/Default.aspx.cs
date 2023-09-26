using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSRSReportViwer
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string rdlId = Request.QueryString["id"];
                string paramWhere = Request.QueryString["paramWhere"];
                string usuario = Request.QueryString["usuario"];
                string companias = Request.QueryString["companias"];

                // Configura las credenciales del servidor de informes
                ReportViewer1.ServerReport.ReportServerCredentials = new CustomReportServerCredentials("ssssss", "ssssssss");

                // Configura los parámetros del informe
                ReportParameter[] reportParameters = new ReportParameter[3]; // Cambia el tamaño según la cantidad de parámetros

                // Agrega los parámetros con sus nombres y valores
                reportParameters[0] = new ReportParameter("ParametroWhere", paramWhere);
                reportParameters[1] = new ReportParameter("Usuario", usuario);
                reportParameters[2] = new ReportParameter("Companias", companias);

                // Concatena rdlId en la ruta del informe
                string reportPath = $"/DDDDD/Contabilidad/{rdlId}";

                // Establece la ruta del informe en el ReportViewer
                ReportViewer1.ServerReport.ReportPath = reportPath;

                // Asigna los parámetros al ReportViewer
                ReportViewer1.ServerReport.SetParameters(reportParameters);

                // Carga el informe
                ReportViewer1.ServerReport.Refresh();
            }
        }
    }
}