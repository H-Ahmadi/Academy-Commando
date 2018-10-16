﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Application.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace Academy.Services.RestApi.Controllers
{
    [Route("api/[controller]")]
    public class CourseCategoriesController : Controller
    {
        private readonly ICourseCategoryService _service;
        public CourseCategoriesController(ICourseCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<CourseCategoryDTO> Get()
        {
            return _service.GetAll();
        }
    }
}