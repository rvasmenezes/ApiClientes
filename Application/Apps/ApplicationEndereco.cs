using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Apps
{
    public class ApplicationEndereco : IAppEndereco
    {

        IEndereco _iEndereco;

        public ApplicationEndereco(IEndereco iEndereco)
        {
            _iEndereco = iEndereco;
        }

        public void Add(Endereco Entity)
        {
            _iEndereco.Add(Entity);
        }

        public void Delete(Endereco Entity)
        {
            _iEndereco.Delete(Entity);
        }

        public Endereco GetEntity(int Id)
        {
            return _iEndereco.GetEntity(Id);
        }

        public List<Endereco> List()
        {
            return _iEndereco.List();
        }

        public void Update(Endereco Entity)
        {
            _iEndereco.Update(Entity);
        }
    }
}
