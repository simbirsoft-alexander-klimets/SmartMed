using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;

namespace SmartMed.Domain.Data
{
    public class DataSeed
    {
        public List<Option> options;
        public List<Rating> ratings;
        public List<Feedback> feedbacks;
        public List<Status> statuses;
        public List<User> users;
        public List<Appointment> appointments;
        public DataSeed()
        {
            ratings = new List<Rating>()
            {
                new Rating()
                {
                    Id = Guid.NewGuid(),
                    Value = 1
                },
                new Rating()
                {
                    Id = Guid.NewGuid(),
                    Value = 2
                },
                new Rating()
                {
                    Id = Guid.NewGuid(),
                    Value = 3
                },
                new Rating()
                {
                    Id = Guid.NewGuid(),
                    Value = 4
                },
                new Rating()
                {
                    Id = Guid.NewGuid(),
                    Value = 5
                }
            };

            options = new List<Option>()
            {
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Прием начался не вовремя"
                },
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Мне непонятен диагноз и план лечения"
                },
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Врач был груб и не отвечал на мои вопросы"
                },
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Прием начался вовремя"
                },
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Мне понятен диагноз и план лечения"
                },
                new Option()
                {
                    Id = Guid.NewGuid(),
                    Description = "Врач был вежлив и отвечал на мои вопросы"
                }
            };

            feedbacks = new List<Feedback>()
            {
                new Feedback()
                {
                    Id = Guid.NewGuid(),
                    RatingId = ratings[4].Id,
                    OptionId = options[3].Id,
                    Details = default,
                    Comment = default

                }
            };

            statuses = new List<Status>()
            {
                new Status()
                {
                    Id = Guid.NewGuid(),
                    Description = "Создан",
                    IsBlocked = true
                },
                new Status()
                {
                    Id = Guid.NewGuid(),
                    Description = "Подтвержден",
                    IsBlocked = true
                },
                new Status()
                {
                    Id = Guid.NewGuid(),
                    Description = "Отменен",
                    IsBlocked = true
                },
                new Status()
                {
                    Id = Guid.NewGuid(),
                    Description = "Проведен",
                    IsBlocked = false
                }
            };

            users = new List<User>()
            {
                new User()
                    {
                        Id = Guid.NewGuid(),
                        SecurityStamp = Guid.NewGuid().ToString(),
                        UserName = "TestUserFirst",
                        Email = "testuserfirst@test.com",
                        Name = "John",
                        Surname = "Dow"
                    },
                new User()
                    {
                        Id = Guid.NewGuid(),
                        SecurityStamp = Guid.NewGuid().ToString(),
                        UserName = "TestUserSecond",
                        Email = "testusersecond@test.com",
                        Name = "Jack",
                        Surname = "Carter"
                    }
            };

            appointments = new List<Appointment>()
            {
                new Appointment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = users[0].Id,
                    PatientId = users[1].Id,
                    FeedbackId = feedbacks[0].Id,
                    StatusId = statuses[3].Id,
                    Date = DateTime.Now
                }
            };
        }
    }
}
