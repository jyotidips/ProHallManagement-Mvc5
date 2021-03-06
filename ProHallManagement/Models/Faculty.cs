﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProHallManagement.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}