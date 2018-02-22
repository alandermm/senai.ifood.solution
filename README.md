dotnet new solution -o senai.ifood.solution
cd senai.ifood.solution
dotnet new classlib -o .\senai.ifood.domain
dotnet new classlib -o .\senai.ifood.repository
dotnet new web -o senai.ifood.webapi
 cd .\senai.ifood.domain\; dotnet add package System.ComponentModel.Annotations --version 4.4.1
 