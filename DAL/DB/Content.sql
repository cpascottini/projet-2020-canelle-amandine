insert into bd values (1,"Le pourpre et l'or",'Jean Dufaux','Philippe Delaby','Dargaud','Murena','historique','lePourpreEtLOr.jpg');
insert into bd values (2,'Ame rouge','Juan Diaz Canales','Juanjo Guarnido','Dargaud','Blacksad','policier','ameRouge.jpg');
insert into bd values (3,'Astérix le Gaulois','René Goscinny','Albert Uderzo','Hachette','Astérix','aventure','asterixLeGaulois.jpg');
insert into bd values (4,'Persepolis-Tome 3','Marjane Satrapi','Marjane Satrapi',"L'association",'Persepolis','autobiographie','persepolis3.jpg');

insert into personne values (1,'fanDeBd','bonjour','utilisateur');
insert into personne values (2,'admin1','gestion','administrateur');
insert into personne values (3,'roger','vivelabd','utilisateur');

insert into relation values(1,1,1,'possede');
insert into relation values(2,1,2,'veut');
insert into relation values(3,3,1,'possede');
insert into relation values(4,3,4,'possede');
insert into relation values(5,3,3,'veut');