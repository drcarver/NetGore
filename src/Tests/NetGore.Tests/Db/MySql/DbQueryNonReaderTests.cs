using System.Data.Common;

using NetGore.Db;

namespace NetGore.Tests.Db.MySql
{
    [TestFixture]
    public class DbQueryNonReaderTests
    {
        [Test]
        public void SelectTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                using (var nonReader = new MyNonReader(pool))
                {
                    for (var i = 0; i < 10; i++)
                    {
                        nonReader.Execute(new QueryTestValues(5, 10, 15));
                    }

                    nonReader.ConnectionPool.QueryRunner.Flush();
                }
            }
        }

        class MyNonReader : DbQueryNonReader<QueryTestValues>
        {
            const string _commandText = "SELECT @a + @b + @c";

            public MyNonReader(DbConnectionPool connectionPool) : base(connectionPool, _commandText)
            {
            }

            /// <summary>
            /// When overridden in the derived class, creates the parameters this class uses for creating database queries.
            /// </summary>
            /// <returns>IEnumerable of all the DbParameters needed for this class to perform database queries. If null,
            /// no parameters will be used.</returns>
            protected override IEnumerable<DbParameter> InitializeParameters() => CreateParameters("a", "b", "c");

            protected override void SetParameters(DbParameterValues p, QueryTestValues item)
            {
                throw new NotImplementedException();
            }
        }
    }
}