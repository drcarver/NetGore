using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NetGore.IO;
using NetGore.World;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using SFML.Graphics;

// ReSharper disable MemberCanBePrivate.Local

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class DynamicEntityTests
    {
        static readonly IDynamicEntityFactory _dynamicEntityFactoryBase = new DynamicEntityFactory();

        #region Unit tests

        [Test]
        public void TestSkipNonSyncNetworkValues()
        {
            var writer = new BitStream(2048);
            var src = new DE { SkipA = 1, SkipB = 2, SkipC = 3 };
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            ClassicAssert.AreNotEqual(src.SkipA, dest.SkipA);
            ClassicAssert.AreNotEqual(src.SkipB, dest.SkipB);
            ClassicAssert.AreEqual(src.SkipC, dest.SkipC);

            src.A = false;
            src.D = 100;
            src.K = 5123;
            src.N = "asfdoiuweroijsadf";
            src.P = Alignment.Left;
            src.M = new GrhIndex(10091);
            src.L = new Vector2(213, 123);
            src.Q = new Vector3(123, 412, 1931);
            src.R = new Vector4(109, 12, 190, 51);

            writer = new BitStream(2048);
            src.Serialize(writer);

            buffer = writer.GetBuffer();

            reader = new BitStream(buffer);
            dest.Deserialize(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            ClassicAssert.AreNotEqual(src.SkipA, dest.SkipA);
            ClassicAssert.AreNotEqual(src.SkipB, dest.SkipB);
            ClassicAssert.AreEqual(src.SkipC, dest.SkipC);
        }

        [Test]
        public void TestSkipNonSyncValues()
        {
            var writer = new BitStream(2048);
            var src = new DE { SkipA = 1, SkipB = 2, SkipC = 3 };
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            ClassicAssert.AreNotEqual(src.SkipA, dest.SkipA);
            ClassicAssert.AreNotEqual(src.SkipB, dest.SkipB);
            ClassicAssert.AreEqual(src.SkipC, dest.SkipC);

            src.A = false;
            src.D = 100;
            src.K = 5123;
            src.N = "asfdoiuweroijsadf";
            src.P = Alignment.Left;
            src.M = new GrhIndex(10091);
            src.L = new Vector2(213, 123);
            src.SkipA = 111;
            src.SkipB = 111;
            src.SkipC = 111;
            src.Q = new Vector3(213, 123, 41);
            src.R = new Vector4(51, 213, 123, 41);

            writer = new BitStream(2048);
            src.Serialize(writer);

            buffer = writer.GetBuffer();

            reader = new BitStream(buffer);
            dest.Deserialize(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            ClassicAssert.AreNotEqual(src.SkipA, dest.SkipA);
            ClassicAssert.AreNotEqual(src.SkipB, dest.SkipB);
            ClassicAssert.AreNotEqual(src.SkipC, dest.SkipC);
        }

        [Test]
        public void TestWrite()
        {
            var writer = new BitStream(2048);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
        }

        [Test]
        public void TestWriteRead()
        {
            var writer = new BitStream(2048);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            _dynamicEntityFactoryBase.Read(reader);
        }

        [Test]
        public void TestWriteReadManyValuesExtensive()
        {
            const int count = 1000;

            var writer = new BitStream(1024 * 1024);
            var sources = new List<DE>(count);
            for (var i = 0; i < count; i++)
            {
                var src = new DE();
                sources.Add(src);
                _dynamicEntityFactoryBase.Write(writer, src);
            }
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            for (var i = 0; i < count; i++)
            {
                var src = sources[i];
                var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

                ClassicAssert.AreEqual(src.Position, dest.Position);
                ClassicAssert.AreEqual(src.Size, dest.Size);
                ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
                ClassicAssert.AreEqual(src.Weight, dest.Weight);
                ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
                ClassicAssert.AreEqual(src.Center, dest.Center);

                ClassicAssert.AreEqual(src.A, dest.A, "Index: " + i);
                ClassicAssert.AreEqual(src.B, dest.B, "Index: " + i);
                ClassicAssert.AreEqual(src.C, dest.C, "Index: " + i);
                ClassicAssert.AreEqual(src.D, dest.D, "Index: " + i);
                ClassicAssert.AreEqual(src.E, dest.E, "Index: " + i);
                ClassicAssert.AreEqual(src.F, dest.F, "Index: " + i);
                ClassicAssert.AreEqual(src.G, dest.G, "Index: " + i);
                ClassicAssert.AreEqual(src.H, dest.H, "Index: " + i);
                ClassicAssert.AreEqual(src.I, dest.I, "Index: " + i);
                ClassicAssert.AreEqual(src.J, dest.J, "Index: " + i);
                ClassicAssert.AreEqual(src.K, dest.K, "Index: " + i);
                ClassicAssert.AreEqual(src.L, dest.L, "Index: " + i);
                ClassicAssert.AreEqual(src.M, dest.M, "Index: " + i);
                ClassicAssert.AreEqual(src.N, dest.N, "Index: " + i);
                ClassicAssert.AreEqual(src.O, dest.O, "Index: " + i);
                ClassicAssert.AreEqual(src.P, dest.P, "Index: " + i);
                ClassicAssert.AreEqual(src.Q, dest.Q, "Index: " + i);
                ClassicAssert.AreEqual(src.R, dest.R, "Index: " + i);
            }
        }

        [Test]
        public void TestWriteReadManyValuesExtensiveXml()
        {
            const int count = 100;

            var filePath = Path.GetTempFileName();

            try
            {
                var sources = new List<DE>(count);
                using (var writer = XmlValueWriter.Create(filePath, "DynamicEntities"))
                {
                    writer.Write("Count", count);
                    for (var i = 0; i < count; i++)
                    {
                        var src = new DE();
                        sources.Add(src);
                        var key = "Entity" + Parser.Invariant.ToString(i);
                        writer.WriteStartNode(key);
                        _dynamicEntityFactoryBase.Write(writer, src);
                        writer.WriteEndNode(key);
                    }
                }

                var reader = XmlValueReader.CreateFromFile(filePath, "DynamicEntities");
                for (var i = 0; i < count; i++)
                {
                    var key = "Entity" + Parser.Invariant.ToString(i);
                    var r = reader.ReadNode(key);

                    var src = sources[i];
                    var dest = (DE)_dynamicEntityFactoryBase.Read(r);

                    ClassicAssert.AreEqual(src.Position, dest.Position);
                    ClassicAssert.AreEqual(src.Size, dest.Size);
                    ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
                    ClassicAssert.AreEqual(src.Weight, dest.Weight);
                    ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
                    ClassicAssert.AreEqual(src.Center, dest.Center);

                    ClassicAssert.AreEqual(src.A, dest.A, "Index: " + i);
                    ClassicAssert.AreEqual(src.B, dest.B, "Index: " + i);
                    ClassicAssert.AreEqual(src.C, dest.C, "Index: " + i);
                    ClassicAssert.AreEqual(src.D, dest.D, "Index: " + i);
                    ClassicAssert.AreEqual(src.E, dest.E, "Index: " + i);
                    ClassicAssert.AreEqual(src.F, dest.F, "Index: " + i);
                    ClassicAssert.AreEqual(src.G, dest.G, "Index: " + i);
                    ClassicAssert.AreEqual(Math.Round(src.H), Math.Round(dest.H), "Index: " + i);
                    ClassicAssert.AreEqual(src.I, dest.I, "Index: " + i);
                    ClassicAssert.AreEqual(src.J, dest.J, "Index: " + i);
                    ClassicAssert.AreEqual(Math.Round(src.K), Math.Round(dest.K), "Index: " + i);
                    ClassicAssert.AreEqual(src.L.Round(), dest.L.Round(), "Index: " + i);
                    ClassicAssert.AreEqual(src.M, dest.M, "Index: " + i);
                    ClassicAssert.AreEqual(src.N, dest.N, "Index: " + i);
                    ClassicAssert.AreEqual(src.O, dest.O, "Index: " + i);
                    ClassicAssert.AreEqual(src.P, dest.P, "Index: " + i);
                    ClassicAssert.AreEqual(src.Q.Round(), dest.Q.Round(), "Index: " + i);
                    ClassicAssert.AreEqual(src.R.Round(), dest.R.Round(), "Index: " + i);
                }
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
        }

        [Test]
        public void TestWriteReadValues()
        {
            var writer = new BitStream(1024);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);
        }

        [Test]
        public void TestWriteReadValuesAndUpdateExtensive()
        {
            var writer = new BitStream(2048);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            src.A = false;
            src.D = 100;
            src.K = 5123;
            src.N = "asfdoiuweroijsadf";
            src.P = Alignment.Left;
            src.M = new GrhIndex(10091);
            src.L = new Vector2(213, 123);

            writer = new BitStream(2048);
            src.Serialize(writer);

            buffer = writer.GetBuffer();

            reader = new BitStream(buffer);
            dest.Deserialize(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);
        }

        [Test]
        public void TestWriteReadValuesAndUpdatePositionVelocity()
        {
            var writer = new BitStream(2048);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);

            src.Position = new Vector2(10981, -123);
            src.SetVelocity(new Vector2(0.114f, 10.181f));

            writer = new BitStream(2048);
            src.SerializePositionAndVelocity(writer, 0);

            buffer = writer.GetBuffer();

            reader = new BitStream(buffer);
            dest.DeserializePositionAndVelocity(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);
        }

        [Test]
        public void TestWriteReadValuesExtensive()
        {
            var writer = new BitStream(2048);
            var src = new DE();
            _dynamicEntityFactoryBase.Write(writer, src);
            var buffer = writer.GetBuffer();

            var reader = new BitStream(buffer);
            var dest = (DE)_dynamicEntityFactoryBase.Read(reader);

            ClassicAssert.AreEqual(src.Position, dest.Position);
            ClassicAssert.AreEqual(src.Size, dest.Size);
            ClassicAssert.AreEqual(src.Velocity, dest.Velocity);
            ClassicAssert.AreEqual(src.Weight, dest.Weight);
            ClassicAssert.AreEqual(src.MapEntityIndex, dest.MapEntityIndex);
            ClassicAssert.AreEqual(src.Center, dest.Center);

            ClassicAssert.AreEqual(src.A, dest.A);
            ClassicAssert.AreEqual(src.B, dest.B);
            ClassicAssert.AreEqual(src.C, dest.C);
            ClassicAssert.AreEqual(src.D, dest.D);
            ClassicAssert.AreEqual(src.E, dest.E);
            ClassicAssert.AreEqual(src.F, dest.F);
            ClassicAssert.AreEqual(src.G, dest.G);
            ClassicAssert.AreEqual(src.H, dest.H);
            ClassicAssert.AreEqual(src.I, dest.I);
            ClassicAssert.AreEqual(src.J, dest.J);
            ClassicAssert.AreEqual(src.K, dest.K);
            ClassicAssert.AreEqual(src.L, dest.L);
            ClassicAssert.AreEqual(src.M, dest.M);
            ClassicAssert.AreEqual(src.N, dest.N);
            ClassicAssert.AreEqual(src.O, dest.O);
            ClassicAssert.AreEqual(src.P, dest.P);
            ClassicAssert.AreEqual(src.Q, dest.Q);
            ClassicAssert.AreEqual(src.R, dest.R);
        }

        #endregion

        class DE : DynamicEntity
        {
            public DE() : base(Vector2.Zero, Vector2.One)
            {
                A = true;
                B = 5;
                C = 9;
                D = 10;
                E = 1001;
                F = 24;
                G = 109312213;
                H = 10213.989f;
                I = 1209812;
                J = 1098123091;
                K = 12312.10329812;
                L = new Vector2(120312, 12039);
                M = new GrhIndex(101);
                N = "afoiwurekj sadfoiwerkjl asdfa1309813";
                O = new Color(13, 124, 11, 12);
                P = Alignment.Center;
                Q = new Vector3(51, 1231, 52);
                R = new Vector4(501, 1238, 61, 1231);
            }

            [SyncValue]
            public bool A { get; set; }

            [SyncValue]
            public byte B { get; set; }

            [SyncValue]
            public sbyte C { get; set; }

            /// <summary>
            /// When overridden in the derived class, gets if this <see cref="Entity"/> will collide against
            /// walls. If false, this <see cref="Entity"/> will pass through walls and completely ignore them.
            /// </summary>
            public override bool CollidesAgainstWalls
            {
                get { return true; }
            }

            [SyncValue]
            public short D { get; set; }

            [SyncValue]
            public ushort E { get; set; }

            [SyncValue]
            public int F { get; set; }

            [SyncValue]
            public uint G { get; set; }

            [SyncValue]
            public float H { get; set; }

            [SyncValue]
            public long I { get; set; }

            [SyncValue]
            public ulong J { get; set; }

            [SyncValue]
            public double K { get; set; }

            [SyncValue]
            public Vector2 L { get; set; }

            [SyncValue]
            public GrhIndex M { get; set; }

            [SyncValue]
            public string N { get; set; }

            [SyncValue]
            public Color O { get; set; }

            [SyncValue]
            public Alignment P { get; set; }

            [SyncValue]
            public Vector3 Q { get; set; }

            [SyncValue]
            public Vector4 R { get; set; }

            public int SkipA { get; set; }
            public byte SkipB { get; set; }

            [SyncValue(SkipNetworkSync = true)]
            public short SkipC { get; set; }
        }

        class DynamicEntityFactory : DynamicEntityFactoryBase
        {
        }
    }
}