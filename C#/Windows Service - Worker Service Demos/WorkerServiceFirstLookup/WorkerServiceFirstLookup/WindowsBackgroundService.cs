using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceFirstLookup
{
    public sealed class WindowsBackgroundService : BackgroundService
    {
        private readonly JokeService _jokeService;
        private readonly ILogger<WindowsBackgroundService> _logger;

        public WindowsBackgroundService(JokeService jokeService, ILogger<WindowsBackgroundService> logger)
        {
            _jokeService = jokeService;
            _logger = logger;
        } 

        protected override async Task ExecuteAsync(CancellationToken stopppingToken)
        {
            try
            {
                while (!stopppingToken.IsCancellationRequested)
                {
                    string joke = _jokeService.GetJoke();
                    _logger.LogWarning("{Joke}", joke);

                    await Task.Delay(10000, stopppingToken);
                }
            }
            catch (TaskCanceledException) 
            {
                //Something
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Message}", ex.Message);
                Environment.Exit(1);
            }
        }
    }
}
