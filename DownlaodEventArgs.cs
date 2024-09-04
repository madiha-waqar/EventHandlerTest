using System;

public class DownloadEventArgs : EventArgs
{
    public string FileName { get; }

    public DownloadEventArgs(string fileName)
    {
        FileName = fileName;
    }
}
