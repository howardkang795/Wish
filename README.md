# 商品清單功能 
  
**1. 進入專案資料夾../Wish/WishLog 中下指令 indocker-compose up -d**

**2. Visual Studio 在 PMC 中，輸入下列命令：**

Add-Migration InitialCreate Update-Database 

**Visual Studio Code / Visual Studio for Mac**

dotnet tool install --global dotnet-ef 

dotnet ef migrations add InitialCreate 

dotnet ef database update

**3.執行專案WishLogin，進入首頁 https://localhost:29821/**

# 設計概念

1.主要table分三張表，Wishlist,WishListRelateProduct,Product
因為需求中沒有描述Wishlist和user之間的關係，故不將user表和Wishlist建立關聯。

2.Wishlist表紀錄user點擊功能，WishListRelateProduct也就是Wishlist的Detail表
紀錄Descript, Url 和Wishlist, Product之間的關係。


