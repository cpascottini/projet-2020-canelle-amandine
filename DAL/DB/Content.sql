﻿insert into bd values (1,'Les bijoux de la Castafiore','Hergé','Hergé','Casterman','Tintin','aventure','lesBijouxDeLaCastafiore.jpg');
insert into bd values (2,'Ame rouge','Juan Diaz Canales','Juanjo Guarnido','Dargaud','Blacksad','policier','ameRouge.jpg');
insert into bd values (3,'Astérix le Gaulois','René Goscinny','Albert Uderzo','Hachette','Astérix','aventure','asterixLeGaulois.jpg');
insert into bd values (4,'Persepolis-Tome 3','Marjane Satrapi','Marjane Satrapi',"L'association",'Persepolis','autobiographie','persepolis3.jpg');
insert into bd values (5,'Journal infime' , 'Julien Neel' , 'Julien Neel', 'Glénat', 'Lou !' , 'jeunesse' , 'journalInfime.jpeg');
insert into bd values (6,'Mortebouse' , 'Julien Neel' , 'Julien Neel', 'Glénat', 'Lou !' , 'jeunesse' , 'mortebouse.jpg');
insert into bd values (7,'Le cimetière des autobus' , 'Julien Neel' , 'Julien Neel', 'Glénat', 'Lou !' , 'jeunesse' , 'leCimetiereDesAutobus.jpg');
insert into bd values (8,'Les Schtroumpfs olympiques' , 'Peyo' , 'Peyo', 'Dupuis', 'Les Schtroumpfs' , 'jeunesse' , 'lesSchtroumpfsOlympiques.jpg');
insert into bd values (9,'La Soupe aux Schtroumpfs' ,'Peyo' , 'Peyo', 'Dupuis', 'Les Schtroumpfs' , 'jeunesse' , 'laSoupeAuxSchtroumpfs.jpg');
insert into bd values (10,'Le Cosmoschtroumpf' ,'Peyo' , 'Peyo', 'Dupuis', 'Les Schtroumpfs' , 'jeunesse' , 'leCosmoschtroumpf.jpg');
insert into bd values (11,'Faux départ !' ,'Cauvin' , 'Laudec', 'Dupuis', 'Cédric' , 'humour' , 'fauxDepart.jpg');
insert into bd values (12,'Graine de star' ,'Cauvin' , 'Laudec', 'Dupuis', 'Cédric' , 'humour' , 'graineDeStar.jpg');
insert into bd values (13,'La nuit de Saint-Germain-des-Prés','Léo Malet','Emmanuel Moynot','Casterman','Nestor Burma','policier','laNuitDeSaintGermainDesPres.jpg');
insert into bd values (14,'Revers de fortune','Alain Ayroles','Jean-Luc Masbou','Delcourt','De cape et de crocs','aventure','reversDeFortune.jpg');
insert into bd values (15,'Maus','Art Spiegelman','Art Spiegelman','Flammarion',null,'historique','maus.jpg');
insert into bd values (16,"La pourpre et l'or",'Jean Dufaux','Philippe Delaby','Dargaud','Murena','historique','laPourpreEtLOr.jpg');
insert into bd values (17,'Quartier lointain','Jirô Taniguchi','Jirô Taniguchi','Casterman',null,'vie','quartierLointain.jpg');
insert into bd values (18, 'Naruto - Tome 9', 'Masashi Kishimoto','Masashi Kishimoto','Kana Eds','Naruto','shonen', 'naruto9.jpg');
insert into bd values (19, 'Naruto - Tome 6', 'Masashi Kishimoto','Masashi Kishimoto','Kana Eds','Naruto','shonen', 'naruto6.jpg');
insert into bd values (20, 'À la rencontre de maître Chavipère', 'Eiichiro Oda', 'Eiichiro Oda', 'Glénat', 'One Piece', 'shonen', 'onePiece81.jpeg');
insert into bd values (21, 'Déclaration de guerre', 'Eiichiro Oda', 'Eiichiro Oda', 'Glénat', 'One Piece', 'shonen', 'onePiece41.jpg');
insert into bd values (22, 'La saga du Phénix Noir', 'Chris Claremont', 'John Byrne', 'Panini Comics', 'X-Men', 'science fiction', 'laSagaDuPhenixNoir.jpg');

insert into personne values (1,'fanDeBd','bonjour','utilisateur');
insert into personne values (2,'admin1','gestion','administrateur');
insert into personne values (3,'roger','vivelabd','utilisateur');

insert into relation values(1,1,1,'possede');
insert into relation values(2,1,2,'veut');
insert into relation values(3,3,1,'possede');
insert into relation values(4,3,4,'possede');
insert into relation values(5,3,3,'veut');
insert into relation values(6,1,10,'possede');
insert into relation values(7,1,14,'possede');