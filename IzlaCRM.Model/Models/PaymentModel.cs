using Abp.Application.Services.Dto;
using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Models
{
    public class PaymentModel : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int AccountId { get; set; }
        public int ReceiptId { get; set; }
        public decimal SendingAmount { get; set; }
        public string CustomerName { get; set; }
        public string SenderAccountNo { get; set; }
        public string RecieverAccountNo { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }

    }
}
