using KMA.APZRP2019.DBModels;
using KMA.APZRP2019.Tools;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = ProviderFactory.CreateNewDBProvider())
            {
                context.Add(new User("12345", "12345", "12345", "12345"));
            }
            using (var context = ProviderFactory.CreateNewDBProvider())
            {
                var users = context.SelectAll<User>();
            }
        }
    }
}
