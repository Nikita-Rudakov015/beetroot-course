﻿using System.Collections.Generic;

namespace Lesson29.EF.DataAccess.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}