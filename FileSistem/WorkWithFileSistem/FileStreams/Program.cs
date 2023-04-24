using WorkWithFileSistem;

#region Initial setap

TextHelper.TextGenerator("Check if the folder exists.", ConsoleColor.Cyan);
string relativeFolderPath = "../../../StreamFolder";

if (Directory.Exists(relativeFolderPath))
{
    Directory.CreateDirectory(relativeFolderPath);
    TextHelper.TextGenerator("Folder Created." , ConsoleColor.Green);
}

TextHelper.TextGenerator("Check if the file exist.", ConsoleColor.Cyan);
string relativeFilePath = relativeFolderPath + "/streamFole.txt";

if (!File.Exists(relativeFilePath))
{
    File.Create(relativeFilePath).Close();
    TextHelper.TextGenerator("File created." ,ConsoleColor.Green);
}


#endregion

#region File manipulation with streams
TextHelper.TextGenerator("\n\n\nWriting in the newly created file with the StreamWriter.", ConsoleColor.Cyan);

StreamWriter sw = new StreamWriter(relativeFilePath);
sw.WriteLine("Hello Guys");
sw.WriteLine("I am writing in a filie with streamWriter Guys");
sw.WriteLine("By guys");
sw.Close();

TextHelper.TextGenerator("\n\n\nWriting in the file completed.", ConsoleColor.Cyan);

TextHelper.TextGenerator("\n\n\nWriting in the newly created file with the StreamWriter. But we are using [USING]", ConsoleColor.Cyan);

using (sw = new StreamWriter(relativeFilePath , true))
{
    sw.WriteLine("Hello guys we are in the USING");
    sw.WriteLine("Bye bye Guys");
    TextHelper.TextGenerator("\nWriting in the file completed. And stream is closed", ConsoleColor.Green);

}
using (StreamReader sr = new StreamReader(relativeFilePath))
{
    string text = sr.ReadToEnd();
    TextHelper.TextGenerator("\nReading from the stream file...", ConsoleColor.Yellow);
    TextHelper.TextGenerator(text, ConsoleColor.DarkGray);
    TextHelper.TextGenerator("Reading Has been complited" ,ConsoleColor.Green);

}
#endregion