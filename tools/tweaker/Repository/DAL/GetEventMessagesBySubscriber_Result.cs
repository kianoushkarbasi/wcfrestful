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
    
    public partial class GetEventMessagesBySubscriber_Result
    {
        public int EventMessageID { get; set; }
        public string EventName { get; set; }
        public int Priority { get; set; }
        public string ProcessorType { get; set; }
        public string ProcessorCommand { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Subscriber { get; set; }
        public string AuthorizedRoles { get; set; }
        public string ExceptionMessage { get; set; }
        public System.DateTime SentDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string Attributes { get; set; }
        public bool IsComplete { get; set; }
    }
}
