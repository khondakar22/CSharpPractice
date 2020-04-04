using System;

namespace EventsAndDelegatesCC
{
    partial class Program
    {
        public class NotficationService
        {
            public void OnFileDownloaded(object source, FileEventArgs e)
            {
                Console.WriteLine("Notifying has done of " + e.File.Title);
            }
        }
    }
}
