using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Mapiranja;

namespace Izbori
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ShowSql()
                    .ConnectionString(c =>
                    c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S14929;Password=pass"));
                //c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S14665;Password=Train94"));

                return Fluently.Configure()
                    .Database(cfg)
                    //.Mappings(m=>m.FluentMappings.AddFromAssemblyOf<AkcijaMapiranja>())
                    //prepraviti da bude addFromAsemblyOf
                    //Kada se doda da bude AddFromAssemblyOf program iz not responding
                    .Mappings(m => m.FluentMappings.Add<AkcijaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<AktivistaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<BrTelMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<EmailMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<GlasackoMestoMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<RezultatiIzboraMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<PrimedbeMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<KoordinatorMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<DeljenjeLetakaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<LokacijaDeljenjaLetakaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<MitingMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<MitingZatvoreniPMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<GostMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<SusretKandidataMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<ReklamaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<PanoReklamaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<TVRadioReklamaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<NovineReklamaMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<PojavljivanjaPKMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<TVRadioGostMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<TVDuelMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<ProtivKandidatiTVDuelMapiranja>())
                    .Mappings(m => m.FluentMappings.Add<PitanjaTVDuelMapiranja>())
                    //.Mappings(m => m.FluentMappings.Add<IntervjuNovineMapiranja>())
                    //.Mappings(m => m.FluentMappings.Add<NovinariIzNovinaMapiranja>())
                    .Diagnostics(d => d.Enable().OutputToConsole())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }

        }
    }
}
