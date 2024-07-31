using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscordAPI.Models
{

    public class PermissionDifference
    {
        /// <summary>
        /// Added permissions in the form of a string list
        /// </summary>
        public IEnumerable<string> AddedPermissions { get; set; }

        /// <summary>
        /// Removed Permissions in the form of a string list
        /// </summary>
        public IEnumerable<string> RemovedPermissions { get; set; }
    }

}
