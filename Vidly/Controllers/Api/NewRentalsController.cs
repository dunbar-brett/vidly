﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            return Ok();
        }
    }
}
