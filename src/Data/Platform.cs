﻿using System.ComponentModel.DataAnnotations;
using SharedAdvantageSamplesLibrary;

namespace AdvantagePlatform.Data
{
    public class Platform
    {
        public Platform()
        {
            Id = System.Guid.NewGuid().ToString("N");
        }

        [Display(Name = "ID")]
        public string Id { get; set; }

        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "GUID")]
        public string Guid { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Product Family Code")]
        public string ProductFamilyCode { get; set; }

        [NullableUrl]
        [Display(Name = "URL")]
        public string Url { get; set; }

        [Display(Name = "Version")]
        public string Version { get; set; }

        public string UserId { get; set; }
        public AdvantagePlatformUser User { get; set; }
    }
}
