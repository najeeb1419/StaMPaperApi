﻿using Microsoft.Extensions.Logging;
using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IzlaCRM.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace IzlaCRM.Repo.Repo
{
    public class BankEmployeePaymentRepository : GenericRepository<BankEmployeePayment>, IBankEmployeePaymentRepository
    {
        public BankEmployeePaymentRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public List<BankEmployeePaymentModel> GetBankEmployeePaymentByReceiptId(int id)
        {
            var result = DbSet.Include(x=>x.Account).Where(p => p.BankEmployeeReceiptId== id).Select(x=> new BankEmployeePaymentModel()
            {
                Id=x.Id,
                BankEmployeeReceiptId=x.BankEmployeeReceiptId,
                SendingAmount=x.SendingAmount,
                CreationTime=x.CreationTime,
                SenderAccountNo=x.Account.AccountNo

            }).ToList();

            return result;
        }
    }
}
