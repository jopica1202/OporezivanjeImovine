create database imovina
use imovina
create table vlasnik (
id int identity(1,1),
ime nvarchar(30),
prezime nvarchar(30),
email nvarchar(40) unique,
lozinka nvarchar(30),
)
create table imovina (
id int identity (1,1),
tip_id int,
vlasnik_id int,
adresa nvarchar(50),
grad nvarchar (40),
zona int,
povrsina int,
)
create table zona_oporezivanja(
grad nvarchar(40),
broj_zone int,
cena_kvadrata int,
)
create table gradovi(
naziv nvarchar(40),
poreska_stopa decimal,
)
create table tip_imovine(
id int identity(1,1),
vrsta nvarchar(30),
)
create table cene_kvadrata(
cena int,
grad nvarchar(30),
zona int,
tip_id int,
)
alter table vlasnik
drop column ime, prezime;
select * from vlasnik
alter table imovina 
drop column tip_id, vlasnik_id, grad, zona
insert column cena_id