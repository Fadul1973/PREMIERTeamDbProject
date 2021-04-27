using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PREMIERTeamDbProject.Models
{
    public class Team

    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamTitle { get; set; }

        [Required]
        public string TeamCertificate { get; set; }

        public string TeamDescription { get; set; }

        public string TeamImage { get; set; }

        public decimal TeamPrice { get; set; }

        public int Stars { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }

}