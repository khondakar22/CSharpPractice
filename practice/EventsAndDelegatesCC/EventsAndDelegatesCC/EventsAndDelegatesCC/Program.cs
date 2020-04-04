namespace EventsAndDelegatesCC
{
    partial class Program
    {
        static void Main(string[] args)
        {
            File file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // Publisher
            var unpackService = new UnpackService(); // receiver
            var notificationService = new NotficationService(); // receiver
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);
        }
    }
}
