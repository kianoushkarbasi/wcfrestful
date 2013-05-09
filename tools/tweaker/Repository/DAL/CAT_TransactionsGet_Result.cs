//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.DAL
{
    using System;
    
    public partial class CAT_TransactionsGet_Result
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string AuthCode { get; set; }
        public string AvsCode { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public Nullable<int> BankAccountType { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string CardType { get; set; }
        public string City { get; set; }
        public string ClientIP { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string ErrorMessage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Month { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string ReferenceNumber { get; set; }
        public string StateProvince { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> TransactionDate1 { get; set; }
        public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public Nullable<int> Year { get; set; }
        public string ZipPostal { get; set; }
        public string ProfileProperties { get; set; }
        public Nullable<decimal> CustomerTransFeeAmt { get; set; }
        public Nullable<decimal> MerchantTransFeeAmt { get; set; }
        public Nullable<int> PaymentMethodID { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    }
}
