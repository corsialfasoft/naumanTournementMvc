using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeTorneo.Models {
	public class Models {
	}
	public class Torneo {
		[Required]
		public string Nome { get; set; }

		[Required]
		public string Descrizione { get; set; }

		[Required]
		[Range(10000, 15000)]
		public double Premio { get; set; }

	}
}