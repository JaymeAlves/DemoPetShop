using DemoPetShop.Domain.Base;
using DemoPetShop.Repository.Base.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPetShop.Repository.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IMongoCollection<TEntity> m_Collection;

        public MongoDbRepository(IMongoDatabase p_Database, string p_CollectionName)
        {
            m_Collection = p_Database.GetCollection<TEntity>(p_CollectionName);
        }

        public List<T> FindAll()
        {
            try
            {
                return m_Collection.AsQueryable().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T FindById(string p_Id)
        {
            try
            {
                return m_Collection.Find((a) => a.Id == p_Id).First();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Insert(T p_Obj)
        {
            try
            {
                m_Collection.InsertOne(p_Obj);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(string p_Id)
        {
            try
            {
                m_Collection.DeleteOne((a) => a.Id == p_Id);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(T p_Obj)
        {
            m_Collection.ReplaceOne((a) => a.Id == p_Obj.Id, p_Obj);
            return true;
        }

        protected IMongoCollection<T> GetCollection()
        {
            return m_Collection;
        }
    }
}
