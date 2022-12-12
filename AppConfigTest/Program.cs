using System.Configuration;

namespace AppConfigTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocsToRetrieveSection section = (DocsToRetrieveSection)ConfigurationManager.GetSection("DocsToRetrieve");
        }
    }
}