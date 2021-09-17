using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using Todo_Painel.Models;

namespace Todo_Painel.Controllers
{
    public class TodoController : Controller
    {
        public readonly string API_URL = "https://todo-functions-at.azurewebsites.net/api/";
        
        [HttpGet]
        [Route("/listarTodos")]
        public IActionResult ListarTodos()
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("GetTodos", Method.GET);
            IRestResponse<List<TodoItem>> response = cliente.Execute<List<TodoItem>>(request);
            var todoItens = response.Data;
            return View(todoItens);
        }
        
        [HttpPost]
        [Route("/removerTodo")]
        public IActionResult RemoverTodo(string id)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("Remove/" + id, Method.POST);
            cliente.Execute(request);
            return RedirectToAction("ListarTodos", "Todo");;
        }
        
        [Route("/cadastrarTodo")]
        public IActionResult CriarTodo()
        {
            return View();
        }
        [HttpPost]
        [Route("/confirmarCadastrarTodo")]
        public IActionResult ConfirmarCadastro(TodoItem todoItem)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("Save", Method.POST);
            request.AddJsonBody(todoItem);
            cliente.Execute(request);
            
            return RedirectToAction("ListarTodos", "Todo");;
        }
        
        [Route("/editarTodo")]
        public IActionResult EditarTodo(string id)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("GetById/" + id, Method.GET);
            IRestResponse<TodoItem> response = cliente.Execute<TodoItem>(request);
            var todoItem = response.Data;
            
            return View(todoItem);
        }
        
        [HttpPost]
        [Route("/confirmarEditarTodo")]
        public IActionResult ConfirmarEditarTodo(TodoItem todoItem)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("Edit/" + todoItem.Id, Method.PUT);
            request.AddJsonBody(todoItem);
            cliente.Execute(request);
            
            return RedirectToAction("ListarTodos", "Todo");
        }
        
        [Route("/expandirTodo")]
        public IActionResult ExpandirTodo(string id)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("GetById/" + id, Method.GET);
            IRestResponse<TodoItem> response = cliente.Execute<TodoItem>(request);
            var todoItem = response.Data;
            
            return View(todoItem);
        }
        
        [Route("/alterarStatus")]
        public IActionResult alterarStatus(string id)
        {
            var cliente = new RestClient(API_URL);
            var request = new RestRequest("GetById/" + id, Method.GET);
            IRestResponse<TodoItem> response = cliente.Execute<TodoItem>(request);
            var todoItem = response.Data;

            if (todoItem.EstaFeita == false)
            {
                todoItem.EstaFeita = true;
            }
            else
            {
                todoItem.EstaFeita = false;
            }
            
            var clienteEditar = new RestClient(API_URL);
            var requestEditar = new RestRequest("Edit/" + id, Method.PUT);
            requestEditar.AddJsonBody(todoItem);
            clienteEditar.Execute(requestEditar);
            
            
            return RedirectToAction("ListarTodos", "Todo");
        }
    }
}