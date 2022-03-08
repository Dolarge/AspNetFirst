using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspNetFirst.Data;

//미리 구성된 기본값 WebApplicationBuilder를 만들고
var builder = WebApplication.CreateBuilder(args);

//WebApplicationBuilder에 Razor 페이저 지원을 추가하고
// Add services to the container.
builder.Services.AddRazorPages();

//Model scaffolded
//EF Core 데이터베이스 컨텍스트와 같은 서비스는 애플리케이션 시작중에 종속성 주입에 등록된다.
//이런 서비스(예: Razor Pages)가 필요한 구성 요소는 생성자 매개 변수를 통해 제공된다.
builder.Services.AddDbContext<AspNetFirstContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AspNetFirstContext")));

//스캐폴딩 도구는 자동으로 데이터베이스 컨텍스트를 생성하고 종속성 주입 컨테이너에 등록했습니다.
//위의 코드는 스캐폴더에 의해 Program.cs 파일에 추가됩니다.

//앱을 빌드합니다.
var app = builder.Build();


//개발자 예외 페이지
//기본적으로 사용하도록 설정되어 있다.
//예외에 대한 유용한 정보를 제공한다.

//개발자 예외 페이지가 중요한 정보를 누출할 수 있으므로,
//개발 모드에서 프로덕션 앱을 실행해서는 안됩니다.
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //앱이 개발 모드에서 실행되지 않을 경우 다음 코드는 예외 엔드포인트를 /Error로 설정하고 /Error를 사용하도록 설정
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//위의 코드는 앱이 프로덕션 또는 테스트 모드에 있을  실행된다.

//app.UseHttpsRedirection(); : HTTP 요청을 HTTPS로 리디렉션합니다.
//app.UseStaticFiles(); : HTML, CSS, 이미지, JavaScript와 같은 정적 파일이 제공되도록 설정합니다. 자세한 내용은 ASP.NET Core의 정적 파일을 참조하세요.
//app.UseRouting(); : 경로 일치를 미들웨어 파이프라인에 추가합니다. 자세한 내용은 ASP.NET Core의 라우팅을 참조하세요.
//app.MapRazorPages(); : Razor Pages에 대한 엔드포인트 라우팅을 구성합니다.
//app.UseAuthorization(); : 사용자에게 보안 리소스에 액세스할 수 있는 권한을 부여합니다. 이 앱은 권한 부여를 사용하지 않으므로 이 줄을 제거할 수 있습니다.
//app.Run();: 앱을 실행합니다. 

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
