﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using STech_Web.Models;
using STech_Web.ApiModels;

namespace STech_Web
{
    public class BrandsController : ApiController
    {
        public List<BrandAPI> Get()
        {
            DatabaseSTechEntities db = new DatabaseSTechEntities();
            List<Brand> brands = db.Brands.ToList();
            List<BrandAPI> brandAPIs = new List<BrandAPI>();

            foreach (Brand brand in brands)
            {
                BrandAPI brandAPI = new BrandAPI(brand.BrandID, brand.ParentBrandID, brand.BrandName, brand.Phone, brand.BrandAddress, brand.BrandImgSrc);

                brandAPIs.Add(brandAPI);
            }

            return brandAPIs;
        }

        public BrandAPI GetOne(string brandID)
        {
            DatabaseSTechEntities db = new DatabaseSTechEntities();
            Brand brand = db.Brands.FirstOrDefault(t => t.BrandID == brandID);
            BrandAPI brandApi = new BrandAPI();
            if(brand != null)
            {
                brandApi = new BrandAPI(brand.BrandID, brand.ParentBrandID, brand.BrandName, brand.Phone, brand.BrandAddress, brand.BrandImgSrc);
            }

            return brandApi;
        }
    }
}
