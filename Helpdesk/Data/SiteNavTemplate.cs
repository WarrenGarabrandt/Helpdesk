﻿using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Data
{
    public class SiteNavTemplate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Description { get; set; }
        /// <summary>
        /// Shows the Ticket link in the Navbar
        /// </summary>
        [Required] 
        public bool TicketLink { get; set; }
        /// <summary>
        /// Shows the Asset link in the Navbar
        /// </summary>
        [Required]
        public bool AssetLink { get; set; }
        /// <summary>
        /// Shows People link in the Navbar
        /// </summary>
        [Required] 
        public bool PeopleLink { get; set; }
        /// <summary>
        /// Show the Configuration Menu on the NavBar
        /// </summary>
        [Required]
        public bool ShowConfigurationMenu { get; set; }
        /// <summary>
        /// Show LicenseType link in the Configuration Menu
        /// </summary>
        [Required]
        public bool LicenseTypeLink { get; set; }
        /// <summary>
        /// Shows SiteSettings link in the Configuration Menu
        /// </summary>
        [Required]
        public bool SiteSettingsLink { get; set; }
        /// <summary>
        /// Shows the Groups link in the Configuration Menu
        /// </summary>
        [Required]
        public bool GroupsLink { get; set; }
    }
}
