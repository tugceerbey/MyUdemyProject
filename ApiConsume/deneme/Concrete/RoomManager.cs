﻿using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room t)
        {
            _roomDal.Delete(t); 
        }

        public Room GetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> GetList()
        {
            return _roomDal.GetList();
        }

        public void Insert(Room t)
        {
             _roomDal.Insert(t);
        }

        public void Update(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
