# 👟 VortexShoes — Sistema Integrado de Gestão e Vendas

> **Projeto Integrador — Senac**  
> Solução corporativa híbrida para gerenciamento de estoque, vendas e controle de funcionários no segmento de calçados.

---

## 📌 Visão Geral do Projeto

A **VortexShoes** é uma plataforma de gestão composta por dois ecossistemas integrados que compartilham uma base de dados unificada no **MySQL**:

1. **Aplicação Desktop (Windows Forms / C#):** Voltada para a operação presencial, controle de estoque, cadastro de produtos, funcionários e relatórios operacionais.
2. **Painel Web (PHP):** Voltado para demonstração com vitrine de produtos, cadastros e visualização de gráficos.

---

## 🛠️ Tecnologias Utilizadas

### **Desktop (C#)**

- **Linguagem:** C# (.NET Framework)
- **Interface:** Windows Forms, Guna UI Framework (componentes modernos) e dashboard gráfico.
- **Acesso a Dados:** `MySql.Data` (Connector/NET).

### **Web (PHP)**

- **Linguagem:** PHP
- **Servidor Web:** Apache (XAMPP)
- **Estilização:** HTML5, CSS3 e JavaScript.

### **Banco de Dados**

- **SGBD:** MySQL / MariaDB.

---

## 📂 Estrutura do Repositório

```text
VortexShoes/
├── SiteWeb/               # Código-fonte do sistema PHP (Painel/Web)
├── Banco_de_Dados/        # Modelos do banco de dados e script de backup
├── images-produtos/       # Imagens cadastradas de produtos
├── images-funcionarios/   # Imagens cadastradas de funcionários
├── VortexShoes/           # Solução e projeto C# (Desktop Windows Forms)
│   └── VortexShoes.sln    # Arquivo de solução do Visual Studio
└── README.md              # Documentação do repositório
```

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

- XAMPP (com Apache e MySQL ativos).
- Visual Studio 2019/2022 com a carga de trabalho **Desenvolvimento para desktop com .NET**.
- Git.

### 1. Configuração da Aplicação Web (PHP)

**1.** Clone este repositório para a pasta `htdocs` do XAMPP:

```bash
cd C:\xampp\htdocs
git clone https://github.com/gbsiqueira/VortexShoes.git
```

**2.** Abra o XAMPP Control Panel e inicie os serviços Apache e MySQL.

**3.** Importe o banco de dados pelo phpMyAdmin ([http://localhost/phpmyadmin](http://localhost/phpmyadmin)), utilizando o script disponível na pasta `Banco_de_Dados/`.

**4.** Acesse o site pelo navegador:

[http://localhost/VortexShoes/SiteWeb/](http://localhost/VortexShoes/SiteWeb/)

### 2. Configuração da Aplicação Desktop (C#)

**1.** Abra a pasta do projeto clonado no seu computador.

**2.** Navegue até a pasta `VortexShoes/` e abra o arquivo `VortexShoes.sln` no Visual Studio.

**3.** Se o Visual Studio solicitar a restauração das dependências, clique em **Restaurar Pacotes do NuGet**.

**4.** Certifique-se de que o MySQL está em execução no XAMPP.

**5.** Pressione `F5` ou clique em **Iniciar** para executar o sistema desktop.

Utilize esse login para ter acesso ao sistema desktop e ao painel administrativo da web

login: admin
senha: admin

---

## 👤 Autor

Desenvolvido como projeto prático durante a formação técnica no Senac.