using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PREMIERTeamDbProject.Models
{
    public class PlayerForm

    {
        [Key]
        public int PlayerID { get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What palyer are we talking about?")]
        public string PlayerName { get; set; }

        [Required]
        public string PlayerClub { get; set; }

        public string PlayerDescription { get; set; }

        public string PlayerImage { get; set; }
        public decimal PlayerPrice { get; set; }

        public string PlayerStatus { get; set; }

        public DateTime DOB { get; set; }

    }

}