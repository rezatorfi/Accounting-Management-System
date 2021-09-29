﻿using Paycalculator.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycalculator.Models
{
    public class PaymentRecordCreateViewModel
    {
        public int Id { get; set; }
        [Display(Name="Full Name")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public string FullName { get; set; }
        public string NiNo { get; set; }
        [DataType(DataType.Date), Display(Name = "Date of Payment")]
        public DateTime PayDate { get; set; } = DateTime.UtcNow;
        [Display(Name = "Pay Month")]
        public string PayMonth { get; set; } = DateTime.Today.Month.ToString();
        public TaxYear TaxYear { get; set; }
        [Display(Name = "Tax Year")]
        public int TaxYearId { get; set; }
        public string TaxCode { get; set; } = "1250L";
        [Display(Name = "Hourly rate")]
        public decimal HourlyRate { get; set; }
        [Display(Name = "Hours Worked")]
        public decimal HoursWorked { get; set; }
        [Display(Name = "Contractual Hours")]
        public decimal ContractualHours { get; set; } = 144m;        public decimal OvertimeHours { get; set; }
        public decimal ContractualEarnings { get; set; }
        public decimal OvertimeEarnings { get; set; }
        public decimal Tax { get; set; }
        public decimal NIC { get; set; }
        public decimal? SLC { get; set; }
        public decimal TotalEarnings { get; set; }
        public decimal TotalReduction { get; set; }
        public decimal NetPayment { get; set; }

    }
}
