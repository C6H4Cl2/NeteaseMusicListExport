using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeteaseMusicListExport.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Util
{
    [TestClass]
    public class LibraryDatabaseControllerTest
    {
        [TestMethod]
        public void TestSelectRecentTracks()
        {
            LibraryDatabaseController libraryDatabaseController = new LibraryDatabaseController();

            var result = libraryDatabaseController.SelectRecentTracks(10);

            Assert.IsNotNull(result);
        }
    }
}