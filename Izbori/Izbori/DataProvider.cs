using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Izbori.Entiteti;
using System.Reflection;
using System.Windows.Forms;

namespace Izbori
{
    public class DataProvider
    {
        /**
         * Funkcija koja pribavlja sve kopmlekse propertije (one koji nisu string ili Int32)
         * */
        private IEnumerable<PropertyInfo> GetComplexProps<T>(T ent)
        {
            var t = ent.GetType().GetProperties().Where(p => p.PropertyType != typeof(string) && p.PropertyType != typeof(Int32));

            return t;
        }
        /**
         * Funkcija koja anulira sve tipove propertija koji nisu string ili Int32 (kompleksne propertije).
         * */
        private void NullComplexProps<T>(T ent)
        {
            var props = GetComplexProps<T>(ent);

            foreach (var p in props)
            {
                ent.GetType().GetProperty(p.Name).SetValue(ent, null);
            }

        }
        public IEnumerable<T> GetEntities<T>()
        {
            ISession s = DataLayer.GetSession();
            try
            {
                IEnumerable<T> entities = s.Query<T>().Select(p => p);

                foreach (T ent in entities)
                {
                    NullComplexProps<T>(ent); //anuliranje propertija
                }

                return entities;
            }
            finally
            {
                s.Close();
            }
        }

        public T GetEntity<T>(int id)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                T ent = s.Get<T>(id);
                NullComplexProps<T>(ent); //anuliranje propertija

                return ent;
            }
            finally
            {
                s.Close();
            }
        }

        public int RemoveEntity<T>(int id)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                T ent = s.Get<T>(id);
                NullComplexProps<T>(ent);
                s.Delete(ent);
                s.Flush();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                s.Close();
            }
        }

        public int UpdateEntity<T>(int id, T ent)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                T e = s.Load<T>(id);
                NullComplexProps<T>(e);
                NullComplexProps<T>(ent);

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

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " | Inner: " + ex.InnerException.Message);
                return -1;
            }
            finally
            {
                s.Close();
            }
        }

        public int AddEntity<T>(T ent)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                NullComplexProps<T>(ent);

                s.Save(ent);

                s.Flush();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
            finally
            {
                s.Close();
            }
        }
    }
}
