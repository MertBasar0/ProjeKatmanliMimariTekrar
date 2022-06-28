using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }


        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetByEmployeeId(int id)
        {
            return _orderDal.GetAll(x=>x.EmployeeID == id);
        }
    }
}