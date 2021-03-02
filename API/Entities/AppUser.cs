namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //Entity recognizes the ID as a PK
        public string UserName { get; set; }//Identity uses the UserName convention
        
    }
}