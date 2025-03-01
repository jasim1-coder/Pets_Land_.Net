﻿namespace Pet_s_Land.DTOs
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Seller { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
