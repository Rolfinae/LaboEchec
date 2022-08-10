﻿using LaboEchec.DL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboEchec.DL.Entity
{
    public class Tournament
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Location { get; set; }
        [Required]
        [Range(2, 32)]
        public int Number_Player_Max { get; set; }
        [Required]
        [Range(2, 32)]
        public int Number_Player_Min { get; set; }
        [Required]
        [Range(0, 3000)]
        public int Elo_Player_Max { get; set; }
        [Required]
        [Range(0, 3000)]
        public int Elo_Player_Min { get; set; }
        public Enum_Grade Category_Tournament { get; set; }
        public Enum_Status Status_Tournament { get; set; }
        public int Round { get; set; }
        public bool WomenOnly { get; set; }
        public DateTime Last_Inscription_Time { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public ICollection<Members> Players { get; set; } = new List<Members>();
    }
}
