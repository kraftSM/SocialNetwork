using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Repositories.SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Friend(
            int id,
            string firstName,
            string lastName
            )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
