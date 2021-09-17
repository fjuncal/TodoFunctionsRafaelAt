using System;
using System.IO;
using System.Threading.Tasks;
using Comum.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TodoFunctionsApi.GetTodos
{
    public static class GetTodos
    {
        [FunctionName("GetTodos")]
        public static IActionResult Async(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var repository = new TodoItemRepository();

            return new OkObjectResult(repository.GetAll());

            
        }
    }
}