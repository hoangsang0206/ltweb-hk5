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
    
    public partial class ProductImgDetail
    {
        public int ImgDetailId { get; set; }
        public string ProductID { get; set; }
        public string ImgSrc1 { get; set; }
        public string ImgSrc2 { get; set; }
        public string ImgSrc3 { get; set; }
        public string ImgSrc4 { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
