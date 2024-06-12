using Hotel_BL.Dtos.Booking;
using Hotel_DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Managers.Booking
{
    public class BookingManager: IBookingManager
    {
        private IUnitOfWork _unitOfWork;
        public BookingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BookingDto>?> GetAll()
        {
           var booking= await _unitOfWork.BookingRepo.getAllWithCustomerAndBranch();
            if (booking == null) 
            {
                return null;
            }
            
            return  booking.Select(b=>new BookingDto(b.Customer.Name,b.Branch.Name,b.NumOfRooms,b.checkInDate,b.checkOutDate)).ToList();
        }
    }
}
