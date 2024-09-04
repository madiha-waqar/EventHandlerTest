using System;

public delegate void DownloadCompletedEventHandler(object sender, DownloadEventArgs e);

public class DownloadManager
{
    // Declare the event using the delegate
    public event DownloadCompletedEventHandler DownloadCompleted;

    public void StartDownload(string fileName)
    {
        Console.WriteLine($"Downloading {fileName}...");

        // Raise the event after download is completed
        OnDownloadCompleted(fileName);
    }

    protected virtual void OnDownloadCompleted(string fileName)
    {
        if (DownloadCompleted != null)
        {
            DownloadCompleted(this, new DownloadEventArgs(fileName));
        }
    }
}
