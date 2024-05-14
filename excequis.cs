using System;
using System.Collections.Generic;
using System.Linq;

public class FileSelector
{
    private readonly Random _random = new Random();

    public string CommitFile(List<string> files)
    {
        // Check if the files list is not empty
        if (files == null || !files.Any())
        {
            throw new InvalidOperationException("The files list cannot be empty.");
        }

        // Select a random index from the files list
        int index = _random.Next(files.Count);
        return files[index];
    }
}

// Usage
var fileSelector = new FileSelector();
List<string> fileList = new List<string> { "file1.txt", "file2.txt", "file3.txt" };
string commitFile = fileSelector.CommitFile(fileList);
