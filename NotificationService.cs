using System;

public class NotificationService
{
    public void OnDownloadCompleted(object sender, DownloadEventArgs e)
    {
        Console.WriteLine($"Notification: Download of {e.FileName} completed.");
    }
}
