using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                hoteldbcontext.Hotels.Add(hotel);
                hoteldbcontext.SaveChanges();
                return hotel;
            };
        }

        public void DeleteHotel(int id)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                var deletedhotel = GetHotelById(id);
                hoteldbcontext.Remove(deletedhotel);
                hoteldbcontext.SaveChanges();
            };
        }

        public List<Hotel> GetAllHotels()
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                return hoteldbcontext.Hotels.ToList();

            };
        }

        public Hotel GetHotelById(int id)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                return hoteldbcontext.Hotels.Find(id);

            };
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                hoteldbcontext.Update(hotel);
                hoteldbcontext.SaveChanges();
                return hotel;
            };
        }
    }
}
