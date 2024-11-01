using System.Diagnostics.Metrics;

namespace Module12.Lesson
{
    // Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

    public class Program
    {
        public static void Main(string[] args)
        {
            ToUsers toUsers = new ToUsers();
            toUsers.InitUser(4);
            
            User user1 = new User();
            user1.Login = "123456"; user1.Name = "Иванов И.И."; user1.IsPremium = true;
            toUsers.AddUser(0, user1);

            User user2 = new User();
            user2.Login = "654321"; user2.Name = "Петров П.П."; user2.IsPremium = true;
            toUsers.AddUser(1, user2);

            User user3 = new User();
            user3.Login = "qwerty"; user3.Name = "Федоров Ф.Ф."; user3.IsPremium = false;
            toUsers.AddUser(2, user3);

            User user4 = new User();
            user4.Login = "qazqaz"; user4.Name = "Ильин И.И."; user4.IsPremium = true;
            toUsers.AddUser(3, user4);

            toUsers.AddressingToUser();
        }
    }
}
