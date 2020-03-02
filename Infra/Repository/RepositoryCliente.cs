using Domain.Entities;
using Domain.Interfaces;
using Infra.Repository.Generics;

namespace Infra.Repository
{
    public class RepositoryCliente : RepositoryGeneric<Cliente>, ICliente
    {
    }
}
