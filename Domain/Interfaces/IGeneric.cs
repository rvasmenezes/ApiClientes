using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Generic
{
    public interface IGeneric<T> where T : class
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetEntity(int Id);
        List<T> List();
    }
}
