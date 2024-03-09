using System;
using System.Linq;
using NetGore.Content;
using NetGore.IO;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore.IO
{
    [TestFixture]
    public class ContentAssetNameTests
    {
        #region Unit tests

        [Test]
        public void FromAbsoluteFilePathAlternateSeparatorDeepTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:/whatever/path/to/mycontent/is/super/awesome",
                @"C:/whatever/path/to");
            ClassicAssert.AreEqual(@"mycontent/is/super/awesome".Replace("/", ContentAssetName.PathSeparator), n.Value);
        }

        [Test]
        public void FromAbsoluteFilePathAlternateSeparatorTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:/whatever/path/to/mycontent", @"C:/whatever/path/to");
            ClassicAssert.AreEqual("mycontent", n.Value);
        }

        [Test]
        public void FromAbsoluteFilePathCapsTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:\whatever\path\to\mycontent".ToUpper(), @"C:\whatever\path\to");
            ClassicAssert.AreEqual("mycontent", n.Value.ToLower());
        }

        [Test]
        public void FromAbsoluteFilePathDeepTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:\whatever\path\to\mycontent\is\super\awesome",
                @"C:\whatever\path\to");
            ClassicAssert.AreEqual(@"mycontent\is\super\awesome".Replace("\\", ContentAssetName.PathSeparator), n.Value);
        }

        [Test]
        public void FromAbsoluteFilePathTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:\whatever\path\to\mycontent", @"C:\whatever\path\to");
            ClassicAssert.AreEqual("mycontent", n.Value);
        }

        [Test]
        public void FromAbsoluteFilePathTrailingSlashTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:\whatever\path\to\mycontent", @"C:\whatever\path\to\");
            ClassicAssert.AreEqual("mycontent", n.Value);
        }

        [Test]
        public void FromAbsoluteFilePathWithSuffixCapsTest()
        {
            var n =
                ContentAssetName.FromAbsoluteFilePath(
                    (@"C:\whatever\path\to\mycontent" + ContentPaths.ContentFileSuffix).ToUpper(), @"C:\whatever\path\to");
            ClassicAssert.AreEqual("mycontent", n.Value.ToLower());
        }

        [Test]
        public void FromAbsoluteFilePathWithSuffixTest()
        {
            var n = ContentAssetName.FromAbsoluteFilePath(@"C:\whatever\path\to\mycontent" + ContentPaths.ContentFileSuffix,
                @"C:\whatever\path\to");
            ClassicAssert.AreEqual("mycontent", n.Value);
        }

        [Test]
        public void SanitizeAlternateSeparatorTest()
        {
            const string s = @"asdf/basdf/wer/asdf";
            ClassicAssert.AreEqual(s.Replace("/", ContentAssetName.PathSeparator), ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizePrefixedAlternateSeparatorTest()
        {
            const string s = @"/asdf";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizePrefixedAndSuffixedAlternateSeparatorTest()
        {
            const string s = @"/asdf/";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizePrefixedAndSuffixedSeparatorTest()
        {
            const string s = @"\asdf\";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizePrefixedSeparatorTest()
        {
            const string s = @"\asdf";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizeSeparatorTest()
        {
            const string s = @"asdf\basdf\wer\asdf";
            ClassicAssert.AreEqual(s.Replace("\\", ContentAssetName.PathSeparator), ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizeSuffixedAlternateSeparatorTest()
        {
            const string s = @"asdf/";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        [Test]
        public void SanitizeSuffixedSeparatorTest()
        {
            const string s = @"asdf\";
            ClassicAssert.AreEqual("asdf", ContentAssetName.Sanitize(s));
        }

        #endregion
    }
}