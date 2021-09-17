using System;
using System.IO;
using System.Threading.Tasks;
using Comum.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TodoFunctionsApi.GetById
{
    public static class GetById
    {
        [FunctionName("GetById")]
        public static  IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "GetById/{id}")]
            HttpRequest req, string id, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            
            var repository = new TodoItemRepository();

            var todo = repository.GetById(id);

            if (todo == null)
                return new NotFoundObjectResult(new { message = "Não encontrei a Tarefa" });

            return new OkObjectResult(todo);
            
        }
    }
}