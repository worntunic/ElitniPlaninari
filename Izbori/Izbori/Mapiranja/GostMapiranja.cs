﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    class GostMapiranja : ClassMap<Izbori.Entiteti.Gost> {
        public GostMapiranja() {
            Table("Gost");

            Id(x => x.ID_GOST, "ID_GOST").GeneratedBy.TriggerIdentity();
            //Mapiranje kljuca mitinga
            Map(x => x.Ime, "Ime");
            Map(x => x.Prezime, "Prezime");
            Map(x => x.Titula, "Titula");
            Map(x => x.Funkcija, "Funkcija");
        }
    }
}