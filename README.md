# 🛒 Cadastro de Produtos

Aplicação para cadastro de produtos, utilizando .NET Core no back-end, SQL Server como banco de dados e Bootstrap no front-end.

---
## 📋 Funcionalidades

- ✅ CRUD de produtos (Nome, Descrição, Preço, Categoria)
- ✅ Filtros por nome e categoria
- ✅ Front-end simples com Bootstrap

---

## 📸 Imagem do Projeto

<img width="1920" height="944" alt="home" src="https://github.com/user-attachments/assets/5f8f49ff-0d87-46a9-ad2d-8910f4246046" />

---

<img width="1853" height="873" alt="produtos" src="https://github.com/user-attachments/assets/4bfb9344-6336-4e3a-bfd4-ebfc8aa00aae" />

---

## 🧰 Tecnologias Utilizadas

### 🔙 Back-End (.NET Core)
- ASP.NET Core 8.0
- C#
- Entity Framework Core
- SQL Server

### 🎨 Front-End
- HTML, CSS
- Bootstrap 5

### 🛢 Banco de Dados
- SQL Server Management Studio (SSMS)

---

## 🛠️ Como Rodar o Projeto

### ⚙️ Pré-requisitos

- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- [.NET SDK 7.0 ou superior](https://dotnet.microsoft.com/en-us/download)
- SQL Server Management Studio (SSMS)

---

### 🧪 Passo a Passo para Rodar

#### 1. Clone o projeto

```bash
git clone https://github.com/matheusgoliveiraa/CrudProdutosDev.git
cd CrudProdutosDev
```

#### 2. Configure a Conexão com o Banco de Dados

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-36PHNT6\\SQLEXPRESS; Database=Produtos; trusted_connection = true; encrypt=false"
}
```
#### 3. Pacotes NuGet

```bash
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

### 4. Execute as Migrations

```bash
dotnet ef database update
```

### 5. Rode o Projeto
```bash
dotnet run
```


