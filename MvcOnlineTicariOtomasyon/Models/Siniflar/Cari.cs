﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
	public class Cari
	{
        [Key]

        public int Cariid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariAD { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }

        public SatışHareket SatışHareket { get; set; }
    }
}