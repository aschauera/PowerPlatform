using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using System.Collections;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;


namespace Aschi.AssetDemo
{
    public class Asset
    {
        public string AssetID { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string FunctionalLocation { get; set; }
        public string Type { get; set; }
    }

    public class AssetDemoSystem
    {
        [FunctionName("ListAssetsFromDemoLOB")]
        public async Task<IActionResult> ListAssets(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                log.LogInformation("C# HTTP trigger function processed a request.");

                var dummyAssetJSONstring = @"[
                 {
                 ""AssetID"": ""A1"",
                 ""Customer"": ""MONDI"",
                 ""Name"": ""Pulp Mill Drum 01"",
                 ""FunctionalLocation"": ""Timisoara"",
                 ""Type"": ""Machinery""
                 },
                 {
                 ""AssetID"": ""A2"",
                 ""Customer"": ""Mayer Mellnof Paper"",
                 ""Name"": ""Pulp Roller 02"",
                 ""FunctionalLocation"": ""Hirschwang"",
                 ""Type"": ""Machinery""
                 },
                 {
                 ""AssetID"": ""A3"",
                 ""Customer"": ""RHIM"",
                 ""Name"": ""Paper Machine"",
                 ""FunctionalLocation"": ""Hirschwang"",
                 ""Type"": ""Machinery""
                 },
                 {
                 ""AssetID"": ""A4"",
                 ""Customer"": ""RHIM"",
                 ""Name"": ""Basic Oxygen Furnace A01"",
                 ""FunctionalLocation"": ""Contagem"",
                 ""Type"": ""Line""
                 }]";

                var jsonArray = JsonSerializer.Deserialize<IList<Asset>>(dummyAssetJSONstring);
                return new ObjectResult(jsonArray);
            }
            catch (System.Exception ex)
            {
                log.LogError("ERROR: " + ex.Message);
                throw;
            }
        }

        [FunctionName("CalculateAssetReturn")]
        public async Task<IActionResult> CalculateAssetReturn(
                [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
                ILogger log)
        {
            var yearsParam = req.GetQueryParameterDictionary().SingleOrDefault(x => x.Key == "years");
            log.LogInformation("Years: " + yearsParam.Value);
            var value = new {TotalReturn =12345660000};
            return new OkObjectResult(value);
        }
    }
}