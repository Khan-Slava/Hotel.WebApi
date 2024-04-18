using Hotel.WebApi.Models;
using Hotel.WebApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private HotelAtrContext _db;
        public RoomController(HotelAtrContext db)
        {
            _db = db;
        }
        public IEnumerable<Room> Get()
        {
            var data = _db.Rooms;
            return data;
        }
        [HttpPost]
        public Room Post(Room room)
        {
            _db.Rooms.Add(room);
            _db.SaveChanges();

            return room;
        }
    }
}
