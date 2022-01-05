using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatServer = new ChatServer();

            var john = new ChatUser("John", chatServer, Activity.Observer);
            var doe = new ChatUser("Doe", chatServer, Activity.Activ);
            var andrew = new ChatUser("Andrew", chatServer, Activity.Activ);
            var emma = new ChatUser("Emma", chatServer, Activity.Activ);
            var josua = new ChatUser("Josua", chatServer, Activity.Activ);


            chatServer.RegisterUser(josua);
            chatServer.RegisterUser(emma);
            chatServer.RegisterUser(john);
            chatServer.RegisterUser(doe);

            chatServer.RegisterUser(andrew);



            john.SendMessage("How are you?");
            doe.SendMessage("I'm fine!");

            Console.ReadLine();
        }
    }
}