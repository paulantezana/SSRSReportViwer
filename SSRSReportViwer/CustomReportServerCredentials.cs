using Microsoft.Reporting.WebForms;
using System.Net;
using System.Security.Principal;

namespace SSRSReportViwer
{
    internal class CustomReportServerCredentials : IReportServerCredentials
    {
        private string _username;
        private string _password;
        private string _domain;

        public CustomReportServerCredentials(string username, string password, string domain = "")
        {
            _username = username;
            _password = password;
            _domain = domain;
        }

        public WindowsIdentity ImpersonationUser
        {
            get { return null; }
        }

        public ICredentials NetworkCredentials
        {
            get { return new NetworkCredential(_username, _password, _domain); }
        }

        public bool GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            authCookie = null;
            userName = null;
            password = null;
            authority = null;

            return false;
        }
    }
}