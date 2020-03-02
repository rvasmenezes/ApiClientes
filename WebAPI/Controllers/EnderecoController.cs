using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {

        private readonly IAppEndereco _appEndereco;

        public EnderecoController(IAppEndereco appEndereco)
        {
            _appEndereco = appEndereco;
        }

        // GET: api/Endereco
        [HttpGet]
        public List<Endereco> Get()
        {
            return _appEndereco.List();
        }

        // GET: api/Endereco/5
        [HttpGet("{id}", Name = "GetEndereco")]
        public Endereco Get(int id)
        {
            return _appEndereco.GetEntity(id);
        }

        // POST: api/Endereco
        [HttpPost]
        public void Post([FromBody] Endereco model)
        {
            _appEndereco.Add(model);
        }

        // PUT: api/Endereco/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Endereco model)
        {
            _appEndereco.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cli = _appEndereco.GetEntity(id);
            _appEndereco.Delete(cli);
        }
    }
}
