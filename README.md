dotnet new solution -o senai.ifood.solution
cd senai.ifood.solution
dotnet new classlib -o .\senai.ifood.domain
dotnet new classlib -o .\senai.ifood.repository
dotnet new web -o senai.ifood.webapi
cd .\senai.ifood.domain\; dotnet add package System.ComponentModel.Annotations --version 4.4.1
cd ..
cd .\senai.ifood.repository\
dotnet add package Microsoft.EntityFrameworkCore --version 2.0.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 2.0.1
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 2.0.1