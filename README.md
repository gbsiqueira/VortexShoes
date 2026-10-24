# 👟 VortexShoes

> **Projeto Integrador — Senac**  

---

## 📌 Visão Geral do Projeto

A **VortexShoes** é uma plataforma de gestão composta por dois ecossistemas integrados que compartilham uma base de dados unificada no **MySQL**:

1. **Aplicação Desktop (Windows Forms / C#):** Voltada para a operação presencial, controle de estoque, cadastro de produtos, funcionários e relatórios operacionais.
2. **Painel Web (PHP):** Voltado para desmonstração com vitrine de produtos, cadastros, visualização de gráficos.

---

## 🛠️ Tecnologias Utilizadas

### **Desktop (C#)**
* **Linguagem:** C# (.NET Framework)
* **Interface:** Windows Forms, Guna UI Framework (Componentes modernos) & Dashboard gráfico
* **Acesso a Dados:** `MySql.Data` (Connector/NET)

### **Web (PHP)** de 
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
├── Banco_de_Dados/        # Modelos do Banco de dados e o script com backup
│── images-produtos/       # Imagens cadastradas de produtos
│── images-funcionarios/   # Imagens cadastradas de funcionários
├── VortexShoes/           # Solução e projeto C# (Desktop Windows Forms)
│   └── VortexShoes.sln    # Arquivo de solução do Visual Studio
└── README.md              # Documentação do repositório

---

## 🚀 Como Executar o Projeto
Pré-requisitos
XAMPP (com Apache e MySQL ativos)

Visual Studio 2019/2022 com a carga de trabalho "Desenvolvimento para desktop com .NET"

Git

1. Configuração da Aplicação Web (PHP)
Clone este repositório para a sua pasta htdocs:

Bash
cd C:\xampp\htdocs
git clone [https://github.com/gbsiqueira/VortexShoes.git](https://github.com/seu-usuario/VortexShoes.git)
Abra o XAMPP Control Panel e inicie os serviços Apache e MySQL.

Importe o banco de dados MySQL via phpMyAdmin (http://localhost/phpmyadmin) utilizando o script na pasta Banco_de_Dados/.

Acesse o site no navegador: http://localhost/VortexShoes/SiteWeb/.

2. Configuração da Aplicação Desktop (C#)
Abra a pasta do projeto clonado no seu computador.

Navegue até a pasta VortexShoes/ e abra o arquivo VortexShoes.sln no Visual Studio.

Se o Visual Studio pedir para restaurar as dependências, clique em Restaurar Pacotes do NuGet.

Certifique-se de que o MySQL está em execução no XAMPP.

Pressione F5 ou clique em Iniciar para rodar o sistema desktop.

👤 Autor
Desenvolvido como projeto prático durante a formação técnica no Senac.