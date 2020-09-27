**1. 進入專案資料夾../Wish/WishLog 中下指令 indocker-compose up -d**

**2. Visual Studio 在 PMC 中，輸入下列命令：**
Add-Migration InitialCreate Update-Database Visual Studio Code / Visual Studio for Mac dotnet tool install --global dotnet-ef dotnet ef migrations add InitialCreate dotnet ef database update

**3.執行專案WishLogin，進入首頁 https://localhost:29821/**
