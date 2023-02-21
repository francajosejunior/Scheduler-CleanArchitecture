using Bogus;
using Domain.Entities;
using Domain.Exceptions;
using FluentAssertions;

namespace Domain.UnitTests
{
    public class SchedulerTests
    {
        [Fact]
        public void Scheduler_ShouldContructScheduler()
        {
            //arrange
            Faker<Schedule> schedulerFaker = new Faker<Schedule>()
                .RuleFor(s => s.Id, f => f.Random.Guid())
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.Description, f => f.Name.FullName())
                .RuleFor(s => s.StartsAt, f => f.Date.Past())
                .RuleFor(s => s.EndsAt, f => f.Date.Future())
                .RuleFor(s => s.Tags, f => f.Lorem.Paragraph().Split(" "));

            //act
            var scheduler = schedulerFaker.Generate();
            //assert
            scheduler.Should().BeAssignableTo<Schedule>();

        }

        [Fact]
        public void Scheduler_ShouldNotContructSchedulerWithInvertedDates()
        {
            //arrange
            var schedulerFaker = new Faker<Schedule>()
                .RuleFor(s => s.Id, f => f.Random.Guid())
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.Description, f => f.Name.FullName())
                .RuleFor(s => s.StartsAt, f => f.Date.Future())
                .RuleFor(s => s.EndsAt, f => f.Date.Past())
                .RuleFor(s => s.Tags, f => f.Lorem.Paragraph().Split(" "));

            //act
            Action assertion = () => { var scheduler = schedulerFaker.Generate(); };
            //assert
            assertion.Should().Throw<SchedulerInvertedDatesException>();


        }
    }
}