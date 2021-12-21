using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class ReviewStorage
    {
        private readonly Dictionary<int, Review> _Reviews = new();

        public Review Create(Review review)
        {

            _Reviews.Add(review.Id, review);
            return review;

        }

        public Review Read(int Id)
        {
            return _Reviews[Id];
        }

        public Review Update(int Id, Review newReview)
        {
            _Reviews[Id] = newReview;
            return _Reviews[Id];
        }

        public bool Delete(int Id)
        {
            return _Reviews.Remove(Id);
        }
    }
}