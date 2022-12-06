

using DirectoryDirectoryInfo;
using DirectoryDirectoryInfo.files.notes;

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

             
            }
            catch (IOException error)
            {
                Console.WriteLine("An error occureed");
                Console.WriteLine(error.Message);
            }
        }
    }
}