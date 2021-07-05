using System;
using System.Threading.Tasks;
using CloudServices.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace AsyncAwait.Task2.CodeReviewChallenge.Models.Support
{
    public class ManualAssistant : IAssistant
    {
        private readonly ISupportService _supportService;
        private readonly IHostingEnvironment _env;

        public ManualAssistant(
            ISupportService supportService, 
            IHostingEnvironment env)
        {
            _supportService = supportService ?? throw new ArgumentNullException(nameof(supportService));
            _env = env;
        }

        public async Task<string> RequestAssistanceAsync(string requestInfo)
        {
            try
            {
                if (_env.IsDevelopment())
                {
                    Task t = _supportService.RegisterSupportRequestAsync(requestInfo);
                    Console.WriteLine(t.Status); // this is for debugging purposes
                    await Task.Delay(5000);
                    await t;
                    //Thread.Sleep(5000); // this is just to be sure that the request is registered
                }
                return await _supportService.GetSupportInfoAsync(requestInfo);
            }
            catch (Exception ex)
            {
                return ($"Failed to register assistance request. Please try later. {ex.Message}");
            }
        }
    }
}
