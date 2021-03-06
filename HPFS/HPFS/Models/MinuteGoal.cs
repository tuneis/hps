﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace HPFS.Models
{
    public partial class MinuteGoal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal GoalMinute { get; set; }

        public DateTime? GoalStartDate { get; set; }

        public DateTime? GoalEndDate { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AspNetUser AspNetUser { get; set; }
    }

    public partial class MinuteGoalViewModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal GoalMinute { get; set; }

        public DateTime? GoalStartDate { get; set; }

        public DateTime? GoalEndDate { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
