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
   ```
2. **Configure o banco de dados**
   ```bash
   dotnet ef database update
   ```
3. **Inicie a aplicação**
   ```bash
   dotnet run
   ```
4. **Usando Swagger UI**
   ```Acesse
   http://localhost:5000/swagger
   ```
<img src="/images/print_dotnet_run.png">.

## 🛠️ Tecnologias utilizadas
* .NET 9.0
* Entity Framework Core 9.0
* Swagger/OpenAPI
* SQL Server
* Padrões de Projeto
* Repository Pattern
* DTOs (Data Transfer Objects)
* Injeção de Dependência


## 📚 Documentação da API
Endpoints disponíveis

* POST	/api/aluno	Cadastra um novo aluno
* GET	/api/aluno	Lista todos os alunos
* GET	/api/aluno/{id}	Obtém detalhes de um aluno
* PUT	/api/aluno/{id}	Atualiza os dados de um aluno
* DELETE	/api/aluno/{id}	Remove um aluno

Modelo de dados
```
{
  "alunoId": 1,
  "nome": "João Silva",
  "email": "joao@email.com"
}
```

Via CURL:

```bash
# Criar aluno
curl -X POST "http://localhost:5000/api/aluno" \
  -H "Content-Type: application/json" \
  -d '{"nome":"Maria Oliveira","email":"maria@email.com","senha":"123456"}'
```
## 🤝 Contribuição
1. Faça um clone do projeto
   ```
   git clone https://github.com/Gabriel-Puttin/GestaoDeProva.git
   ```

2. Crie uma branch
   ```
   git checkout -b <nome da sua branch>
   ```

3. Commit suas alterações
   ```
   git commit -m <mensagem>
   ```

4. Push para a branch (git push origin feature/nova-feature)
   ```
   git push origin <nome da sua branch>
   ```

5. Abra um Pull Request

## 📄 Licença
Este projeto é de uso livre para fins educacionais e demonstrativos.

## ✉️ Contato
Gabriel Puttin - gabrielputtin@hotmail.com
