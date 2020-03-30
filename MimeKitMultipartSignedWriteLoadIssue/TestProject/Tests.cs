using MimeKit;
using MimeKit.Cryptography;
using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public async Task Test()
        {
            var entity = await MimeEntity.LoadAsync(Path.Combine(Directory.GetCurrentDirectory(), "signed.txt"));
            Assert.IsInstanceOf<MultipartSigned>(entity);

            var signed = (MultipartSigned)entity;
            Assert.AreEqual(2, signed.Count);
        }
    }
}