Pacotes utilizados
- Microsoft.EntityFrameworkCore
- Npgsql.EntityFrameworkCore.PostgreSQL
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools

Arquivos necessários 
- Entidade que será mapeada
- Pasta "Mappings" com arquivo de mapeamento da entidade
- Pasta "Data" com o arquivo DbContext

Para realizar as migrações
Ferramentas -> Gerenciador de pacotes Nuget -> Console do gerenciador de pacotes
* é necessario ir até o diretório do arquivo dbcontext no terminal do nuget
- Add-Migration [Nome da migração]
- Update-Database [Aplicar as mudanças no banco caso necessário]
