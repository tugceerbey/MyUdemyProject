using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;
using OtelProje.DataAccessLayer1.Abstract;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Delete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff GetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Staff> GetList()
        {
            return _staffDal.GetList();
        }

        public void Insert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
