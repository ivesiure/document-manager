using System;
using System.Collections.Generic;

namespace Entities
{
    public class Document
    {
        public int Id { get; set; }

        public Guid CreatorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public string Content { get; set; }

        public string Visibility { get; set; }

        public string Status { get; set; }

        public ICollection<DocumentMedia> Media { get; set; }
    }
}