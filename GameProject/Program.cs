namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
         
            { 
                Id = 1, 
                BirthYear = 1994,
                FirstName = "SENA", 
                LastName = "ÖZDEMİR", 
                IdentityNumber = 12345
            }
           );
           
        }
    }
}