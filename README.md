### Notlar

* Banka sınıfları interface içinde gelmektedir. İlgili serviste Constructor Based Dependecy Injection hemde Setter Based Dependency Injection yöntemini örnekledim.
* Database migration yaptıktan sonra uygulamayı ilk çalıştırdığınızda dummy veriler için DataSeeding classı hazırlanmıştır.
* Uygulamayı MacBook üzerinde Visual Studio ile geliştirilmiştir.
* Swagger ile test edilmiştir.

### Database Migrations

* dotnet ef --startup-project ../CCPayment.API database update
* dotnet ef --startup-project ../CCPayment.API migrations add Initial
* dotnet ef --startup-project ../CCPayment.API database update