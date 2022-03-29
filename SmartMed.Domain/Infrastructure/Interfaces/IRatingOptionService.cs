using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMed.Domain.Infrastructure.Interfaces
{
    public interface IRatingOptionService
    {
        public IEnumerable<Rating> GetAllRatings();

        public IEnumerable<Option> GetAllOptions();

        public Rating GetRatingById(Guid id);

        public Option GetOptionById(Guid id);

        public void AddRating(Rating rating);

        public void AddOption(Option option);

        public void AddRatingToOption(Guid optionId, Rating rating);

        public void AddOptionToRating(Guid ratingId, Option option);

        public void UpdateRating(Guid id, Rating rating);

        public void UpdateOption(Guid id, Option option);

        public void RemoveRating(Guid id);

        public void RemoveOption(Guid id);

        public void RemoveRatingFromOption(Guid optionId, Guid ratingId);

        public void RemoveOptionFromRating(Guid ratingId, Guid optionId);
    }
}
