# 👟 VortexShoes

> **Projeto Integrador — Senac**  

---

## 📌 Visão Geral do Projeto

O **VortexShoes** é uma plataforma de gestão composta por dois ecossistemas integrados que compartilham uma base de dados unificada no **MySQL**:

1. **Aplicação Desktop (Windows Forms / C#):** Voltada para a operação presencial, controle de estoque, cadastro de produtos, funcionários e relatórios operacionais.
2. **Painel Web (PHP):** Voltado para consultas rápidas, catálogo online e gerenciamento web acessível via navegador.

---

## 🛠️ Tecnologias Utilizadas

### **Desktop (C#)**
* **Linguagem:** C# (.NET Framework)
* **Interface:** Windows Forms, Guna UI Framework (Componentes modernos) & Dashboard gráfico
* **Acesso a Dados:** `MySql.Data` (Connector/NET)

### **Web (PHP)**
* **Linguagem:** PHP
* **Servidor Web:** Apache (XAMPP)
* **Estilização:** HTML5, CSS3, JavaScript

### **Banco de Dados**
* **SGBD:** MySQL / MariaDB

---

## 📂 Estrutura do Repositório

```text
VortexShoes/
├── SiteWeb/               # Código-fonte do sistema PHP (Painel/Web)
│── images-produtos/       # Imagens cadastradas de produtos
│── images-funcionarios/   # Imagens cadastradas de funcionários
├── VortexShoes/           # Solução e projeto C# (Desktop Windows Forms)
│   └── VortexShoes.sln    # Arquivo de solução do Visual Studio
└── README.md              # Documentação do repositório