using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gifter.Models;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        Post GetById(int id);
        List<Post> GetAll();
        void Update(Post post);
        List<Post> GetAllWithComments();
        List<Post> Search(string q, bool sortDesc);
        Post GetPostByIdWithComments(int id);
    }
}
