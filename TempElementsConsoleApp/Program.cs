using System;
using System.IO;
using TempElementsLib;

namespace TempElementsConsoleApp {
    class Program {
        static void Main(string[] args) {
            //using (var tempFile = new TempFile()) {
            //    Console.WriteLine("Wciśnij dowolny klawisz po sprawdzeniu czy plik istnieje");
            //    Console.ReadKey();
            //    Console.WriteLine("Podaj tekst który ma zostać dodany do pliku.");
            //    var text = Console.ReadLine();
            //    tempFile.AddText(text);
            //    Console.WriteLine("Wciśnij dowolny klawisz aby przejść do usunięcia pliku");
            //    Console.ReadKey();
            //}
            //var tempFile2 = new TempFile($"{System.IO.Path.GetTempPath()}temp123.tmp");
            //Console.WriteLine($"Before {tempFile2.FilePath} dispose");
            //tempFile2.Dispose();
            //tempFile2.AddText("2");

            //try {
            //    Console.WriteLine("Podaj ścieżkę do tymczasowego pliku.");
            //    var tempFile4 = new TempFile(Console.ReadLine());
            //} catch (DirectoryNotFoundException e) {
            //    Console.WriteLine("Ścieżka jest niepoprawna. Przynajmniej jeden z folderów nie istnieje.");
            //} catch (ArgumentException e) {
            //    Console.WriteLine("Niepoprawna ścieżka");
            //} 

            //using var tempFile3 = new TempFile();
            //Console.WriteLine("Test c#8 using ");


            //using var tempTxtFile = new TempTxtFile();
            //Console.WriteLine("Wpisywanie do pliku lini test123");
            //tempTxtFile.WriteLine("test123");
            //Console.WriteLine("Wpisywanie do pliku test");
            //tempTxtFile.Write("test");
            //Console.WriteLine("Naciśnij dowolny klawisz gdy sprawdzisz już zawartość pliku.");
            //Console.ReadKey();

            Console.WriteLine("Testowanie tworzenia folderu.");
            var tempDir = new TempDir();
            Console.WriteLine("Po utworzeniu folderu, przed dispose.");
            Console.WriteLine("Wciśnij dowolny klawisz aby usunąć folder.");
            Console.ReadKey();
            tempDir.Dispose();
            Console.WriteLine("Po dispose.");
        }
    }
}
