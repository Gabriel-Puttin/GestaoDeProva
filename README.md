# 🎓 API de Gestão de Provas

API para gerenciamento de alunos e provas, desenvolvida em .NET 9.0 com Entity Framework Core e SQL Server.

[![.NET](https://img.shields.io/badge/.NET-9.0-purple)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-9.0-blue)](https://docs.microsoft.com/ef/core/)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

## 📋 Pré-requisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server 2022](https://www.microsoft.com/sql-server/sql-server-downloads) ou [SQL Server Express LocalDB](https://docs.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

## 🚀 Como executar

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/gestao-de-provas.git
   cd gestao-de-provas/src/GestaoDeProvas
Configure o banco de dados

bash
dotnet ef database update

Inicie a aplicação

bash
dotnet run

🛠️ Tecnologias utilizadas
Backend

.NET 9.0

Entity Framework Core 9.0

Swagger/OpenAPI

SQL Server

Padrões de Projeto

Repository Pattern

DTOs (Data Transfer Objects)

Injeção de Dependência

📚 Documentação da API
Endpoints disponíveis
Método	Endpoint	Descrição
POST	/api/aluno	Cadastra um novo aluno
GET	/api/aluno	Lista todos os alunos
GET	/api/aluno/{id}	Obtém detalhes de um aluno
PUT	/api/aluno/{id}	Atualiza os dados de um aluno
DELETE	/api/aluno/{id}	Remove um aluno
Modelo de dados
json
{
  "alunoId": 1,
  "nome": "João Silva",
  "email": "joao@email.com"
}
🧪 Testando a API
Usando Swagger UI:

Acesse http://localhost:5000/swagger

Execute os endpoints diretamente na interface

Via cURL:

bash
# Criar aluno
curl -X POST "http://localhost:5000/api/aluno" \
  -H "Content-Type: application/json" \
  -d '{"nome":"Maria Oliveira","email":"maria@email.com","senha":"123456"}'
🤝 Contribuição
Faça um fork do projeto

Crie uma branch (git checkout -b feature/nova-feature)

Commit suas alterações (git commit -m 'Adiciona nova feature')

Push para a branch (git push origin feature/nova-feature)

Abra um Pull Request

📄 Licença
Este projeto está licenciado sob a licença MIT - veja o arquivo LICENSE para detalhes.

✉️ Contato
Gabriel Puttin - seu-email@exemplo.com
