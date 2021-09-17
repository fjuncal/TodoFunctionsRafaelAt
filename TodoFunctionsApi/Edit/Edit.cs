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

namespace TodoFunctionsApi.Edit
{
    public static class Edit
    {
        [FunctionName("Edit")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "Edit/{id}")]
            HttpRequest req, ILogger log, string id)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            TodoItem data = JsonConvert.DeserializeObject<TodoItem>(requestBody);

            if (data == null)
                return new BadRequestObjectResult(new { message = "Dados para editar uma tarefa é obrigatoria" });

            data.Id = id;
         
            var repository = new TodoItemRepository();
            var tarefa = repository.GetById(data.Id);
            if (data.Id == null || tarefa == null)
            {
                return new BadRequestObjectResult(new { message = "ID da tarefa inválido para edita-la" });
            }
            tarefa.Nome = data.Nome;
            tarefa.Descricao = data.Descricao;
            tarefa.Responsavel = data.Responsavel;
            tarefa.EstaFeita = data.EstaFeita;
            tarefa.DataAtividade = data.DataAtividade;
            
            await repository.Update(tarefa);

            return new OkResult();
            
        }
    }
}