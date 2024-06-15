using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerManager(ICustomerDal customerDal,IUnitOfWorkDal unitOfWorkDal)
        {
            _customerDal = customerDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        
        public void Delete(Customer t)
        {
            _customerDal.Delete(t); 
            _unitOfWorkDal.Save();
        }

        public Customer GetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.GetList();
        }

        public void Insert(Customer t)
        {
            _customerDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void MultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _unitOfWorkDal.Save();  
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
