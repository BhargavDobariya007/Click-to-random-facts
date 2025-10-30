var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddHttpClient(); 

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
    .WithStaticAssets();


app.MapGet("/getfact", async (IHttpClientFactory clientFactory) =>
{
    var client = clientFactory.CreateClient();
    try
    {
        var response = await client.GetAsync("https://catfact.ninja/fact");

        if (response.IsSuccessStatusCode)
        {
            var factString = await response.Content.ReadAsStringAsync();
            return Results.Content(factString, "application/json");
        }

        return Results.Problem("Could not fetch a fact right now.");
    }
    catch (Exception ex)
    {
        return Results.Problem($"An error occurred: {ex.Message}");
    }
});

app.Run();