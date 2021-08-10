# Módulo de Ordem de Serviço utilizando Application AspNet Core MVC 

Objetivo: Praticar e compartilhar conhecimento sobre a arquitetura .NET

1. Crie do projeto

2. Adicione os seguintes pacotes:
   Microsoft.EntityFrameWorkCore.SqlServer
   Microsoft.EntityFrameWorkCore.Tools

3. Criar Model Ordem de serviço

4. Criar Model Context

5. Adicionar String de conexão em Context

6. Adicionar Context em Startup 

7. Conexão com o banco de dados localdb
   String de conexão: "Server=(localdb)\\mssqllocaldb;Database=ServicoMvc;Integrated Security=true"

8. No Console do Gerenciador de Pacotes
   Digite Add-Migration Base-Inicial
   Update-Database

9. Criar um controller de ordens de serviço 