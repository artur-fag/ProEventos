﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proEventos.API.Models;

namespace proEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


        public IEnumerable<Evento> _evento = new Evento[]{
              new Evento(){

                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
                },
                new Evento(){

                EventoId = 2,
                Tema = "Angular  e Suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
                }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _evento;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {

            return _evento.Where(evento => evento.EventoId == id);

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