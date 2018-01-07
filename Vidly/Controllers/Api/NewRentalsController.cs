using System;
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
        private ApplicationDbContext _context;

        public NewRentalsController()   
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            // Add new rental to db. Not using default, controller assumes ID is valid customer
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
            
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    DateRented = DateTime.Now,
                    Movie = movie
                };

                _context.Rentals.Add(rental);
            }
            
            _context.SaveChanges();
            
            return Ok();
        }
    }
}
