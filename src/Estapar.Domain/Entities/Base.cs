﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Estapar.Domain
{
    public class Base
    {
        [Required]
        public virtual int Id { get; set; }
    }
}