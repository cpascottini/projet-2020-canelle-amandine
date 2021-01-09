using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    [TestClass]
    public class TestRepository : Repository
    {
        internal static void ResetSchema()
        {
            Session.Clear();
            new SchemaExport(Configuration).Execute(false, true, false);
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
    }
}
