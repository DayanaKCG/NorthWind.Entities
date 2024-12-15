using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplicacion started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");