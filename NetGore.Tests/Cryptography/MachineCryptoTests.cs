﻿using NetGore.Cryptography;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Cryptography
{
    [TestFixture]
    public class MachineCryptoTests
    {
        #region Unit tests

        [Test]
        public void InvalidTest()
        {
            var enc = MachineCrypto.Encode("asdf");
            enc = (char)(enc[0] + 1) + enc.Substring(1);
            var decRaw = MachineCrypto.ValidatedDecode(enc);

            ClassicAssert.IsNull(decRaw);
        }

        [Test]
        public void ValidTest()
        {
            var enc = MachineCrypto.Encode("asdf");
            var dec = MachineCrypto.ValidatedDecode(enc);

            ClassicAssert.AreEqual("asdf", dec);
        }

        #endregion
    }
}