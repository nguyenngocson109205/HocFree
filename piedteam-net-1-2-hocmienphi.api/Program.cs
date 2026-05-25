var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

// Kiến trức 3 layer.

// tầng api 
    // chịu trách nhiệm khai báo các endpoint,
        // nhận request, trả respone
    // cònfig hệ thống    
    // tầng api gọi tới service
// tầng services
    // ttatantântầntầngtầntầttgtggogoigọigọi ttotơtơitớitới ttatantântầntầngtầng rrereprepo
// tầng repository 
    // chịu trách nhiệm tương tác với database 
    // cấu hình những thứ liên qua tới database
    
    // repo ttầng cái api: eq lmuốn  đănđăng  nhậnhập  vàovào hệ hệ hốthống
        // g 
        //chui vô: POST / api/ auth/ login
            // nhânj request body {email: "son", password: "123}
            // có 1 cái Req là đăng nhập vào hệ thống
            //// Tầng API: Muốn đăng nhập vào hệ thống á
            //    // Chui vô đây nè: POST /api/auth/login
            //        // Nhận request body {email: "tan", password: "123"}
            //// Tầng API lúc này gọi xuống tầng Service có cái hàm là
            //    // Xử lí login: LoginHandler(email, password)
            //    // Lúc này hàm login trong Service hãy chạy như sau
            //        // Kiểm tra email | người có tồn tại trong database hay không
            //        // người dùng này có b có bị banned hay không 
            // nếu có lỗi thì trả về lỗi 
            // nếu không có lỗi thì trả về token đăng nhập
            // tầng server lúc này gọi api xuống có cái hàm là 
            // GetUuserByEmail(email)
            // hamf này sẽ chạy câu lệnh SQL để
// lấy thông tin người dùng ra hỏi database 
    