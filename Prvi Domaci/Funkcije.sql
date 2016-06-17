--Utility fajl

-- Funkcija za unos letaka
CREATE OR REPLACE FUNCTION INSERT_LETAK(Naziv in varchar2, Grad in varchar2) 
RETURN VARCHAR2 AS
  akcija_id integer := IDSekvenca.NEXTVAL;
BEGIN
	INSERT INTO Akcija (ID, NazivAkcije, Grad) VALUES (akcija_id, Naziv, Grad);
    INSERT INTO DeljenjeLetaka (ID) VALUES (akcija_id);
      
    return 'SUCCESS';

EXCEPTION 
	WHEN others THEN
    RETURN 'FAIL';
END;

-- Funkcija za unos susreta kandidata
CREATE OR REPLACE FUNCTION INSERT_SUSRET(Naziv in varchar2, Grad in varchar2, vreme in date, lok in varchar2) 
RETURN VARCHAR2 AS
  akcija_id integer := IDSekvenca.NEXTVAL;
BEGIN
	INSERT INTO Akcija (ID, NazivAkcije, Grad) VALUES (akcija_id, Naziv, Grad);
    INSERT INTO SusretKandidata (ID, PlaniranoVreme, Lokacija) VALUES (akcija_id, vreme, lok);
      
    return 'SUCCESS';

EXCEPTION 
	WHEN others THEN
    RETURN 'FAIL';
END;

-- Funkcija za unos mitinga

CREATE OR REPLACE FUNCTION INSERT_MITING(Naziv in varchar2, Grad in varchar2, Lokacija in varchar2, Iznajmljivac in varchar2 DEFAULT NULL, Cena in NUMBER DEFAULT NULL) 
RETURN VARCHAR2 AS
  
  	akcija_id integer := IDSekvenca.NEXTVAL;
BEGIN
	INSERT INTO Akcija (ID, NazivAkcije, Grad) VALUES (akcija_id, Naziv, Grad);
	IF Iznajmljivac IS NULL AND Cena IS NULL THEN
		INSERT INTO Miting VALUES (akcija_id, Lokacija);		
		return 'SUCCESS';
	ELSE IF Iznajmljivac IS NOT NULL AND CENA IS NOT NULL THEN
		INSERT INTO Miting VALUES (akcija_id, Lokacija);
		INSERT INTO MitingZatvoreniP VALUES (akcija_id, Iznajmljivac, Cena);
		return 'SUCCESS';
	ELSE
		return 'FAIL';

EXCEPTION 
	WHEN others THEN
    RETURN 'FAIL';
END;

-- Funkcija za unapredjenje aktiviste u koordinatora
CREATE OR REPLACE FUNCTION PROMOTE(Ime in varchar2, SIme in varchar2, Prezime in varchar2, Ulica in varchar2, Broj in integer, Grad in varchar2, Opstina in varchar2, UlicaKanc in varchar2, BrojKanc in varchar2, GradKanc in varchar2) 
RETURN VARCHAR2 AS

	id_aktv := SELECT ID FROM AktivistaStranke WHERE AktivistaStranke.Ime = LIme AND AktivistaStranke.ImeRod = SIme AND AktivistaStranke.Prezime = Prezime AND AktivistaStranke.Ulica = Ulica AND AktivistaStranke.Broj = Broj AND AktivistaStranke.Grad = Grad;
BEGIN
	INSERT INTO Koordinator VALUES (id_aktv, Opstina, UlicaKanc, BrojKanc, GradKanc);
      
    return 'SUCCESS';

EXCEPTION 
	WHEN others THEN
    RETURN 'FAIL';
END;

-- Triger za dodavanje TV i radio gostovanja
CREATE OR REPLACE TRIGGER INSERT_TVGost
BEFORE INSERT ON TVRadioGost
REFERENCING NEW AS novoGost
FOR EACH ROW 
BEGIN
  SELECT IDSekvenca.NEXTVAl INTO :novoGost.ID FROM DUAL;
END;

