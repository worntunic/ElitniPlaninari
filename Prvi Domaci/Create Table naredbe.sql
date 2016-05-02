CREATE TABLE AktivistaStranke
(
ID INTEGER NOT NULL PRIMARY KEY,
Lime VARCHAR2(63),
ImeRod VARCHAR2(63),
Prezime VARCHAR2(63),
Ulica VARCHAR2(63),
Broj INTEGER,
Grad VARCHAR2(63),
IDKoord INTEGER,
IDGM INTEGER
);

CREATE TABLE Koordinator
(
IDAkt INTEGER NOT NULL PRIMARY KEY REFERENCES AktivistaStranke (ID),
Opstina VARCHAR2(63),
Ulica VARCHAR2(63),
Broj INTEGER,
Grad VARCHAR2(63)
);

CREATE TABLE Akcija
(
ID INTEGER PRIMARY KEY NOT NULL,
NazivAkcije VARCHAR2(63),
Grad VARCHAR2(63)
);

CREATE TABLE DeljenjeLetaka
(
ID INTEGER PRIMARY KEY REFERENCES Akcija (ID)
);

CREATE TABLE SusretKandidata
(
ID INTEGER PRIMARY KEY REFERENCES Akcija (ID),
Lokacija VARCHAR2(63),
PlaniranoVreme DATE
);

CREATE TABLE Miting
(
ID INTEGER PRIMARY KEY REFERENCES Akcija (ID),
Lokacija VARCHAR2(63)
);

CREATE TABLE MitingZatvoreniP
(
IDMiting INTEGER NOT NULL PRIMARY KEY REFERENCES MITING (ID),
Iznajmljivac VARCHAR2(63),
Cena NUMBER--mozda pak i VARCHAR2(63) 
);

CREATE TABLE TVRadioGost
(
ID INTEGER NOT NULL PRIMARY KEY,
NazivStanice VARCHAR2(63),
NazivEmisije VARCHAR2(63),
ImeVoditelja VARCHAR2(63),
Gledanost NUMBER
);

CREATE TABLE TVDuel
(
IDTVRG INTEGER NOT NULL PRIMARY KEY REFERENCES TVRadioGost (ID)
);

CREATE TABLE IntervjuNovine
(
ID INTEGER NOT NULL PRIMARY KEY,
NazivLista VARCHAR2(63),
DatumObjavljivanja DATE,
DatumIntervjua DATE,
CONSTRAINT ProveriDatume CHECK (DatumIntervjua <= DatumObjavljivanja)
);

CREATE TABLE Reklama
(
ID INTEGER NOT NULL PRIMARY KEY,
CenaZakupa NUMBER,
DatumZakupa DATE,
TrajanjeZakupa INTEGER --trajanje u danima
);

CREATE TABLE TVRadioReklama
(
ID INTEGER PRIMARY KEY REFERENCES REKLAMA(ID),
BrojPonavljanja INTEGER,
Trajanje INTEGER, --u sekundama
NazivStanice VARCHAR2(63) 
);

CREATE TABLE NovineReklama
(
ID INTEGER PRIMARY KEY REFERENCES REKLAMA(ID),
Uboji NUMBER(1) CHECK (Uboji IN (0, 1)) NOT NULL, -- 0 oznacava da nije u boji, 1 da je u boji
NazivLista VARCHAR2(63)
);

CREATE TABLE PanoReklama
(
ID INTEGER PRIMARY KEY REFERENCES REKLAMA(ID),
Grad VARCHAR2(63),
Ulica VARCHAR2(63),
Vlasnik VARCHAR2(63),
Povrsina NUMBER --svi su u metrima kvadratnim
);

CREATE TABLE GlasackoMesto
(
ID INTEGER NOT NULL PRIMARY KEY,
Naziv VARCHAR2(63),
BrojGM INTEGER UNIQUE NOT NULL,
BrojRegBir INTEGER
);

CREATE TABLE RezultatiIzbora
(
BrKruga INTEGER DEFAULT 1 CHECK (BrKruga IN (1,2)) NOT NULL,
BrBiraca INTEGER,
ProcenatZaKandidata NUMBER,
IDGM INTEGER NOT NULL,
CONSTRAINT GM_ID FOREIGN KEY (IDGM) REFERENCES GlasackoMesto(ID),
CONSTRAINT Rez_PK PRIMARY KEY (IDGM, BrKruga)
);


CREATE TABLE Gost
(
ID_GOST INTEGER PRIMARY KEY,
IDMiting INTEGER,
Ime VARCHAR2(63),
Prezime VARCHAR2(63),
Titula VARCHAR2(63),
Funkcija VARCHAR2(63),
CONSTRAINT FK_ID_GOST FOREIGN KEY (IDMiting) REFERENCES Miting(ID)
--CONSTRAINT PK_GOST_ID PRIMARY KEY (IDMiting,ID_GOST)
);

CREATE TABLE AktivnostiAktivista
(
IDAkt REFERENCES AktivistaStranke(ID),
IDAkc REFERENCES Akcija(ID),
CONSTRAINT Aktivnosti_PK PRIMARY KEY (IDAkt,IDAkc)
);

CREATE TABLE BrTelAktivista
(
IDBr INTEGER PRIMARY KEY,
IDAkt REFERENCES AktivistaStranke(ID),
BrTel VARCHAR2(15) NOT NULL
);

CREATE SEQUENCE BRTel_TG
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 50
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_BRTEL
BEFORE INSERT ON BrTelAktivista
REFERENCING NEW AS noviBroj
FOR EACH ROW 
BEGIN
  SELECT BRTel_TG.NEXTVAl INTO :noviBroj.IDBr FROM DUAL;
