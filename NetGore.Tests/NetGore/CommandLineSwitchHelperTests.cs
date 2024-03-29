﻿using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class CommandLineSwitchHelperTests
    {
        readonly string[] _defaultTestArgs = new string[]
        { "my main value", "-a", "50", "-b", "20", "asdf", "--c", "asdfa", "-d" };

        #region Unit tests

        [Test]
        public void EnumDefinedKeysExtraPrefixesTest()
        {
            var values = CommandLineSwitchHelper.GetCommandsUsingEnum<TestEnum>(_defaultTestArgs).ToDictionary(x => x.Key,
                x => x.Value);
            ClassicAssert.AreEqual("asdfa", values[TestEnum.c].First());
        }

        [Test]
        public void EnumDefinedKeysNoValueTest()
        {
            var values = CommandLineSwitchHelper.GetCommandsUsingEnum<TestEnum>(_defaultTestArgs).ToDictionary(x => x.Key,
                x => x.Value);
            ClassicAssert.IsEmpty(values[TestEnum.d]);
        }

        [Test]
        public void EnumDefinedKeysUnknownKeyTest()
        {
            var values = CommandLineSwitchHelper.GetCommandsUsingEnum<TestEnum>(_defaultTestArgs).ToDictionary(x => x.Key,
                x => x.Value);
            ClassicAssert.AreEqual(3, values.Count);
        }

        [Test]
        public void EnumDefinedKeysValueTest()
        {
            var values = CommandLineSwitchHelper.GetCommandsUsingEnum<TestEnum>(_defaultTestArgs).ToDictionary(x => x.Key,
                x => x.Value);
            ClassicAssert.AreEqual("50", values[TestEnum.a].First());
        }

        [Test]
        public void MainKeyTest()
        {
            var values = CommandLineSwitchHelper.GetCommands(_defaultTestArgs).ToDictionary(x => x.Key, x => x.Value);
            ClassicAssert.AreEqual("my main value", values[CommandLineSwitchHelper.PrimaryKeyName].First());
        }

        [Test]
        public void SimpleSwitch1ValueTest()
        {
            var values = CommandLineSwitchHelper.GetCommands(_defaultTestArgs).ToDictionary(x => x.Key, x => x.Value);
            ClassicAssert.AreEqual("50", values["a"].First());
        }

        [Test]
        public void SimpleSwitch2ValueTest()
        {
            var values = CommandLineSwitchHelper.GetCommands(_defaultTestArgs).ToDictionary(x => x.Key, x => x.Value);
            ClassicAssert.AreEqual("20", values["b"][0]);
            ClassicAssert.AreEqual("asdf", values["b"][1]);
        }

        [Test]
        public void SimpleSwitchExtraPrefixesTest()
        {
            var values = CommandLineSwitchHelper.GetCommands(_defaultTestArgs).ToDictionary(x => x.Key, x => x.Value);
            ClassicAssert.AreEqual("asdfa", values["c"].First());
        }

        [Test]
        public void SimpleSwitchNoValueTest()
        {
            var values = CommandLineSwitchHelper.GetCommands(_defaultTestArgs).ToDictionary(x => x.Key, x => x.Value);
            ClassicAssert.IsEmpty(values["d"]);
        }

        #endregion

        enum TestEnum
        {
            a,
            c,
            d
        }
    }
}