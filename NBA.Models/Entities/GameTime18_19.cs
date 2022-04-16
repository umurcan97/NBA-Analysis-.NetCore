﻿
namespace NBA.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class GameTime18_19
    {
        [Key]
        public int Id { get; set; }
        public int GameNo { get; set; }
        public DateTime GameDate { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
    }
}
