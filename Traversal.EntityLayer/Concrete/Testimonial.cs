﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
