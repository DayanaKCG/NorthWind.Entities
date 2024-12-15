HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();

//IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>(); //new AppLogger(Writer);
Logger.WriteLog("Aplicacion started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>(); //new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");