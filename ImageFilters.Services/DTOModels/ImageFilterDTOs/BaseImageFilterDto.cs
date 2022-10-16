﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.Services.DTOModels
{
    public class BaseImageFilterDto
    {
        public IFormFile? Image { get; set; }

        //[Range(minimum: 1, maximum: 2)]
        // public int StatusId { get; set; }

        public bool StatusName { get; set; }

    }

}
