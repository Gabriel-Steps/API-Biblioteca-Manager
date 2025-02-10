# 📚 Biblioteca Manager - API REST

Uma **API REST** desenvolvida com **ASP.NET Core** para o gerenciamento de uma biblioteca, permitindo **cadastrar, consultar, atualizar e excluir livros, usuários e empréstimos**.

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core**  
- **Entity Framework Core**  
- **SQL Server**  
- **Arquitetura Limpa** *(Separa a aplicação em camadas: API, Application, Core e Infrastructure)*  
- **CQRS (Command Query Responsibility Segregation)**  
- **Padrão Repository**  
- **FluentValidation** *(Validação dos dados de entrada)*  

## 📂 Arquitetura do Projeto

O projeto segue a **Arquitetura Limpa**, separando as responsabilidades em quatro camadas principais:

```plaintext
📦 BibliotecaManager  
 ┣ 📂 BibliotecaManager.Api           # Camada responsável pelos Controllers  
 ┣ 📂 BibliotecaManager.Application   # Define os casos de uso e interfaces  
 ┣ 📂 BibliotecaManager.Core          # Contém as entidades do domínio  
 ┣ 📂 BibliotecaManager.Infrastructure # Persistência de dados e configuração do banco  
```

## ⚙️ Configuração e Execução do Projeto

### 1️⃣ Clonar o Repositório

```sh
git clone https://github.com/Gabriel-Steps/API-Biblioteca-Manager
cd biblioteca-manager
```

### 2️⃣ Configurar a Conexão com o Banco de Dados

Edite o arquivo **`appsettings.json`** na pasta **API**, configurando a conexão com o SQL Server:

```json
"ConnectionStrings": {
  "ConexaoPadrao": "Server=localhost; Initial Catalog = SistemaBiblioteca; TrustServerCertificate=True; Integrated Security=True"
}
```

### 3️⃣ Aplicar as Migrations

Execute os seguintes comandos para criar o banco de dados:

```sh
dotnet ef database update
```

### 4️⃣ Executar a API

```sh
dotnet run --project BibliotecaManager.Api
```

A API estará disponível em:
📌 **Swagger UI:** [`https://localhost:5015/swagger`](https://localhost:5015/swagger)

---

## 🛠️ Principais Funcionalidades

### 📖 Gerenciamento de Livros

✔️ Cadastrar um novo livro  
✔️ Listar todos os livros  
✔️ Consultar um livro por ID  
✔️ Excluir um livro  

### 👤 Gerenciamento de Usuários

✔️ Cadastrar um novo usuário  
✔️ Consultar um usuário por ID  

### 📅 Gerenciamento de Empréstimos

✔️ Criar um novo empréstimo  
✔️ Devolver um livro (exclui o empréstimo, pois o sistema não possui histórico)  

---

## 🔥 Exemplos de Requisições

### ✅ Cadastrar um Livro *(POST `/api/livros`)*

```json
{
  "titulo": "O Senhor dos Anéis",
  "autor": "J.R.R. Tolkien",
  "isbn": "9783161484100",
  "anoDeLancamento": 1954
}
```

### ✅ Criar um Empréstimo *(POST `/api/emprestimos`)*

```json
{
  "idLivro": 1,
  "idUsuario": 2
}
```

### ✅ Devolver um Livro *(DELETE `/api/emprestimos/{id}`)*

```json
{
  "mensagem": "O livro foi devolvido dentro do prazo"
}
```

---

## 📜 Observação sobre a Devolução de Livros

Atualmente, o sistema **deleta** um empréstimo ao devolver um livro. O ideal seria **alterar o status do empréstimo em vez de removê-lo**, mas essa funcionalidade só faria sentido se o sistema tivesse um **histórico de empréstimos**.

---

## 📌 Futuras Melhorias

🔹 Implementar histórico de empréstimos para cada usuário  
🔹 Melhorar o sistema de notificações para atrasos na devolução  
🔹 Criar autenticação de usuários via JWT  

---

## 👨‍💻 Desenvolvido por

Projeto desenvolvido com **Next Wave Education**, sob a mentoria de **Luis Felipe**.  

🔗 Conecte-se comigo no [LinkedIn](https://www.linkedin.com/in/gabrielpassosfrancisco/)  

---
