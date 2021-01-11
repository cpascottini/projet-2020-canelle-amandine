drop table if exists personne;
drop table if exists bd;
drop table if exists relation;

create table personne (
    pers_id integer not null primary key auto_increment,
    pers_login varchar(100) not null,
    pers_mdp varchar(100) not null,
    pers_role varchar(100) not null
);

create table bd (
    bd_id integer not null primary key auto_increment,
    bd_titre varchar(100) not null,
    bd_auteur varchar(100) not null,
    bd_dessinateur varchar(100) not null,
    bd_editeur varchar(100) not null,
    bd_serie varchar(100),
    bd_genre varchar(100) not null,
    bd_couverture varchar(100) not null
);

create table relation (
    rel_id integer not null primary key auto_increment,
    pers_id integer,
    bd_id integer,
    foreign key (pers_id) references personne(pers_id),
    foreign key (bd_id) references bd(bd_id),
    rel_statut varchar(100) not null
);