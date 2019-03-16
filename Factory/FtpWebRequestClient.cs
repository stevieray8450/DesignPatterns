using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Factory
{
    public class FtpWebRequestClient
    {
        protected FtpWebRequest _ftpWebRequest;

        public FtpWebRequestClient(FtpWebRequest ftpWebRequest)
        {
            _ftpWebRequest = ftpWebRequest;
        }

        public async Task<string> ExecuteRequest()
        {
            var response = await _ftpWebRequest.GetResponseAsync();
            var responseStream = response.GetResponseStream();

            var result = string.Empty;
            using (responseStream) 
            {
                using (var sr = new StreamReader(responseStream))
                {
                    result = await sr.ReadToEndAsync();
                }
            }

            return result;
        }
    }
}