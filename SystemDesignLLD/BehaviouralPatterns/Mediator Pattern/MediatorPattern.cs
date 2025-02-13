using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Mediator_Pattern
{
    public class MediatorPattern
    {
        public void MainMethod()
        {
            ChatMediator chatRoom = new ChatRoom();
            User naresh = new User("Naresh", chatRoom);
            User suresh = new User("Suresh", chatRoom);
            User paresh = new User("Paresh", chatRoom);
            User ganesh = new User("Ganesh", chatRoom);
            chatRoom.addUser(naresh);
            chatRoom.addUser(suresh);
            chatRoom.addUser(ganesh);
            chatRoom.addUser(paresh);

            ganesh.sendMessage("Hello everyone");

        }

    }

    public interface ChatMediator 
    {
        void sendMessage(string msg, User user);
        void addUser(User user);
    }

    class ChatRoom : ChatMediator 
    {
        private List<User> users;
        public ChatRoom()
        {
            users = new List<User>();
        }

        public void addUser(User user)
        {
            users.Add(user);
        }

        public void sendMessage(string msg, User sender)
        {
            foreach (User user in users)
            {
                if (user != sender)
                {
                    user.recieveMessage(msg,sender);
                }
            }
        }
    }

    public class User 
    {
        private string name;
        private ChatMediator chatMediator;

        public User(string name,ChatMediator chatMediator)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void sendMessage(string msg)
        {
            Console.WriteLine(this.name + " sending a message " + msg);
            chatMediator.sendMessage(msg,this);
        }

        public string getName()
        {
            return name;
        }

        public void recieveMessage(string msg, User sender)
        {
            Console.WriteLine(this.name + " received message " + msg + " from " + sender.getName());
        }


    }


    
}
