# 💼 Fechamento de Caixa — Motoqueiros

Sistema desktop desenvolvido para substituir o controle manual (em papel) do fechamento de pagamentos de motoqueiros em um restaurante de delivery.

---

## 🚀 Sobre o projeto

O sistema nasceu de uma necessidade real: o fechamento semanal dos motoqueiros era feito à mão, em caderno, o que gerava erros e retrabalho. Este aplicativo automatiza todo esse processo de forma simples e confiável.

---

## ✨ Funcionalidades

- 📋 **Cadastro de motoqueiros** — adicionar, editar e remover
- 📅 **Fechamento diário** — registro de entregas por taxa (R$5, R$7, R$10), valor fixo e descontos
- 💸 **Controle de vales** — registro, baixa e histórico de vales por motoqueiro
- 📊 **Relatórios por período** — resumo consolidado de ganhos por motoqueiro
- 📁 **Fechamento final** — geração do fechamento de um período completo
- 💾 **Backup automático** — salva cópia do banco na área de trabalho

---

## 🛠️ Tecnologias utilizadas

| Camada | Tecnologia |
|---|---|
| Linguagem | C# (.NET) |
| Interface | Windows Forms (WinForms) |
| Banco de dados | SQLite |
| ORM | Entity Framework Core |

---

## 🏗️ Arquitetura

O projeto é dividido em duas soluções:

```
FechamentoCaixa/          # Back-end
├── Entities/             # Modelos: Motoqueiro, FechamentoDia, Vales, FechamentoFinal
├── DataBase/             # DbContext e todos os métodos de acesso ao banco
├── Services/             # Regras de negócio por entidade
└── ViewModels/           # Modelos de apresentação para relatórios

FechamentoCaixaForms/     # Front-end
└── Forms/                # Telas WinForms
```

---

## ▶️ Como rodar

**Pré-requisitos:**
- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download)

**Passos:**
```bash
# Clone o repositório
git clone https://github.com/joaomarcelo-java/Fechamento-de-Caixa.git

# Acesse a pasta
cd Fechamento-de-Caixa

# Execute o projeto
dotnet run --project FechamentoCaixaForms
```

> O banco de dados SQLite (`fechamento.db`) é criado automaticamente na primeira execução.

---

## 💡 Motivação

> "A folha do fechamento do dia rasgou!"

Esse projeto foi desenvolvido para resolver um problema real do meu trabalho — transformar um processo manual e suscetível a erros em algo automatizado, confiável e fácil de usar.

---

## 👨‍💻 Autor

**João Marcelo**  
[![LinkedIn](https://img.shields.io/badge/LinkedIn-joaomarcelo-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/jo%C3%A3o-marcelo-0244ba35a/)
[![GitHub](https://img.shields.io/badge/GitHub-joaomarcelo--java-black?style=flat&logo=github)](https://github.com/joaomarcelo-java)
