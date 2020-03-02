using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IAppCliente _appCliente;

        public ClienteController(IAppCliente appCliente)
        {
            _appCliente = appCliente;
        }

        // GET: api/Cliente
        [HttpGet]
        public List<Cliente> Get()
        {
            return _appCliente.List();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "GetCliente")]
        public Cliente Get(int id)
        {
            return _appCliente.GetEntity(id);
        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] Cliente model)
        {
            _appCliente.Add(model);
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente model)
        {
            _appCliente.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cli = _appCliente.GetEntity(id);
            _appCliente.Delete(cli);
        }
    }
}
