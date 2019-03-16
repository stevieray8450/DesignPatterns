using System.Net;

namespace Factory
{
    public class FtpWebRequestFactory
    {
        private const string FtpUri = "ftp://speedtest.tele2.net";
        private const string AnonymousLogin = "anonymous";

        public FtpWebRequestClient GetFtpWebRequestClient(string requestMethod)
        {
            var request = (FtpWebRequest)WebRequest.Create(FtpUri);
            request.Credentials = new NetworkCredential(AnonymousLogin, string.Empty);
            request.Method = requestMethod;

            return new FtpWebRequestClient(request);
        }
    }
}