using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    class RepositoryTest : Repository
    {
        internal static void ResetSchema()
        {
            Session.Clear();
            new SchemaExport(Configuration).Execute(false,true,false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();

            Execute(
                "insert into bd values(1, 'Les bijoux de la Castafiore', 'Hergé', 'Hergé', 'Casterman', 'Tintin', 21, 'aventure', 'BD', 'lesBijouxDeLaCastafiore.jpg');" +
                "insert into bd values(2,'Ame rouge','Juan Diaz Canales','Juanjo Guarnido','Dargaud','Blacksad', 3,'policier','BD', 'ameRouge.jpg');" +
                "insert into bd values(3,'Astérix le Gaulois','René Goscinny','Albert Uderzo','Hachette','Astérix', 1,'aventure','BD', 'asterixLeGaulois.jpg');" +
                "insert into bd values(4,'Persepolis - Tome 3','Marjane Satrapi','Marjane Satrapi','L''association','Persepolis', 3, 'autobiographie','BD', 'persepolis3.jpg');"+
                "insert into bd values(5,'Journal infime' , 'Julien Neel' , 'Julien Neel', 'Glénat', 'Lou !' , 1,  'jeunesse' , 'BD', 'journalInfime.jpeg');" +
                "insert into bd values(6,'Mortebouse' , 'Julien Neel' , 'Julien Neel', 'Glénat', 'Lou !' , 2,  'jeunesse' , 'BD', 'mortebouse.jpg');"
                );
            Execute(
                "insert into personne values(1,'fanDeBd','bonjour','utilisateur');"+
                "insert into personne values(2,'admin1','gestion','administrateur');"+
                "insert into personne values(3,'roger','vivelabd','utilisateur');"
                );
            Execute(
               "insert into relation values(1,1,1,'possede');"+
               "insert into relation values(2,1,2,'veut');"+
               "insert into relation values(3,3,1,'possede');"+
               "insert into relation values(4,3,4,'possede');"+
               "insert into relation values(5,3,3,'veut');"
               );
        }
    }
}
