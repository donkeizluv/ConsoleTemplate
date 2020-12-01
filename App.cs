namespace ConsoleTemplate
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// App DI root.
    /// </summary>
    public class App
    {
        private readonly ILogger<App> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="logger">logger implementation.</param>
        public App(ILogger<App> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Start app main routine.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        public async Task Run()
        {
            throw new NotImplementedException();
        }
    }
}
