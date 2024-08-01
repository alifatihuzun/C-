namespace ASP.NET_8_Web_API___Entity_Framework.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public required string BankName { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public required string Password {  get; set; } = string.Empty;
    }
}
