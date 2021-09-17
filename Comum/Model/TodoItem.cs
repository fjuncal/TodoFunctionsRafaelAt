using System;
using Newtonsoft.Json;

namespace Comum.Model
{
    public class TodoItem
    {
        [JsonProperty(PropertyName = "id")]
        public String Id { get; set; }

        [JsonProperty(PropertyName = "responsavel")]
        public String Responsavel { get; set; }

        [JsonProperty(PropertyName = "estaFeita")]
        public Boolean EstaFeita { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public String Nome { get; set; }

        [JsonProperty(PropertyName = "descricao")]
        public String Descricao { get; set; }
        
        [JsonProperty(PropertyName = "dataAtividade")]
        public DateTime DataAtividade { get; set; }

        [JsonProperty(PropertyName = "pk")]
        public string PartitionKey { get; set; } = "todo";
    }
}