﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Entity
{
    [Table("MissionSkill")] // Specify the table name
    public class MissionSkill // Assuming BaseEntity defines common properties
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("skill_name")]
        public string SkillName { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}