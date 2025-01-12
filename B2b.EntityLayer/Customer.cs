namespace B2b.EntityLayer;

internal class Customer
{

    public int Id { get; set; }
    public string Code { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string CustomerType { get; set; } //Tüzel veya Gerçek 
    public string City { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
    public int OrderState { get; set; }

}
