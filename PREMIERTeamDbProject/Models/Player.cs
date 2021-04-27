using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PREMIERTeamDbProject.Models
{
    public class Player

    {
        [Key]
        public int PlayerID { get; set; }

        [Required]
        public string PlayerName{ get; set; }

        [Required]
        public string PlayerClub { get; set; }

        public string PlayerDescription { get; set; }

        public string PlayerImage { get; set; }

        public decimal PlayerPrice { get; set; }

        public string PlayerStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

    }

}