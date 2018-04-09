using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeTorneo.Models {
	interface IDomainModel{ 
		void Save(Torneo torneo);
	}
	public class DomainModel : IDomainModel {
		public void Save(Torneo torneo) {
			using(var db = new GeTorneoEntities()){
				db.AggiungiTorneo(torneo.Nome,null,null,null,torneo.Premio, torneo.Descrizione);
			}
		}
	}
	
}