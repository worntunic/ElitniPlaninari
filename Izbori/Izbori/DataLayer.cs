using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Mapiranja;

namespace Izbori {
    class DataLayer {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession() {
            //ukoliko session factory nije kreiran
            if (_factory == null) {
                lock (objLock) {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory() {
            try {
                var cfg = OracleClientConfiguration.Oracle10
                    .ShowSql()
                    .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S14665;Password=Train94"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AkcijaMapiranja>())
                    //.Diagnostics(d => d.Enable().OutputToConsole())
                    .BuildSessionFactory();
            } catch (Exception ec) {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }

        }
    }
}
