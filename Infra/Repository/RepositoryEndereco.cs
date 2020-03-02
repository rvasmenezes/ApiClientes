using Domain.Entities;
using Domain.Interfaces;
using Infra.Repository.Generics;

namespace Infra.Repository
{
    public class RepositoryEndereco : RepositoryGeneric<Endereco>, IEndereco
    {
    }
}
