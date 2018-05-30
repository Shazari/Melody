using Models.Infrastructure;
using System;


namespace Models
{
    public class PaymentUniqueNumber:object
    {
        public PaymentUniqueNumber():base()
        {
        }

        public int Id { get; set; }

        public Guid JoinToCourseID { get; set; }

        public virtual JoinToCourse JoinToCourse { get; set; }



    }
}
