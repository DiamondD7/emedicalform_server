using System.ComponentModel.DataAnnotations;

namespace emedicalform_server.Model
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public string ResidencyStatus { get; set; }
        public string PersonalEmail { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string Relationship { get; set; }
        public string EmailAddress { get; set; }
        public string GpName { get; set; }
        public string HaveUnderlyingConditions{ get; set; }
        public string UnderlyingConditions { get; set; }
        public string HaveAllergies { get; set; }
        public string Allergies { get; set; }


        //
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
    }
}
