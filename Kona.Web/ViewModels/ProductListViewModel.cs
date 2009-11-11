﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kona.Model;

namespace Kona.ViewModels {
    public class ProductListViewModel {

        public IEnumerable<Category> ParentCategories {
            get {
                return Categories.Where(x => x.Parent == null);
            }
        }
        public IEnumerable<Category> Categories { get; set; }
        public IList<Product> FeaturedProducts { get; set; }
        public Product FeaturedProduct { get; set; }
        public IList<Product> Recent { get; set; }
        public IList<Product> Favorite { get; set; }
        public Category SelectedCategory { get; set; }
        public Category HomeCategory {
            get {
                return Categories.SingleOrDefault(x => x.IsDefault);
            }
        }
    }
}
