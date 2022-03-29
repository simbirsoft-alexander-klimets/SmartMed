using SmartMed.Domain.Data.Interfaces;
using SmartMed.Domain.Infrastructure.Interfaces;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartMed.Domain.Infrastructure.Services
{
    public class RatingOptionService : IRatingOptionService
    {
        private IDbContext _context;

        public RatingOptionService(IDbContext context)
        {
            _context = context;
        }

        public void AddOption(Option option)
        {
            _context.Options.Add(option);
            _context.SaveChanges();
        }

        public void AddOptionToRating(Guid ratingId, Option option)
        {
            Rating rating = GetRatingById(ratingId);
            rating.Options.Add(option);
            _context.SaveChanges();
        }

        public void AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }

        public void AddRatingToOption(Guid optionId, Rating rating)
        {
            Option option = GetOptionById(optionId);
            option.Ratings.Add(rating);
            _context.SaveChanges();
        }

        public IEnumerable<Option> GetAllOptions() =>
            _context.Options;

        public IEnumerable<Rating> GetAllRatings() =>
            _context.Ratings;

        public Option GetOptionById(Guid id) =>
            _context.Options.SingleOrDefault(o => o.Id == id);

        public Rating GetRatingById(Guid id) =>
            _context.Ratings.SingleOrDefault(r => r.Id == id);

        public void RemoveOption(Guid id)
        {
            Option optionToDelete = GetOptionById(id);
            _context.Options.Remove(optionToDelete);
            _context.SaveChanges();
        }

        public void RemoveOptionFromRating(Guid ratingId, Guid optionId)
        {
            Rating rating = GetRatingById(ratingId);
            rating.Options.Remove(GetOptionById(optionId));
            _context.SaveChanges();
        }

        public void RemoveRating(Guid id)
        {
            Rating ratingToDelete = GetRatingById(id);
            _context.Ratings.Remove(ratingToDelete);
        }

        public void RemoveRatingFromOption(Guid optionId, Guid ratingId)
        {
            Option option = GetOptionById(optionId);
            option.Ratings.Remove(GetRatingById(ratingId));
            _context.SaveChanges();
        }

        public void UpdateOption(Guid id, Option option)
        {
            Option optionToUpdate = GetOptionById(id);
            _context.Options.Update(optionToUpdate);
            _context.SaveChanges();
        }

        public void UpdateRating(Guid id, Rating rating)
        {
            Rating ratingToUpdate = GetRatingById(id);
            _context.Ratings.Update(ratingToUpdate);
            _context.SaveChanges();
        }
    }
}
