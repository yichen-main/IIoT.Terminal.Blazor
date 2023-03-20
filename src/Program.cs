try
{
    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.Services.AddScoped(item => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

    await builder.Build().RunAsync();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}