#region Directory and DirectoryInfo

using System.IO;

var folderName = "folder";
var subFolderName = "subfolder";
var subFolderNameStatic = "subfolder_usingstatic";

var directoryInfoSubFolder = new DirectoryInfo("subfolder");

if (!Directory.Exists(subFolderName) || !directoryInfoSubFolder.Exists)
{
    Directory.CreateDirectory ( subFolderNameStatic );
    Directory.CreateDirectory ( folderName );
    directoryInfoSubFolder.Create ( );

    directoryInfoSubFolder.MoveTo ( $"{folderName}//{subFolderName}" );
    Directory.Move ( subFolderNameStatic, $@"{folderName}\{subFolderNameStatic}" );
}

var name = directoryInfoSubFolder.Name;
var parent = directoryInfoSubFolder.Parent;
var root = directoryInfoSubFolder.Root;
var exists = directoryInfoSubFolder.Exists;

Console.WriteLine ( name );
Console.WriteLine ( parent );
Console.WriteLine ( root );
Console.WriteLine ( exists );

foreach ( var directory in Directory.GetDirectories(folderName) )
{
    Console.WriteLine ( directory );
}

Directory.Delete ( $@"{folderName}\{subFolderName}" );
Directory.Delete ( $@"{folderName}\{subFolderNameStatic}" );
//Directory.Delete ( $@"{folderName}" );

#endregion

#region File and FileInfo

var file = @"folder\text.txt";

if (!File.Exists(file))
{
    File.CreateText (file);
}

var fileInfo = new FileInfo (file);

Console.WriteLine ( $"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de utualização: {fileInfo.LastWriteTime}" );

File.Delete (file);

#endregion

Console.ReadKey ( );

