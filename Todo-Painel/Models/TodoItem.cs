using System;

namespace Todo_Painel.Models
{
    public class TodoItem
    {
        public String Id { get; set; }

        public String Responsavel { get; set; }

        public Boolean EstaFeita { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }
        
        public DateTime DataAtividade { get; set; }

        public string PartitionKey { get; set; } = "todo";
    }
}