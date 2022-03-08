//�̸� ������ �⺻�� WebApplicationBuilder�� �����
var builder = WebApplication.CreateBuilder(args);

//WebApplicationBuilder�� Razor ������ ������ �߰��ϰ�
// Add services to the container.
builder.Services.AddRazorPages();

//���� �����մϴ�.
var app = builder.Build();


//������ ���� ������
//�⺻������ ����ϵ��� �����Ǿ� �ִ�.
//���ܿ� ���� ������ ������ �����Ѵ�.

//������ ���� �������� �߿��� ������ ������ �� �����Ƿ�,
//���� ��忡�� ���δ��� ���� �����ؼ��� �ȵ˴ϴ�.
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //���� ���� ��忡�� ������� ���� ��� ���� �ڵ�� ���� ��������Ʈ�� /Error�� �����ϰ� /Error�� ����ϵ��� ����
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//���� �ڵ�� ���� ���δ��� �Ǵ� �׽�Ʈ ��忡 ���� �� ����ȴ�.

//app.UseHttpsRedirection(); : HTTP ��û�� HTTPS�� ���𷺼��մϴ�.
//app.UseStaticFiles(); : HTML, CSS, �̹���, JavaScript�� ���� ���� ������ �����ǵ��� �����մϴ�. �ڼ��� ������ ASP.NET Core�� ���� ������ �����ϼ���.
//app.UseRouting(); : ��� ��ġ�� �̵���� ���������ο� �߰��մϴ�. �ڼ��� ������ ASP.NET Core�� ������� �����ϼ���.
//app.MapRazorPages(); : Razor Pages�� ���� ��������Ʈ ������� �����մϴ�.
//app.UseAuthorization(); : ����ڿ��� ���� ���ҽ��� �׼����� �� �ִ� ������ �ο��մϴ�. �� ���� ���� �ο��� ������� �����Ƿ� �� ���� ������ �� �ֽ��ϴ�.
//app.Run();: ���� �����մϴ�. 
 
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
