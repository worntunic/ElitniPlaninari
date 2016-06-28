using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Izbori.Entiteti;
using System.Reflection;

namespace Izbori
{
    public class DataProvider
    {
        public IEnumerable<T> GetEntities<T>()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<T> entities = s.Query<T>().Select(p => p);
            return entities;
        }

        public T GetEntity<T>(int id)
        {
            ISession s = DataLayer.GetSession();

            T ent = s.Get<T>(id);

            return ent;
        }

        public int RemoveEntity<T>(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                T ent = s.Get<T>(id);

                s.Delete(ent);
                s.Flush();
                s.Close();
                return 1;                
            }
            catch (Exception)
            {
                return -1;                
            }
        }

        public int UpdateEntity<T>(int id, T ent)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //ent.id 
                T e = s.Load<T>(id);

                var prop = ent.GetType().GetProperties();

                foreach(var p in prop)
                {
                    var propValEnt = ent.GetType().GetProperty(p.Name).GetValue(ent);

                    if (propValEnt != null)
                    {
                        if (propValEnt.GetType() == typeof(string) && (string)propValEnt != "")
                        {
                            e.GetType().GetProperty(p.Name).SetValue(e, propValEnt);
                        }
                        else if (propValEnt.GetType() == typeof(Int32) && (Int32)propValEnt != 0)
                        {
                            e.GetType().GetProperty(p.Name).SetValue(e, propValEnt);
                        } 
                    }
                }
                s.SaveOrUpdate(e);
                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " | Inner: " + ex.InnerException.Message);
                return -1;
            }
        }

        public int AddEntity<T>(T ent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(ent);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
    }
}
