mkdir Projectes/EF
cd Projectes/EF
mkdir Course
cd Course/
dotnet new mvc
mkdir tmp
cd tmp
dotnet new classlib --name DataAccess
dotnet new classlib --name Model
mkdir ../Libraries
mv * ../Libraries/
cd ..
rm -r tmp/
mv Models Libraries/Model/
mkdir Libraries/DataAccess/Data
rm Libraries/DataAccess/Class1.cs 
rm Libraries/Model/Class1.cs 

# Afegir referències a llibreries
dotnet add UdemyCourse.csproj reference Libraries/Model/Model.csproj 
dotnet add UdemyCourse.csproj reference Libraries/DataAccess/DataAccess.csproj 
dotnet add Libraries/DataAccess/DataAccess.csproj reference Libraries/Model/Model.csproj

dotnet add package Microsoft.EntityFrameworkCore
cd Libraries/DataAccess/
dotnet add package Microsoft.EntityFrameworkCore
cd ../..
code .
