# CursoMVC
Usando Entity Framework e Migrations


projeto criado com o comando

    dotnet new mvc

Usando o modelo Code First do Enntity Framework

    [X] code first
    [ ] model first
    [ ] database first

Dependências:

    dotnet add package Microsoft.EntityFrameworkCore --version 3.1.3

    dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.1

    dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1


### PASSOS para ativar Entity Framework Core:

para puxar os registros do banco de dados: ainda não temos nenhuma tabela criada. abrir o terminal do vscode e gerar nossa primeira Migration rodando o comando:

(se já estiver com as migrations prontas basta pular esse passo)

    dotnet ef migrations add PrimeiraMigration

qualquer nome pode ser adicionado após o add. este comando gerara uma tabela no seu schema com o nome dado no DataContext, no caso a primeira tabela que criará será a de Pessoas pois foi a unica que mapeamos até o momento.

depois insira o comando para criar as tabelas e também o banco de dados:

    dotnet ef database update

caso queira ver o processo de execução, basta rodar com o -v no final do comandouPD


### .CSPROJ do tutorial:

ver aquivo ".CSPROJ-do-tutorial" na raiz do projeto

### END/.CSPROJ do tutorial:



