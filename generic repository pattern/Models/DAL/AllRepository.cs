using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace generic_repository_pattern.Models.DAL
{
    public class AllRepository<T> : _IAllRepository<T> where T:class{
        private webapiEntities _context;
        private IDbSet<T> dbEntity;

        public AllRepository()
        {
            _context = new webapiEntities();
            dbEntity = _context.Set<T>();
        }

        public void DeleteModel(int modelID)
        {
            T model = dbEntity.Find(modelID);
            dbEntity.Remove(model);
        }

        public IEnumerable<T> GetModel()
        {
            return dbEntity.ToList();
        }

        public T GetModelByID(int modelId)
        {
            return dbEntity.Find(modelId);
        }

        public void InsertModel(T model)
        {
            dbEntity.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateModel(T model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }
    }

}