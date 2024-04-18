using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private HotelATRContext _db;
        public RoomController(HotelATRContext db)
        {
            _db = db;
        }
        public IEnumerable<Room> Get()
        {
            var data = _db.Rooms;
            return data;
        }
    }
}
