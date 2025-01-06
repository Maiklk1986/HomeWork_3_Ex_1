using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к папке: ");
            string filePath = Console.ReadLine();
            if (string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("Путь не может быть пустым!");
                return;
            }
            DeleteDirectory(filePath);
        }

        public static void DeleteDirectory(string path)
        {

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (dirInfo.Exists) // Проверим, что директория существует
                {
                    if (DateTime.Now - dirInfo.LastAccessTime > TimeSpan.FromMinutes(30))
                    {
                        //Console.WriteLine(DateTime.Now - dirInfo.LastAccessTime);
                        dirInfo.Delete(true); // Удаление со всем содержимым
                        Console.WriteLine("Каталог удален");
                    }
                }
                else Console.WriteLine("Папки с таким адресом не существует!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
