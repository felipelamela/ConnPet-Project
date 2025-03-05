var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => "Hello World!");
app.MapPut("/", () => "Hello World!");
app.MapDelete("/", (Request request, Handler handler,) => handler.Handle(request)).Produces<Response>();


app.Run();


public class Request
{
    public string Title { get; set; }
}

public class Response
{
    public long Id { get; set; }
    public string Title { get; set; }
}

public class Handler
{
    public Response Handle(Request request)
    {

        return new Response { Id = 2, Title = "Testo" };
    }
}