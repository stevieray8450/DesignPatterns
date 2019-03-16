using System;
using System.Net;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var ftpRequestFactory = new FtpWebRequestFactory();
            var ftpDetailsRequestClient = ftpRequestFactory.GetFtpWebRequestClient(WebRequestMethods.Ftp.ListDirectoryDetails);
            var details = ExecuteRequest(ftpDetailsRequestClient).GetAwaiter().GetResult().Split("\n");

        }

        static async Task<string> ExecuteRequest(FtpWebRequestClient requestClient)
        {
            return await requestClient.ExecuteRequest();
        }
    }
}
