using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main.API.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Main.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoControler : ControllerBase
    {   
        public IEnumerable<Evento> _evento = new Evento[] { 
                new Evento() {
                EventoId = 1,
                title = "js",
                local = "Rio Branco",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                QtdPessoas = 55,
                Lote = "primeiro lote",

            },
                new Evento() {
                EventoId = 2,
                title = "angular tutotial",
                local = "Rio Branco",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                QtdPessoas = 55,
                Lote = "primeiro lote",

            }   
        };
        public EventoControler()
        {
        }
        
        [HttpGet]
        public IEnumerable<Evento> Get() //IEnumerable<> espera ser retornado um array
        {

            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Detail(int id){
            return  _evento.Where( evento => evento.EventoId == id );  //retorna o EventoId == ao numero passado
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";

        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Alterando o  user {id} com put";
        }

        [HttpDelete("{id}")]
        public string DeleteUer(int id)
        {
            return $"deletando o usuario {id} com delete";
        }

        [HttpPatch("{id}")]
        public Dictionary<string, string> PartialEditUser(int id){
           
            Dictionary<string, string> lista = new Dictionary<string, string>();

            lista.Add("nome", "ives");
            lista.Add("outro_nome", "pedro");
            lista.Add("Action","Edited");
          
     

            return lista;
        }
    }
}
