using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using NetGore.Db;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Db.MySql
{
    [TestFixture]
    public class MySqlDbManagerTests
    {
        #region Unit tests

        [Test]
        public void CleanupCommandsTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                var stack = new Stack<IDbCommand>();

                ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects);
                for (var i = 1; i < 20; i++)
                {
                    var item = manager.GetCommand();
                    stack.Push(item);
                    ClassicAssert.AreEqual(i, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                }

                while (stack.Count > 0)
                {
                    var item = stack.Pop();
                    var start = manager.ConnectionPool.LiveObjects;
                    item.Dispose();
                    ClassicAssert.AreEqual(start - 1, manager.ConnectionPool.LiveObjects);
                }

                ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects);
            }
        }

        [Test]
        public void CleanupConnectionsTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                var stack = new Stack<IPoolableDbConnection>();

                ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects);
                for (var i = 1; i < 20; i++)
                {
                    var item = manager.GetConnection();
                    stack.Push(item);
                    ClassicAssert.AreEqual(i, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                }

                while (stack.Count > 0)
                {
                    var item = stack.Pop();
                    var start = manager.ConnectionPool.LiveObjects;
                    item.Dispose();
                    ClassicAssert.AreEqual(start - 1, manager.ConnectionPool.LiveObjects);
                }

                ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects);
            }
        }

        [Test]
        public void CommandParametersTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));

                    IDbCommand cmd;
                    using (cmd = manager.GetCommand())
                    {
                        ClassicAssert.AreEqual(1, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                        ClassicAssert.IsNotNull(cmd);

                        cmd.CommandText = "SELECT @left + @right";

                        var left = new MySqlParameter("@left", null) { Value = 500 };
                        var right = new MySqlParameter("@right", null) { Value = 100 };
                        cmd.Parameters.Add(left);
                        cmd.Parameters.Add(right);

                        using (var r = cmd.ExecuteReader())
                        {
                            r.Read();
                            ClassicAssert.AreEqual("600", r[0].ToString());
                        }

                        ClassicAssert.AreNotEqual(0, cmd.Parameters.Count);
                        ClassicAssert.IsFalse(string.IsNullOrEmpty(cmd.CommandText));
                    }
                }
            }
        }

        [Test]
        public void CommandStringTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                    using (var cmd = manager.GetCommand("SELECT 500 + 100"))
                    {
                        ClassicAssert.AreEqual(1, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                        ClassicAssert.IsNotNull(cmd);
                        ClassicAssert.AreEqual("SELECT 500 + 100", cmd.CommandText);
                        using (var r = cmd.ExecuteReader())
                        {
                            r.Read();
                            ClassicAssert.AreEqual("600", r[0].ToString());
                        }
                    }
                }
            }
        }

        [Test]
        public void CommandTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                    IDbCommand cmd;
                    using (cmd = manager.GetCommand())
                    {
                        ClassicAssert.AreEqual(1, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                        ClassicAssert.IsNotNull(cmd);
                        cmd.CommandText = "SELECT 500 + 100";
                        using (var r = cmd.ExecuteReader())
                        {
                            r.Read();
                            ClassicAssert.AreEqual("600", r[0].ToString());
                        }
                    }
                }
            }
        }

        [Test]
        public void ConnectionTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    ClassicAssert.AreEqual(0, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                    IPoolableDbConnection pConn;
                    IDbConnection conn;
                    using (pConn = manager.GetConnection())
                    {
                        ClassicAssert.AreEqual(1, manager.ConnectionPool.LiveObjects, string.Format("Iteration {0}", i));
                        conn = pConn.Connection;
                        ClassicAssert.IsNotNull(conn);
                        ClassicAssert.AreEqual(ConnectionState.Open, conn.State);
                    }
                    ClassicAssert.AreEqual(ConnectionState.Closed, conn.State);
                }
            }
        }

        [Test]
        public void ExecuteNonQueryTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    var ret = manager.ExecuteNonQuery("SELECT 500 + 100");
                    ClassicAssert.AreEqual(-1, ret);
                }
            }
        }

        [Test]
        public void ExecuteReader2Test()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    using (var r = manager.ExecuteReader("SELECT 500 + 100", CommandBehavior.SingleResult))
                    {
                        ClassicAssert.IsFalse(r.IsClosed);
                        r.Read();
                        ClassicAssert.AreEqual("600", r[0].ToString());
                    }
                }
            }
        }

        [Test]
        public void ExecuteReaderTest()
        {
            using (var pool = DbManagerTestSettings.CreateConnectionPool())
            {
                var manager = new DbManager(pool);
                for (var i = 0; i < 10; i++)
                {
                    using (var r = manager.ExecuteReader("SELECT 500 + 100"))
                    {
                        ClassicAssert.IsFalse(r.IsClosed);
                        r.Read();
                        ClassicAssert.AreEqual("600", r[0].ToString());
                    }
                }
            }
        }

        #endregion
    }
}