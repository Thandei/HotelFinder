using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelrepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelrepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {

            return _hotelrepository.CreateHotel(hotel);

        }

        public void DeleteHotel(int id)
        {
            _hotelrepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelrepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if(id > 0)
            {
                return _hotelrepository.GetHotelById(id);
            }
            throw new Exception("id can not be found");
            
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
