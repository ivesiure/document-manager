using System;

namespace Entities
{
    public class DocumentMedia
    {
        public long Id { get; set; }

        public int DocumentId { get; set; }

        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public string Url { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Document Document { get; set; }
    }
}