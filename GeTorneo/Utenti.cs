//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeTorneo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utenti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utenti()
        {
            this.Iscrizioni = new HashSet<Iscrizioni>();
        }
    
        public int idUtente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Useri { get; set; }
        public string Passwd { get; set; }
        public Nullable<int> fkRuolo { get; set; }
        public Nullable<int> fkPersonaggio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iscrizioni> Iscrizioni { get; set; }
        public virtual Personaggi Personaggi { get; set; }
        public virtual Ruoli Ruoli { get; set; }
    }
}
