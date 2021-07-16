using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main.API.data;
using Main.API.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Main.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoControler : ControllerBase
    {
        private readonly DataContext _context;
        public EventoControler(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Eventos> Get() //IEnumerable<> espera ser retornado um array
        {

            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Eventos> Detail(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);  //retorna o EventoId == ao numero passado
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
        public Dictionary<string, string> PartialEditUser(int id)
        {

            Dictionary<string, string> lista = new Dictionary<string, string>();

            lista.Add("nome", "ives");
            lista.Add("outro_nome", "pedro");
            lista.Add("Action", "Edited");



            return lista;
        }
    }
}
