CREATE Schema Stoifl;


--*************************************************
-- alle drop statements
--*************************************************

alter table stoifl.link    drop constraint  link_kurs_fk;     
alter table stoifl.link    drop constraint  link_person_fk;   
alter table stoifl.kontakt  drop constraint  kontakt_person_fk;
alter table stoifl.adresse drop constraint  adresse_person_fk;
alter table stoifl.kontakt drop constraint  kontakt_art_fk;
alter table stoifl.adresse drop constraint  adresse_art_fk;

drop sequence stoifl.kurs_seq;   
drop sequence stoifl.person_seq; 
drop sequence stoifl.adresse_seq;
drop sequence stoifl.kontakt_seq;
drop sequence stoifl.art_seq;   

drop table stoifl.kurs;   
drop table stoifl.link;   
drop table stoifl.person; 
drop table stoifl.adresse;
drop table stoifl.kontakt;
drop table stoifl.art;

--*************************************************
-- KURS
--*************************************************
create table stoifl.kurs
(
	kurs_id				numeric(10) not null,
	kursnummer			numeric(10) not null,
	name				varchar(250),
	startkurs			date,
	endekurs			date,
	lehreinheiten		numeric(5),
	raum				varchar(50),
	maxTN				numeric(5),
	angemeldet			numeric(5),
	freiePlaetze		numeric(5),
	
	constraint kurs_pk primary key (kurs_id),
	constraint kurs_kursnummer_uk unique (kursnummer)
);
create sequence stoifl.kurs_seq start with 1 increment by 1;

--*************************************************
-- LINK
--*************************************************
create table stoifl.link
(
	kurs_id				numeric(10)not null,
	person_id			numeric(10) not null,
	rolle				varchar(10),
	
	constraint link_pk primary key (kurs_id, person_id)
);


--*************************************************
-- PERSON
--*************************************************
create table stoifl.person
(
	person_id			numeric(10) not null,
	vorname				varchar(250),
	nachname			varchar(250),
	gebdat				date,
	constraint person_pk primary key (person_id),
	constraint person_uk	unique (vorname, nachname, gebdat)
);
create sequence stoifl.person_seq start with 1 increment by 1;

--*************************************************
-- KONTAKT
--*************************************************
create table stoifl.kontakt
(
	kontakt_id			numeric(10) not null,
	person_id			numeric(10) not null,
	art_id				numeric(10) not null,
	tel					varchar(100),
	email				varchar(100),
	constraint kontakt_pk primary key (kontakt_id)
);
create sequence stoifl.kontakt_seq start with 1 increment by 1;

--*************************************************
-- ADRESSE
--*************************************************
create table stoifl.adresse
(
	adresse_id			numeric(10) not null,
	person_id			numeric(10) not null,
	art_id				numeric(10) not null,
	strasse				varchar(250),
	hnr					numeric(5),
	ort					varchar(250),
	plz					varchar(50),
	constraint adresse_pk primary key (adresse_id)
);
create sequence stoifl.adresse_seq start with 1 increment by 1;

--*************************************************
-- ART
--*************************************************
create table stoifl.art
(
	art_id				numeric(10) not null,
	bezeichnung			varchar(250) not null,
	
	constraint art_pk primary key (art_id),
	constraint art_bezeichnung_uk unique (bezeichnung)
);
create sequence stoifl.art_seq start with 1 increment by 1;

--*************************************************
-- constraints
--*************************************************

alter table stoifl.link add constraint	  link_kurs_fk      foreign key (kurs_id) references stoifl.kurs (kurs_id);
alter table stoifl.link add constraint	  link_person_fk    foreign key (person_id) references stoifl.person (person_id);
alter table stoifl.kontakt add constraint kontakt_person_fk foreign key (person_id) references stoifl.person (person_id);
alter table stoifl.adresse add constraint adresse_person_fk foreign key (person_id) references stoifl.person (person_id);
alter table stoifl.kontakt add constraint	  kontakt_art_fk      foreign key (art_id) references stoifl.art (art_id);
alter table stoifl.adresse add constraint	  adresse_art_fk      foreign key (art_id) references stoifl.art (art_id);


