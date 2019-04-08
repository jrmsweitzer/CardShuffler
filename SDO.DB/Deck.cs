namespace SDO.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deck")]
    public partial class Deck
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeckID { get; set; }

        public int PlayerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Decklist { get; set; }

        public virtual Player Player { get; set; }
    }
}
