using DemoPetShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Repository.Base.Interface
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        List<TEntity> FindAll();
        TEntity FindById(string p_Id);
        bool Insert(TEntity p_Obj);
        bool Update(TEntity p_Obj);
        bool Remove(string p_Id);
    }
}
