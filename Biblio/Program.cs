#region References
using Biblio.DAL.Interfaces;
using Biblio.DAL.Models.Book;
using Biblio.DAL.Repositories;
#endregion

var builder = WebApplication.CreateBuilder(args);

#region Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.Configure<BookStoreDatabaseSettings>(builder.Configuration.GetSection("BooksDb"));
#endregion

var app = builder.Build();

#region Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion