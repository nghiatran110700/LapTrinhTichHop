namespace ShopService.Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bill")]
    public partial class bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bill()
        {
            billDetails = new HashSet<billDetail>();
        }

        [Key]
        public int idBill { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<billDetail> billDetails { get; set; }
    }
}
