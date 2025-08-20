namespace Entidades
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public int EmployeeNumber { get; set; }
        public int StoreId { get; set; }
        public int Checked { get; set; }
        public DateTime ValidationDate { get; set; }
        public string Status { get; set; }
    }
}