using Microsoft.AspNetCore.Mvc;
using MindTechMovieDbProject.Jobs;
using Quartz;

namespace MindTechMovieDbProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ISchedulerFactory _schedulerFactory;

        public JobController(ISchedulerFactory schedulerFactory)
        {
            _schedulerFactory = schedulerFactory;
        }

        // POST api/job/schedule
        [HttpPost("schedule")]
        public async Task<IActionResult> ScheduleJob([FromBody] JobScheduleRequest request)
        {
            var scheduler = await _schedulerFactory.GetScheduler();

            var job = JobBuilder.Create<FetchMoviesJob>()
                .WithIdentity(request.JobName, request.GroupName)
                .Build();

            var trigger = TriggerBuilder.Create()
                .WithIdentity($"{request.JobName}-trigger", request.GroupName)
                .StartAt(DateTimeOffset.UtcNow.AddSeconds(request.DelayInSeconds))
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(request.IntervalInSeconds).RepeatForever())
                .Build();

            await scheduler.ScheduleJob(job, trigger);

            return Ok(new { Message = $"Job {request.JobName} scheduled." });
        }
    }

    public record JobScheduleRequest
    {
        public string JobName { get; set; }
        public string GroupName { get; set; }
        public int DelayInSeconds { get; set; }
        public int IntervalInSeconds { get; set; }
    }
}
