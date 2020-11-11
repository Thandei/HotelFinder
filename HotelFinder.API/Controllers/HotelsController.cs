using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.Business.Concrete;
using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelservice;

        public HotelsController(IHotelService hotelService)
        {
            _hotelservice = hotelService;
        }
        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelservice.GetAllHotels();

        }
        /// <summary>
        /// Get Hotel By Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelservice.GetHotelById(id);

        }
        /// <summary>
        /// Post A Hotel
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelservice.CreateHotel(hotel);

        }
        /// <summary>
        /// Update A Hotel
        /// </summary>
        /// <returns></returns>

        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelservice.UpdateHotel(hotel);

        }

        /// <summary>
        /// Delete A Hotel
        /// </summary>
        /// <returns></returns>


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
              _hotelservice.DeleteHotel(id);

        }
    }
}
