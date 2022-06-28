using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessGeneric
{
    public interface IRepositoryBase<T> where T : class , IEntity, new()
    {
        public void Add(T entity);

        public void Delete(T entity);

        public void Update(T entity);

        public List<T> GetAll(Expression<Func<T,bool>>  filter = null);

        public T Get(Expression<Func<T,bool>> filter);

        //Generic Contrain =>> Kısıtlayıcılar

        //class = referans tipli

        //IEntity = IEntity'nin implemente edildiği sınıflar olabilir.

        //new() = newlenebilir olmalıdır. 





    }
}
