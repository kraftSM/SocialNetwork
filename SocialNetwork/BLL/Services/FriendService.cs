using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.DAL.Repositories.SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;
        IUserRepository userRepository;
        public FriendService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        public IEnumerable<Friend> GetAllFriendsByUserId(int recipientId)
        {
            var friends = new List<Friend>();

            friendRepository.FindAllByUserId(recipientId).ToList().ForEach(m =>
            {
                UserEntity friend = userRepository.FindById(m.friend_id);
                friends.Add(new Friend(friend.id, friend.firstname, friend.lastname));
            });

            return friends;
        }


        public void AddFriend(FriendAddingData friendAddData)
        {
            var friendEntity = new FriendEntity()
            {
                user_id = friendAddData.idMy,
                friend_id = friendAddData.idFriend
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }
    }
}