END;

CREATE TABLE EMailAktivista
(
IDEmail INTEGER PRIMARY KEY,
IDAkt REFERENCES AktivistaStranke (ID),
eMail VARCHAR2(63) NOT NULL
);

CREATE SEQUENCE Email_TG
MINVALUE 1
START WITH 1
INCREMENT BY 1
CACHE 30
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_EMAIL
BEFORE INSERT ON EmailAktivista
REFERENCING NEW AS noviMail
FOR EACH ROW 
BEGIN
  SELECT Email_TG.NEXTVAl INTO :noviMail.IDEmail FROM DUAL;
END;

CREATE TABLE LokacijaDeljenjaLetaka
(
IdAkcD REFERENCES DeljenjeLetaka (ID),
Lokacija VARCHAR2(63) NOT NULL,
CONSTRAINT Lokacija_PK PRIMARY KEY (IDAkcD, Lokacija)
);

CREATE TABLE Primedbe
(
IDAkt REFERENCES AktivistaStranke (ID),
IDGM  REFERENCES GlasackoMesto(ID),
TekstPrim VARCHAR2(1023) NOT NULL,
CONSTRAINT Primedbe_PK PRIMARY KEY (IDAkt,IDGM,TekstPrim)
);

CREATE TABLE NovinariIzNovina
(
IDIntervjua REFERENCES IntervjuNovine (ID),
ImeNovinara VARCHAR2(63) NOT NULL,
CONSTRAINT Novinari_PK PRIMARY KEY (IDIntervjua, ImeNovinara)
);

CREATE TABLE ProtivKandidatiTVDuel
(
IDDuela REFERENCES TVDuel (IDTVRG),
ImePK VARCHAR2(63) NOT NULL,
CONSTRAINT ProtivKandidati_PK PRIMARY KEY (IDDuela, ImePK)
);

CREATE TABLE PitanjaTVDuel
(
IDDuela REFERENCES TVDuel (IDTVRG),
Tekst VARCHAR2(140) NOT NULL,
CONSTRAINT PitanjaTV_PK PRIMARY KEY (IDDuela, Tekst)
);

ALTER TABLE AktivistaStranke 
ADD CONSTRAINT Koord_FK
FOREIGN KEY (IDKoord) 
REFERENCES Koordinator(IDAkt);

ALTER TABLE AktivistaStranke 
ADD CONSTRAINT GlasackoMesto_FK
FOREIGN KEY (IDGM) 
REFERENCES GlasackoMesto(ID);

CREATE SEQUENCE Aktivista_TG
MINVALUE 1
MAXVALUE 10000000
START WITH 1
INCREMENT BY 1
CACHE 30
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_AKTIVISTA
BEFORE INSERT ON AKTIVISTASTRANKE
REFERENCING NEW AS noviClan
FOR EACH ROW 
BEGIN
  SELECT Aktivista_TG.NEXTVAl INTO :noviClan.ID FROM DUAL;
END;

CREATE SEQUENCE Akcija_TG
MINVALUE 1
MAXVALUE 100000000
START WITH 1
INCREMENT BY 1	
CACHE 100
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_AKCIJA
BEFORE INSERT ON AKCIJA
REFERENCING NEW AS novaAkcija
FOR EACH ROW 
BEGIN
  SELECT Akcija_TG.NEXTVAl INTO :novaAkcija.ID FROM DUAL;
END;

CREATE SEQUENCE TVRadio_TG
MINVALUE 1
MAXVALUE 1000000
START WITH 1
INCREMENT BY 1	
CACHE 10
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_TVRadio
BEFORE INSERT ON TVRadioGost
REFERENCING NEW AS novoTV
FOR EACH ROW 
BEGIN
  SELECT TVRadio_TG.NEXTVAl INTO :novoTV.ID FROM DUAL;
END;

CREATE SEQUENCE Novine_TG
MINVALUE 1
MAXVALUE 1000000
START WITH 1
INCREMENT BY 1	
CACHE 10
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_Intervju
BEFORE INSERT ON IntervjuNovine
REFERENCING NEW AS noviIntervju
FOR EACH ROW 
BEGIN
  SELECT Novine_TG.NEXTVAl INTO :noviIntervju.ID FROM DUAL;
END;


CREATE SEQUENCE Reklama_TG
MINVALUE 1
MAXVALUE 1000000
START WITH 1
INCREMENT BY 1	
CACHE 30
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_Reklama
BEFORE INSERT ON Reklama
REFERENCING NEW AS novaReklama
FOR EACH ROW 
BEGIN
  SELECT Reklama_TG.NEXTVAl INTO :novaReklama.ID FROM DUAL;
END;

CREATE SEQUENCE Mesto_TG
MINVALUE 1
MAXVALUE 10000000
START WITH 1
INCREMENT BY 1	
CACHE 150
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_GMesto
BEFORE INSERT ON GlasackoMesto
REFERENCING NEW AS novoGM
FOR EACH ROW 
BEGIN
  SELECT Mesto_TG.NEXTVAl INTO :novoGM.ID FROM DUAL;
END;

CREATE SEQUENCE GOST_TG
MINVALUE 1
MAXVALUE 100000
START WITH 1
INCREMENT BY 1
CACHE 20
ORDER
NOCYCLE;

CREATE OR REPLACE TRIGGER INSERT_Gost
BEFORE INSERT ON Gost
REFERENCING NEW AS noviGost
FOR EACH ROW
BEGIN
	SELECT GOST_TG.NEXTVAL INTO :noviGost.ID_GOST FROM DUAL;
END;