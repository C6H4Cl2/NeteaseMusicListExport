using NeteaseMusicListExport.Util;
using NeteaseMusicListExport.Util.Export;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Export recent songs to m3u file.");
            Console.WriteLine("How many songs do you want to export:");

            string input = Console.ReadLine();

            try
            {
                string exportPath = Directory.GetCurrentDirectory();

                int size = Convert.ToInt32(input);
                LibraryDatabaseController libraryDatabaseController = new LibraryDatabaseController();
                Export2m3u.ExportTracks(libraryDatabaseController.SelectRecentTracks(size), exportPath);

                Console.WriteLine("Export to: " + exportPath);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
