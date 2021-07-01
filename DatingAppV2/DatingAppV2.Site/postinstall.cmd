dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet restore
dotnet ef

cd ..\DatingAppV2.Data\
dotnet ef migrations add CreateDb
dotnet ef database update
cd ..\DatingAppV2.Site\

npm install

