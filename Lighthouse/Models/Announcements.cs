using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Lighthouse.Models
{
    public class Announcements : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AnnouncementText { get; set; }

        // Common attachment properties
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? AttachmentFile { get; set; }

        public byte[]? AttachmentData { get; set; }
        public string? AttachmentFileName { get; set; }
        public string? AttachmentContentType { get; set; }

        // Announcement-specific attachment properties
        // (customize these as needed for announcements)
        public byte[]? AnnouncementAttachmentData { get; set; }
        public string? AnnouncementAttachmentFileName { get; set; }
        public string? AnnouncementAttachmentContentType { get; set; }

        // Notification preferences for individual announcements
        public bool NotifyByEmail { get; set; }
        public bool NotifyByWebsite { get; set; }
    }
}


