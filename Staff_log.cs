using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace firstres
{
    public class Staff_log
    {
        [Key]
        public int LogId { get; set; }

        public string NumePlayer { get; set; }
        public string Mesaj { get; set; }
    }
}
