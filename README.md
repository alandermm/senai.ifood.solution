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
dotnet ef migrations add BancoInicial --startup-project ../senai.ifood.webapi/senai.ifood.webapi.csproj
dotnet ef database update --startup-project ..\senai.ifood.webapi\senai.ifood.webapi.csproj
dotnet sln add "senai.ifood.domain/senai.ifood.domain.csproj";dotnet sln add "senai.ifood.repository/senai.ifood.repository.csproj";dotnet sln add "senai.ifood.webapi/senai.ifood.webapi.csproj"


#SQL Teste
Use IFoodBanco

insert into Usuarios(email, senha, datacriacao) values('administrador@administrador.com.br', '123456', GETDATE()),
                                                      ('restaurante@restaurante.com.br', '123456', GETDATE()),
                                                      ('cliente@liente.com.br', '123456', GETDATE())


insert into Permissoes(datacriacao, Nome) values(GETDATE(),'Administrador'),
                                                (GETDATE(), 'Restaurante'),
                                                (GETDATE(), 'Cliente')


insert into UsuariosPermissoes(UsuarioId,PermissaoId, DataCriacao) values (1,1, GETDATE()), (2,2, GETDATE()),(3,3, GETDATE())



insert into Especialidades(datacriacao, Nome) VALUEs(Getdate(), 'Pizzaria'),
                                 (GETDATE(), 'Vegetariano'),
                                 (GETDATE(), 'Hamburgueria')



INSERT into Restaurantes(datacriacao, Email,EspecialidadeId,Nome,Responsavel,Site,Telefone,UsuarioId) VALUES(GETDATE(), 'pizzaria@pizzaria.com.br', 1, 'Pizzaria da Nona', 'Pietro','www.site','5873333',2),
                                (GETDATE(), 'pizzaria1@pizzaria1.com.br', 1, 'Pizzaria da Mama', 'Pierre','www.site','5873333',2),
                                (GETDATE(), 'vegeratiano@vegetariano.com.br', 2, 'Naturalistas', 'Pedro','www.site','5873333',2),
                                (GETDATE(), 'vegetariano1@vegetariano1.com.br', 2, 'Moema Natural', 'Roberto','www.site','5873333',2),
                                (GETDATE(), 'porksburguer@porksburguer.com.br', 3, 'Porks Burguer', 'Pedro', 'www.site', '5873333',2),
                                (GETDATE(), 'hamburgueriaonal@hal.com.br', 3, 'Hamburgueria Nacional', 'Roberto','www.site','5873333',2)


INSERT into ProdutosRestaurantes(Ativo, DataCriacao,Descricao,Nome,RestauranteId, Valor) values(1, GETDATE(), 'descricao','Pizza 4 queijos', 1, '42.00'),
                                                                        (1, GETDATE(), 'descricao', 'Pizza 4 queijos', 1, '42.00'),
                                                                        (1, GETDATE(), 'descricao','Pizza Mussarela', 2, '28.00'),
                                                                        (1, GETDATE(), 'descricao','Pizza Calabresa', 2, '28.00'),
                                                                        (1, GETDATE(), 'descricao','Batata Frita Vegana', 3, '18.00'),
                                                                        (1, GETDATE(), 'descricao','Strogonoff de Shitake', 3, '35.00'),
                                                                        (1, GETDATE(), 'descricao','Jaca Louca', 4, '35.00'),
                                                                        (1, GETDATE(), 'descricao','X Salada', 5, '25.00'),
                                                                        (1, GETDATE(), 'descricao','X Burguer Bacon', 6, '25.00')

insert into Clientes(DataCriacao, DataNascimento, Nome, Sexo, UsuarioId) VALUES(GetDate(), '10/10/1978 00:00:00.000', 'Fernando', 'Masculino',3)