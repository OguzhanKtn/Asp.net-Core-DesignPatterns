﻿using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı bölge direktörünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi. Müşterinin günlük maksimum çekebileceği tutar 400.000 tl olup daha fazlası için birden fazla gün şubeye gelmesi gereklidir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
