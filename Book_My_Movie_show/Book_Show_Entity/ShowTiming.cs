﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Book_Show_Entity
{
    public class ShowTiming
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("Theatre")]
        public int TheatreId { get; set; }

        public Theater Theater { get; set; }
        public DateTime ShowTime { get; set; }

    }
}
