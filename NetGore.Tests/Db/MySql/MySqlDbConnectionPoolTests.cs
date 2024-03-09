using System.Data;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Db.MySql
{
    [TestFixture]
    public class MySqlDbConnectionPoolTests
    {
        #region Unit tests

        [Test]
        public void ConnectionCloseTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                IDbConnection conn;
                using (var connPool = pool.Acquire())
                {
                    conn = connPool.Connection;
                    connPool.QueryRunner.Flush();
                }
                ClassicAssert.AreEqual(ConnectionState.Closed, conn.State);
            }
        }

        [Test]
        public void ConnectionOpenTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                using (var connPool = pool.Acquire())
                {
                    var conn = connPool.Connection;
                    ClassicAssert.IsNotNull(conn);
                    ClassicAssert.AreEqual(ConnectionState.Open, conn.State);
                }
            }
        }

        [Test]
        public void MultiplePoolItemsTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                ClassicAssert.AreEqual(0, pool.LiveObjects);
                using (var a = pool.Acquire())
                {
                    ClassicAssert.AreEqual(1, pool.LiveObjects);
                    using (var b = pool.Acquire())
                    {
                        ClassicAssert.AreEqual(2, pool.LiveObjects);
                        using (var c = pool.Acquire())
                        {
                            ClassicAssert.AreEqual(3, pool.LiveObjects);
                            ClassicAssert.IsNotNull(a);
                            ClassicAssert.IsNotNull(b);
                            ClassicAssert.IsNotNull(c);
                        }
                        ClassicAssert.AreEqual(2, pool.LiveObjects);
                    }
                    ClassicAssert.AreEqual(1, pool.LiveObjects);
                }
                ClassicAssert.AreEqual(0, pool.LiveObjects);
            }
        }

        [Test]
        public void SelectQueryTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                using (var connPool = pool.Acquire())
                {
                    using (var cmd = connPool.Connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT 100 + 500";
                        using (var r = cmd.ExecuteReader())
                        {
                            r.Read();
                            ClassicAssert.AreEqual(600, r[0]);
                        }
                    }
                }
            }
        }

        #endregion
    }
}