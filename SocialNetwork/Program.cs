using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using SocialNetwork.PLL.Views;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static FriendService friendService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static UserFriendView userFriends;
        public static AddingFriendView addFriendView;


        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            userFriends = new UserFriendView();
            //addFriendView = new AddingFriendView(friendService, userService);
            addFriendView = new AddingFriendView(userService);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}


