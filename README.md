# clean-api-architecture

Cấu trúc này bao gồm ít nhất 4 project cho một service, Project Constract là optional

![image](https://github.com/Group4SE1604/clean-api-architecture/assets/98259617/d87cc790-1452-4906-9b8a-1da6a6c60892)


![image](https://github.com/Group4SE1604/clean-api-architecture/assets/98259617/d52ee4e3-11d4-466b-be39-f6f13ffd8957)



### Project API ( Tầng Presentation)
- Chứa các DTOs , ViewModel, ví dụ LoginRequest.cs,LoginResponse.cs
- Chứa các controller , middleware, controller chỉ xử lý logic server
### Project Application 
- Chứa các interfaces của Repo , các Common, các Service xài chung
### Project Infrastructure
- Chứa implements của repo , implements services
### Project Domain
- Chứa các Entity của Data
