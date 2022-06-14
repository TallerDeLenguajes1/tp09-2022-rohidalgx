Console.WriteLine("Ingrese un path");

string? carpetaPath = Console.ReadLine();

if (!Directory.Exists(carpetaPath)) return;

List<string> listadoDeCarpetas = Directory.GetDirectories(carpetaPath).ToList();
string nombreArchivo = carpetaPath + @"\index.csv";
FileStream fileStream;

if (!File.Exists(nombreArchivo))
{
    fileStream = File.Create(nombreArchivo);
    fileStream.Close();
}

using (fileStream = new FileStream(nombreArchivo, FileMode.OpenOrCreate))
using (var streamWriter = new StreamWriter(fileStream))
{
    var contador = 0;

    foreach (string carpeta in listadoDeCarpetas)
    {
        streamWriter.Write(contador + ";");
        streamWriter.WriteLine(new DirectoryInfo(carpeta).Name + ";");
        contador++;
    }

    foreach (string archivo in Directory.GetFiles(carpetaPath))
    {
        Console.WriteLine(archivo);
        streamWriter.Write(contador + ";");
        streamWriter.Write(Path.GetFileNameWithoutExtension(archivo) + ";" + Path.GetExtension(archivo) + "\n");
        contador++;
    }

}