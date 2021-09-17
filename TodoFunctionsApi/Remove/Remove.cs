using System;
using System.IO;
using System.Threading.Tasks;
using Comum.Model;
using Comum.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TodoFunctionsApi.Remove
{
    public static class RemoveById
    {
        [FunctionName("Remove")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "Remove/{id}")]
            HttpRequest req, ILogger log, string id)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            
            var repository = new TodoItemRepository();

            var todoDeletar = repository.GetById(id);
            if (todoDeletar == null)
            {
                return new BadRequestObjectResult(new {message = "ID Inválido para remover a tarefa"});
            }

            await repository.Delete(todoDeletar);

            return new OkResult();
            
        }
    }
}