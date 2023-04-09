using System.IO.Compression;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //указание путей к архивируемой папке, архиву и папке извлечения
            //string startPath = @".\start";
            string zipPath = @".\result.zip";
            string extractPath = @".\extract";

            //создание папок и файлов хранящихся в архиве
            /*string textFile1Path = @".\start\text1.txt";
            string textFile2Path = @".\start\text2.txt";
            string subFolderPath = @".\start\subfolder";
            Directory.CreateDirectory(startPath);
            FileStream text1FileStream = File.Create(textFile1Path);
            text1FileStream.Close();
            Thread.Sleep(1000);
            FileStream text2FileStream = File.Create(textFile2Path);
            text2FileStream.Close();
            Directory.CreateDirectory(subFolderPath);
            */

            //архивирование получившейся папки
            //ZipFile.CreateFromDirectory(@".\start\", zipPath);
            //извлечение данных из архива в новую папку
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            //запись информации о всех файлах из архива в csv файл и сохранение пути к нему в txt файле
            string[] directoriesList = Directory.GetDirectories(extractPath);
            string[] filesList = Directory.GetFiles(extractPath);
            string fullZipInfo = @".\filesInfo.csv";
            FileStream fileStream = File.Create(fullZipInfo);
            fileStream.Close();
            string fullInfo = "";
            // цикл для записи данных о директориях
            for (int i = 0; i < directoriesList.Length; i++)
            {
                FileInfo di = new FileInfo(directoriesList[i]);
                string fullDirectoriesInfo = ".folder" + '\t' + di.Name + "\t" + File.GetLastWriteTime(directoriesList[i]) + '\t';
                fullInfo += fullDirectoriesInfo;
            }
            // цикл для записи данных о файлах
            for (int i = 0; i < filesList.Length; i++)
            {
                FileInfo fi = new FileInfo(filesList[i]);
                string fullFilesInfo = fi.Extension + "\t" + fi.Name + '\t' + File.GetLastWriteTime(filesList[i]) + '\t';
                fullInfo += fullFilesInfo;
            }
            File.WriteAllText(fullZipInfo, fullInfo);
            DirectoryInfo directoryInfo = new DirectoryInfo(extractPath);
            for (int i = 0; i < 5; i++)
            {
                directoryInfo = directoryInfo.Parent;
            }
            string lesson12Path = @"" + directoryInfo + "/Lesson12Homework.txt";
            File.WriteAllText(lesson12Path, Path.GetFullPath(fullZipInfo));

            //удаление лишних файлов
            Directory.Delete(extractPath, true);
            //File.Delete(zipPath);
            //Directory.Delete(startPath, true);

            Console.WriteLine("The work is done! Your zip-info is ready, it`s time to start another app :)");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Запрашиваемый файл не найден.");
        }
        catch (IOException)
        {
            Console.WriteLine("Ошибка ввода/вывода.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Недостаточно прав для работы с файлом.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Возникла ошибка: " + ex.ToString());
        }
    }
}