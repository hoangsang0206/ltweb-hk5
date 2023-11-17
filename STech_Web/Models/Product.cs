//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STech_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductOutStandings = new HashSet<ProductOutStanding>();
            this.Sales = new HashSet<Sale>();
            this.Specifications = new HashSet<Specification>();
        }
    
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ImgSrc { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Warranty { get; set; }
        public string BrandID { get; set; }
        public string CateID { get; set; }
        public Nullable<int> ManufacturingDate { get; set; }
        public string ImgSrc1 { get; set; }
        public string ImgSrc2 { get; set; }
        public string ImgSrc3 { get; set; }
        public string ImgSrc4 { get; set; }
        public string ImgSrc5 { get; set; }
        public string ImgSrc6 { get; set; }
        public string ImgSrc7 { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    
        public virtual Brand Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOutStanding> ProductOutStandings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specification> Specifications { get; set; }
        public virtual WareHouse WareHouse { get; set; }
    }
}
