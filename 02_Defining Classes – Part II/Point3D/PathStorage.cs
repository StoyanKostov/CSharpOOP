using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePath(Path currentPath)
        {

            using (StreamWriter writer = new StreamWriter(@"../../savedPaths.txt"))
            {
                foreach (var i in currentPath.PointHolder)
                {
                    writer.WriteLine(String.Format("({0},{1},{2})", i.X, i.Y, i.Z));
                    writer.Flush();
                }
            }
        }

        internal static Path LoadPath()
        {
            Path loadPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(@"../../savedPaths.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        String line = reader.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found, try adding a new file");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            return loadPath;
        }
    }
}