--*************************************************
-- grants
--*************************************************

GRANT USAGE ON SCHEMA stoifl TO wiffzack;
grant select, insert, update, delete on stoifl.kurs to wiffzack;
grant select, insert, update, delete on stoifl.link to wiffzack;
grant select, insert, update, delete on stoifl.person to wiffzack;
grant select, insert, update, delete on stoifl.adresse to wiffzack;
grant select, insert, update, delete on stoifl.kontakt to wiffzack;
grant select, insert, update, delete on stoifl.art to wiffzack;


GRANT SELECT, USAGE ON SEQUENCE stoifl.kurs_seq to wiffzack;
GRANT SELECT, USAGE ON SEQUENCE stoifl.person_seq to wiffzack;
GRANT SELECT, USAGE ON SEQUENCE stoifl.kontakt_seq to wiffzack;
GRANT SELECT, USAGE ON SEQUENCE stoifl.adresse_seq to wiffzack;
GRANT SELECT, USAGE ON SEQUENCE stoifl.art_seq to wiffzack;

insert into stoifl.art (art_id, bezeichnung) values(nextval('stoifl.art_seq'), 'Privat');
insert into stoifl.art (art_id, bezeichnung) values(nextval('stoifl.art_seq'), 'Firma');

insert into stoifl.kurs (kurs_id, kursnummer, name, startkurs, endekurs, lehreinheiten, raum, maxTN,angemeldet, freiePlaetze) values((select nextval('stoifl.kurs_seq')), 20191, 'Software Entwickler', '2018-10-02', '2019-05-31', 251, 'C240', 12, 0, 12);
insert into stoifl.kurs (kurs_id, kursnummer, name, startkurs, endekurs, lehreinheiten, raum, maxTN,angemeldet, freiePlaetze) values((select nextval('stoifl.kurs_seq')), 20192, 'Stricken', '2018-12-03', '2019-01-04', 56, 'A120', 15, 0, 15);

insert into stoifl.person (person_id, vorname, nachname, gebdat) values((select nextval('stoifl.person_seq')), 'Peter', 'Müller', '1990-05-12');
insert into stoifl.kontakt (kontakt_id, person_id, art_id, tel, email) values((select nextval('stoifl.kontakt_seq')), 1, 1, '06601234567', 'info@mueller.at');
insert into stoifl.adresse (adresse_id, person_id, art_id, strasse, hnr, ort, plz) values((select nextval('stoifl.adresse_seq')), 1, 1, 'Bahnhofstraße', 1, 'Seekirchen', '5201');

insert into stoifl.person (person_id, vorname, nachname, gebdat) values((select nextval('stoifl.person_seq')), 'Manfred', 'Maier', '1985-07-21');
insert into stoifl.kontakt (kontakt_id, person_id, art_id, tel, email) values((select nextval('stoifl.kontakt_seq')), 2, 1, '066435565', 'info@maier.at');
insert into stoifl.adresse (adresse_id, person_id, art_id, strasse, hnr, ort, plz) values((select nextval('stoifl.adresse_seq')), 2, 1, 'Schulstraße', 21, 'Neumarkt', '5204');

insert into stoifl.person (person_id, vorname, nachname, gebdat) values((select nextval('stoifl.person_seq')), 'Christine', 'Stieber', '1994-08-05');
insert into stoifl.kontakt (kontakt_id, person_id, art_id, tel, email) values((select nextval('stoifl.kontakt_seq')), 3, 1, '06767456123', 'info@stieber.at');
insert into stoifl.adresse (adresse_id, person_id, art_id, strasse, hnr, ort, plz) values((select nextval('stoifl.adresse_seq')), 3, 1, 'Weizengasse', 14, 'Salzburg', '5020');











