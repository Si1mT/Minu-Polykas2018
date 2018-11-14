using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Data
{
    public class Comments
    {
        public IdentityUser UserId { get; set; }
        public MediaItem MediaItemId { get; set; }
    }
}
