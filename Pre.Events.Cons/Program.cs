// See https://aka.ms/new-console-template for more information
using Pre.Events.Core.Events;
using Pre.Events.Core.Services;

Console.WriteLine("Hello, World!");

var temperatureSensor = new TemperatureSensor();
var warningService = new WarningService();
var mitigationService = new MitigationService();

temperatureSensor.HighTemperatureEventHandler += warningService.HighTemperatureWarning;
temperatureSensor.HighTemperatureEventHandler += mitigationService.CoolReactor;
temperatureSensor.LowTemperatureEventHandler += warningService.LowTemperatureWarning;
temperatureSensor.LowTemperatureEventHandler += mitigationService.HeatReactor;
temperatureSensor.LowTemperatureEventHandler = null;
Simulate();

void Simulate()
{
    for(int i = 0;i<=20;i++)
    {
        temperatureSensor.GenerateTemperature();
        Thread.Sleep(500);
    }
}