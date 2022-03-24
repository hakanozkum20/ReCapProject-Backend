using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint -- Genel kısıtlama 
    // class referans tipi.
    // T:class,IEntity ile hem referans tip olmasını hem de IEntity-IEntity implement eden bir nesne olmasını sağladık.
    // new() ile newlenebilen olmalı. IEntity soyut bir nesne olduğu için new lenemez. Somut nesneler new'lenebilir.
    // --- Entity Klasoründeki Car Brand ve Color nesnelerdir.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
