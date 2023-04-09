namespace HomeWork5.App2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(Path.GetFullPath(@"./Program.cs"));
                for (int i = 0; i < 5; i++)
                {
                    di = di.Parent;
                }
                string homeWork12txtPath = di + "/Lesson12Homework.txt";

                StreamReader fs = new StreamReader(homeWork12txtPath);
                string csvPath = fs.ReadToEnd();
                fs.Close();

                // создаём объект StreamReader для считывания информации из csv файла
                StreamReader csvReader = new StreamReader(csvPath);
                // создаём список типа Record для удобного хранения информации о файлах 
                List<Record> records = new List<Record>();
                // считываем данные из csv файла в строку csvline
                string csvline = csvReader.ReadToEnd();
                csvReader.Close();
                // нарезаем строку csvline в массив строк csvLineSplit
                string[] csvlineSplit = csvline.Split('\t');

                for (int i = 0; i < csvlineSplit.Length - 3; i = i + 3)
                {
                    Record temporaryRecord = new Record(csvlineSplit[i], csvlineSplit[i + 1], csvlineSplit[i + 2]);
                    records.Add(temporaryRecord);
                }

                // сортировка списка по дате изменения
                var sortedRecords = from r in records
                                    orderby r.GetDateOfChange()
                                    select r;

                Console.WriteLine("Your files from zip:");
                foreach (Record record in sortedRecords)
                {
                    Console.WriteLine(record.GetType() + ' ' + record.GetName() + ' ' + record.GetDateOfChange());
                }
                File.Delete(homeWork12txtPath);
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
}