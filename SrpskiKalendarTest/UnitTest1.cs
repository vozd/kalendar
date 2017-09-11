using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Web;

namespace SrpskiKalendarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        [TestMethod]
        public void UploadImage(string imageData)
        {
            string path = "../kalendari/";

            string fileNameWitPath = path + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png";

            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(imageData);

                    bw.Write(data);

                    bw.Close();
                }
            }
        }
    }
}
