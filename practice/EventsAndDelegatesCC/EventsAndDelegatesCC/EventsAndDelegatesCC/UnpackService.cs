using System;

namespace EventsAndDelegatesCC
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("UnpackerService: Unpackiing the File..." + e.File.Title);
        }
    }
}
