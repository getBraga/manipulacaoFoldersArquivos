

using DirectoryDirectoryInfo;
using DirectoryDirectoryInfo.files.notes;
using System;

namespace DirectoryDirectoryInfo
{
    class Program
    {
     
        static void Main(string[] args)
        {
          
            try
            {
                PathFile path = new PathFile();
                IEnumerable<string> folders = Directory.EnumerateDirectories(path.UpdateSourcePath(), "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                PathFile filesFolders = new PathFile();
                var files = Directory.EnumerateFiles(filesFolders.UpdateSourcePath(), "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files");
                foreach (string folder in files)
                {
                    Console.WriteLine(folder);
                }
                Directory.CreateDirectory(path.UpdateSourcePath() + @"/newFolder");

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(filesFolders.UpdateFileDefaultText1()));
                Console.WriteLine("GetFileName: " + Path.GetFileName(filesFolders.UpdateFileDefaultText1()));
                Console.WriteLine("GetExtension: " + Path.GetExtension(filesFolders.UpdateFileDefaultText1()));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(filesFolders.UpdateFileDefaultText1()));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(filesFolders.UpdateFileDefaultText1()));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch (IOException error)
            {
                Console.WriteLine("An error occureed");
                Console.WriteLine(error.Message);
            }
        }
    }
}