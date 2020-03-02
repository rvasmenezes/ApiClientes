using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Apps
{
    public class ApplicationCliente : IAppCliente
    {

        ICliente _iCliente;

        public ApplicationCliente(ICliente iCliente)
        {
            _iCliente = iCliente;
        }

        public void Add(Cliente Entity)
        {
            _iCliente.Add(Entity);
        }

        public void Delete(Cliente Entity)
        {
            _iCliente.Delete(Entity);
        }

        public Cliente GetEntity(int Id)
        {
            return _iCliente.GetEntity(Id);
        }

        public List<Cliente> List()
        {
            return _iCliente.List();
        }

        public void Update(Cliente Entity)
        {
            _iCliente.Update(Entity);
        }
    }
}
