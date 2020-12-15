drop table if exists personne;
drop table if exists utilisateur;
drop table if exists administrateur;
drop table if exists bd;
drop table if exists marche;

create table personne (
    pers_id integer not null primary key auto_increment,
    pers_login varchar(100) not null,
    pers_mdp varchar(100) not null
);