-- Funkcija za dodavanje TV duela
-- CREATE OR REPLACE TRIGGER FUNCTION Insert_TVDuel(NazivStanice in varchar2, NazivEmisije in varchar2, ImeVoditelja in varchar2, Gledanost in number, 

--TODO Dodavanje pomocnika koordinatoru

-- DA LI MORA KOBASICE OD FUNKCIJA ILI MOZE SAMO PO ID-u?

drop table "S14665"."AKCIJA" cascade constraints;
drop table "S14665"."AKTIVISTASTRANKE" cascade constraints;
drop table "S14665"."AKTIVNOSTIAKTIVISTA" cascade constraints;
drop table "S14665"."BRTELAKTIVISTA" cascade constraints;
drop table "S14665"."DELJENJELETAKA" cascade constraints;
drop table "S14665"."EMAILAKTIVISTA" cascade constraints;
drop table "S14665"."GLASACKOMESTO" cascade constraints;
drop table "S14665"."GOST" cascade constraints;
drop table "S14665"."INTERVJUNOVINE" cascade constraints;
drop table "S14665"."KOORDINATOR" cascade constraints;
drop table "S14665"."LOKACIJADELJENJALETAKA" cascade constraints;
drop table "S14665"."MITING" cascade constraints;
drop table "S14665"."MITINGZATVORENIP" cascade constraints;
drop table "S14665"."NOVINARIIZNOVINA" cascade constraints;
drop table "S14665"."NOVINEREKLAMA" cascade constraints;
drop table "S14665"."PANOREKLAMA" cascade constraints;
drop table "S14665"."PITANJATVDUEL" cascade constraints;
drop table "S14665"."PRIMEDBE" cascade constraints;
drop table "S14665"."PROTIVKANDIDATITVDUEL" cascade constraints;
drop table "S14665"."REZULTATIIZBORA" cascade constraints;
drop table "S14665"."SUSRETKANDIDATA" cascade constraints;
drop table "S14665"."TVDUEL" cascade constraints;
drop table "S14665"."TVRADIOGOST" cascade constraints;
drop table "S14665"."TVRADIOREKLAMA" cascade constraints;
drop table "S14665"."POJAVLJIVANJAPK" cascade constraints;
drop table "S14665"."REKLAMA" cascade constraints;
drop sequence "S14665"."AKCIJA_TG";
drop sequence "S14665"."AKTIVISTA_TG";
drop sequence "S14665"."AKTIVNOSTIAKTIVISTA_TG";
drop sequence "S14665"."BRTEL_TG";
drop sequence "S14665"."EMAIL_TG";
drop sequence "S14665"."GOST_TG";
drop sequence "S14665"."LOKACIJADELJENJALETAKA_TG";
drop sequence "S14665"."LOKACIJADL_TG";
drop sequence "S14665"."MESTO_TG";
drop sequence "S14665"."NOVINARIIZNOVINA_TG";
drop sequence "S14665"."NOVINE_TG";
drop sequence "S14665"."PITANJATVDUEL_TG";
drop sequence "S14665"."POJAVLJIVANJAPK_TG";
drop sequence "S14665"."PRIMEDBE_TG";
drop sequence "S14665"."PROTIVKANDIDATITVDUEL_TG";
drop sequence "S14665"."REKLAMA_TG";
drop sequence "S14665"."REZULTATIIZBORA_TG";
drop sequence "S14665"."TVRADIO_TG";


-- unos koordinatora
Declare
  Ime varchar2(63);
  SIme varchar2(63);
  Prezime varchar2(63);
  Ulica varchar2(63);
  Broj integer;
  Grad varchar2(63);
  Opstina varchar2(63);
  UlicaKanc varchar2(63);
  BrojKanc integer;
  GradKanc varchar2(63);
  v_ret varchar2(200);
Begin  
  Ime := 'Dušan';
  SIme := 'Zorica';
  Prezime := 'Avramović';
  Ulica := 'Milutina Bojića';
  Broj := 31;
  Grad := 'Šabac';
  Opstina := 'Palilula';
  UlicaKanc := 'Filipa Višnjića';
  BrojKanc := 14;
  GradKanc := 'Niš';
  
  v_ret := PROMOTE(
    Ime => Ime,
    SIme => SIme,
    Prezime => Prezime,
    Ulica => Ulica,
    Broj => Broj,
    Grad => Grad,
    Opstina => Opstina,
    UlicaKanc => UlicaKanc,
    BrojKanc => BrojKanc,
    GradKanc => GradKanc);
    
    :v_ret := v_ret;
END;

-- unos akcija deljenja letaka

DECLARE
  NAZIV VARCHAR2(200);
  GRAD VARCHAR2(200);
  v_Return VARCHAR2(200);
BEGIN
  NAZIV := 'Od vrata do vrata - Bulevar';
  GRAD := 'Nis';

  v_Return := INSERT_LETAK(
    NAZIV => NAZIV,
    GRAD => GRAD
  );
  :v_Return := v_Return;
END;

-- unos susreta kandidata

DECLARE
  NAZIV VARCHAR2(200);
  GRAD VARCHAR2(200);
  Vreme DATE;
  Lok varchar2(100);
  v_Return VARCHAR2(200);
BEGIN
  NAZIV := 'Susret sa penzionerima';
  GRAD := 'Beograd';
  Vreme := TO_DATE('04/04/2016 12:30','DD/MM/YY hh24:mi');
  Lok := 'Gerontološki zavod';

  v_Return := INSERT_SUSRET(
    NAZIV => NAZIV,
    GRAD => GRAD,
    Vreme => vreme,
    Lok => lok
  );
  :v_Return := v_Return;
END;

-- unos mitinga

DECLARE
  NAZIV VARCHAR2(200);
  GRAD VARCHAR2(200);
  LOKACIJA VARCHAR2(200);
  IZNAJMLJIVAC VARCHAR2(200);
  CENA NUMBER;
  v_Return VARCHAR2(200);
BEGIN
  NAZIV := 'Veliki miting na trgu';
  GRAD := 'Jagodina';
  LOKACIJA := 'Glavni trg';

  v_Return := INSERT_MITING(
    NAZIV => NAZIV,
    GRAD => GRAD,
    LOKACIJA => LOKACIJA
  );
  :v_Return := v_Return;
END;

-- Unos u zatvorenom
DECLARE
  NAZIV VARCHAR2(200);
  GRAD VARCHAR2(200);
  LOKACIJA VARCHAR2(200);
  IZNAJMLJIVAC VARCHAR2(200);
  CENA NUMBER;
  v_Return VARCHAR2(200);
BEGIN
  NAZIV := 'Veliki miting na trgu';
  GRAD := 'Jagodina';
  LOKACIJA := 'Sportski centar Jagodina';
  IZNAJMLJIVAC := 'Jagodinske hale doo';
  CENA := 127000;

  v_Return := INSERT_MITING(
    NAZIV => NAZIV,
    GRAD => GRAD,
    LOKACIJA => LOKACIJA,
    IZNAJMLJIVAC => IZNAJMLJIVAC,
    CENA => CENA
  );
  :v_Return := v_Return;
END;

-- koordinatori
SELECT LIME, PREZIME FROM AKTIVISTASTRANKE JOIN KOORDINATOR ON KOORDINATOR.IDakt = AKTIVISTASTRANKE.ID;