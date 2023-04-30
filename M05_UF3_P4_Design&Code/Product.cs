using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P4_Design_Code
{
    public class Product
    {
            public string reference;
            public string name;
            public string brand;
            public string imgUrl;
            public string description;
            public float base_price;
            public List<string> valuation;
            public List<string> labels;
            public float discount;
            public List<string> category;
            public List<string> subcategory;

        public class SpecializedProduct : Product
        {
            public List<string> subsubcategory;
        }
    }
    
}
