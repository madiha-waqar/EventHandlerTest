using System;

class Program
{
    static void Main(string[] args)
    {
        var downloadManager = new DownloadManager();
        var notificationService = new NotificationService();

        downloadManager.DownloadCompleted += notificationService.OnDownloadCompleted;

        downloadManager.StartDownload("examplefile.zip");
    }
}
