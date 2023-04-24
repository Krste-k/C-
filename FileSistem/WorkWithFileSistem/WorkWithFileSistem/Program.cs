using System.Reflection.PortableExecutable;
using WorkWithFileSistem;


#region  Directory manipulation

TextHelper.TextGenerator("Working with the file sistem", ConsoleColor.Cyan);
string CurrentDirectory = Directory.GetCurrentDirectory();
TextHelper.TextGenerator($"Currently we are here: {CurrentDirectory}", ConsoleColor.Magenta);

string relativePath = "../../../";
TextHelper.TextGenerator("\n\n========================\n\n", ConsoleColor.Cyan);
TextHelper.TextGenerator("Check if the folder exist. \n\nResult:" , ConsoleColor.Cyan);

bool doesFolderExist = Directory.Exists(relativePath + "/DemoFolder");
if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !" ,ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("Folder exist ! ", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n======================== CREATE A FOLDER =====================" , ConsoleColor.Cyan);

if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new folder...", ConsoleColor.Yellow);
    Directory.CreateDirectory(relativePath + "/DemoFolder");
    TextHelper.TextGenerator("Folder Created !", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n===================== DELETE A FOLDER ================\n\n", ConsoleColor.Cyan);

if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Green);
    TextHelper.TextGenerator("Creating a new folder...", ConsoleColor.Yellow);
    Directory.Delete(relativePath + "/DemoFolder" , true);
    TextHelper.TextGenerator("Folder Created !", ConsoleColor.Green);
}
#endregion

#region File manipulation
TextHelper.TextGenerator("\n\n============== FILE ===================", ConsoleColor.Cyan);
string relativeFilePath = "../../..//FolderWithFile";

if (Directory.Exists(relativeFilePath))
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new folder...", ConsoleColor.Yellow);
    Directory.Delete(relativeFilePath );
    TextHelper.TextGenerator("Folder created " , ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("Folder exist and redy to use !",ConsoleColor.Green);
}


TextHelper.TextGenerator("\n\n============== CREATE A FILE ===================", ConsoleColor.Cyan);

string file = "/test.txt";
string fileFullPath = relativeFilePath + file;

if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new file...", ConsoleColor.Yellow);
    File.Create(fileFullPath).Close();
    TextHelper.TextGenerator("File Created.", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("File exist and redy to use", ConsoleColor.Green);

}



TextHelper.TextGenerator("\n\n============== CREATE A FILE ===================", ConsoleColor.Cyan);

if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("File exist.", ConsoleColor.Green);
    TextHelper.TextGenerator("Deleting the file" ,ConsoleColor.Yellow);
    File.Delete(fileFullPath);
    TextHelper.TextGenerator("File deleted", ConsoleColor.Green);

}

TextHelper.TextGenerator("\n\n============== WRITE IN A FILE ===================", ConsoleColor.Cyan);
if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new file..." , ConsoleColor.Yellow);
    File.Create(fileFullPath).Close(); 
    TextHelper.TextGenerator("File Created. And Written in it." , ConsoleColor .Green);
}
else
{
    TextHelper.TextGenerator("File exist and ready to use." ,ConsoleColor .Green);
    File.WriteAllText(fileFullPath, "Writing the file, because it alredy exist !");
    //    File.AppendAllText(fileFullPath, "Writing in the file , because it alredy exist !");//This adds text to the existing previous text
    TextHelper.TextGenerator("Written in the file", ConsoleColor.Green);
}
TextHelper.TextGenerator("\n\n============== READ FROM A FILE ===================", ConsoleColor.Cyan);

TextHelper.TextGenerator("Reading from the file:", ConsoleColor.Yellow);
if (File.Exists(fileFullPath))
{
    string text = File.ReadAllText(fileFullPath);
    TextHelper.TextGenerator(text, ConsoleColor.DarkGray);
}

#endregion