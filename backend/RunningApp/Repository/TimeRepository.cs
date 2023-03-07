using Microsoft.AspNetCore.Mvc;
using RunningApp.Models;

namespace RunningApp.Repository
{
    public class TimeRepository
    {
        private RunningDbContext _dbContext;

        public TimeRepository(RunningDbContext runningDb)
        {
            _dbContext = runningDb;
        }

        public IEnumerable<Time> GetTimes()
        {
            return _dbContext.Times;
        }

        public Time? GetTime(int id)
        {
            var getTime = _dbContext.Times.FirstOrDefault(x => x.Id == id);

            return getTime;
        }

        public Time CreateTime(Time newTime)
        {
            _dbContext.Times.Add(newTime);
            _dbContext.SaveChanges();

            return newTime;
        }

        public Time? DeleteTime(int? id)
        {
            if (id == null)
            {
                return null;
            }
            var timeToBeDeleted = _dbContext.Times.FirstOrDefault(x => x.Id == id);

            if (timeToBeDeleted == null)
            {
                return timeToBeDeleted;
            }
            _dbContext.Times.Remove(timeToBeDeleted);
            _dbContext.SaveChanges();

            return timeToBeDeleted;
        }

        public Time? UpdateTime(Time time, int id)
        {
            var timeToBeUpdated = _dbContext.Times.FirstOrDefault(x =>x.Id == id);

            _dbContext.Times.Update(time);
            _dbContext.SaveChanges();

            return timeToBeUpdated;
        }
    }
}
