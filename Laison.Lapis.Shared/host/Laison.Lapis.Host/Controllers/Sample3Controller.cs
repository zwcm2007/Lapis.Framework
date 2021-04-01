using Laison.Lapis.Shared.HttpApi;
using Microsoft.AspNetCore.Mvc;

namespace Laison.Lapis.Host
{
    [Route("api/sample3")]
    [ApiExplorerSettings(GroupName = "User")]
    public class Sample3Controller : LapisController
    {
        //public string connStr = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=d:\FileScanData.mdb;Provider=SQLOLEDB";

        public string connStr = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source = d:\FileScanData.mdb";

        public Sample3Controller()
        {
        }
    }
}