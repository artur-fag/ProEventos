﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proEventos.API.Data;
using proEventos.API.Models;

namespace proEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {



        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _context.Eventos;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {

            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);

        }


        [HttpPost]
        public string Post()
        {

            return "Exemlo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {

            return $"Exemplo de put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            return $"Exemplo de Delete = {id}";
        }
    }
}
