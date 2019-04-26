using NCTShop.Data.Infrastructure;
using NCTShop.Data.Repositories;
using NCTShop.Model.Models;
using System.Collections.Generic;

namespace NCTShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategoryPaging(int categoryID,int page, int pageSize, out int totalRow);

        Post GetByID(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWord;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWord = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryID, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID ==categoryID, out totalRow, page, pageSize,new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: select all post by tag
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetByID(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWord.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}