﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        [Required,MaxLength(50)]
        public string InsuranceNo { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public StudentLoan studentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        [Required,MaxLength(150)]
        public string Address { get; set; }
        [Required,MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string Postcode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }

    }
}
