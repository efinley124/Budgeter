﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace efinley_budgeter.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public string Payee { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy h:mm tt}")]
        public DateTimeOffset Created { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public double Amount { get; set; }
        public bool Deleted { get; set; }
        // Type: Deposit or Expense
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
        public int EnteredById { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public virtual efinley_budgeter.Models.Type Type { get; set; }
        public virtual Category Category { get; set; }
        public virtual ApplicationUser EnteredBy { get; set; }
    }
}