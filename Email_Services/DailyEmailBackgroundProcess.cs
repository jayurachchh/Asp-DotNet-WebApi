using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;
using Project_Management_Admin_Panel.Email_Services;

      #region DailyEmailBackgroundService
public class DailyEmailBackgroundService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    public DailyEmailBackgroundService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Wait until the system time is exactly 2 minutes from now
        while (!stoppingToken.IsCancellationRequested)
        {
            var nextRunTime = DateTime.Now.AddDays(1); 
            var delay = nextRunTime - DateTime.Now;
            if (delay.TotalMilliseconds > 0)
            {
                await Task.Delay(delay, stoppingToken); 
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                var dailyMailService = scope.ServiceProvider.GetRequiredService<DailyEmailService>();
                await dailyMailService.SendDailyActionsEmailAsync("jayrachchh2612@gmail.com"); // Sending the email
            }
        }
    }
    
}
#endregion
