using System;
using System.ComponentModel;
using System.Net;

public class FileDownloader
{
    private string localFilePath;
    private string webUrlFile;

    public FileDownloader(string webUrlFile, string localFilePath)
    {
        this.webUrlFile = webUrlFile;
        this.localFilePath = localFilePath;
    }

    public void StartFileDownload()
    {
        using (WebClient client = new WebClient())
        {
            client.DownloadProgressChanged += DownloadProgressChanged;
            client.DownloadFileCompleted += Completed;

            client.DownloadFileAsync(new Uri(webUrlFile), localFilePath);
        }
    }

    private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        double progressPercentage = (double)e.BytesReceived / e.TotalBytesToReceive * 100;

        Console.WriteLine($"{progressPercentage:F2}% | {e.BytesReceived} bytes out of {e.TotalBytesToReceive} bytes retrieved.");
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
        Console.WriteLine("File successfully downloaded.");
    }
}
