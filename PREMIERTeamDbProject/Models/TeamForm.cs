using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PREMIERTeamDbProject.Models
{
    public class TeamForm

    {
        [Key]
        public int TeamID { get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What team are we talking about?")]
        public string TeamTitle { get; set; }

        [Required]
        public string TeamCertificate { get; set; }

        public string TeamDescription { get; set; }

        public string TeamImage { get; set; }
        public decimal TeamPrice { get; set; }

        public int Stars { get; set; }

        public DateTime ReleaseDate { get; set; }

    }

}