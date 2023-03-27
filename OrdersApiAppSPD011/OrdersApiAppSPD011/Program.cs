using OrdersApiAppSPD011.Model;
using OrdersApiAppSPD011.Model.Entity;
using OrdersApiAppSPD011.Service.ClientService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoProduct, DbDaoProduct>();
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();
app.MapControllers();

app.MapGet("/ping", () => new {Time = DateTime.Now, Message = "pong"});

app.MapGet("/client/all", async (IDaoClient daoClient) =>
{
    return await daoClient.GetAllAsync();
});

app.MapPost("/client/add", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.AddAsync(client);
});

app.MapGet("/client/delete", async (int id, IDaoClient daoClient) =>
{
    return await daoClient.DeleteAsync(id);
});

app.MapGet("/client/find", async (int id, IDaoClient daoClient) =>
{
    return await daoClient.GetAsync(id);
});

app.MapPost("/client/update", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.UpdateAsync(client);
});

// Product

/*app.MapGet("/product/all", async (IDaoProduct daoProduct) =>
{
    return await daoProduct.GetAllAsync();
});

app.MapPost("/product/add", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.AddAsync(product);
});

app.MapGet("/product/delete", async (int id, IDaoProduct daoProduct) =>
{
    return await daoProduct.DeleteAsync(id);
});

app.MapGet("/product/find", async (int id, IDaoProduct daoProduct) =>
{
    return await daoProduct.GetAsync(id);
});

app.MapPost("/product/update", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.UpdateAsync(product);
});*/


app.Run();
