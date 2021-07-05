using System;
using System.Threading.Tasks;
using AsyncAwait.Task2.CodeReviewChallenge.Headers;
using CloudServices.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AsyncAwait.Task2.CodeReviewChallenge.Middleware
{
    public class StatisticMiddleware
    {
        private readonly ILogger<StatisticMiddleware> _logger;
        private readonly RequestDelegate _next;

        private readonly IStatisticService _statisticService;

        public StatisticMiddleware(
            ILogger<StatisticMiddleware> logger,
            RequestDelegate next, 
            IStatisticService statisticService)
        {
            _logger = logger;
            _next = next;
            _statisticService = statisticService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _statisticService.RegisterVisitAsync(context.Request.Path);

                await UpdateHeadersAsync(context);

                await _next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        private async Task UpdateHeadersAsync(HttpContext context)
        {
            var result = await _statisticService.GetVisitsCountAsync(context.Request.Path);
            context.Response.Headers.Add(CustomHttpHeaders.TotalPageVisits, result.ToString());
        }
    }
}
