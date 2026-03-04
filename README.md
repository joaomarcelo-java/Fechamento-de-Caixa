# 💰 Sistema de Fechamento de Caixa

Sistema desktop desenvolvido em C# com Windows Forms para automatizar e padronizar o processo de fechamento de caixa diário.

## 📌 Sobre o Projeto

Este sistema foi desenvolvido para resolver um problema real no ambiente de trabalho: o fechamento de caixa era realizado manualmente, gerando erros de cálculo, retrabalho e falta de padronização.

A aplicação automatiza cálculos, valida informações e organiza os dados de forma segura, reduzindo falhas humanas e aumentando a produtividade.

Projeto desenvolvido como aplicação prática dos conceitos de Programação Orientada a Objetos e organização em camadas.

---

## 🚀 Tecnologias Utilizadas

- C#
- .NET
- Windows Forms
- Programação Orientada a Objetos
- Arquitetura em Camadas

---

## 🏗️ Arquitetura do Projeto

O sistema foi estruturado seguindo o princípio de separação de responsabilidades:
FechamentoDeCaixa
├── FechamentoCaixa (Core - regras de negócio)
├── FechamentoCaixaForms (Interface gráfica)
└── FechamentoCaixa.sln


### 🔹 Core
Contém:
- Entidades
- Regras de negócio
- Validações
- Services

### 🔹 Forms
Contém:
- Interface gráfica
- Interação com o usuário
- Chamadas para a camada de serviço

---

## ⚙️ Funcionalidades

✔ Cálculo automático do fechamento  
✔ Controle de descontos e vales  
✔ Validação de dados antes da finalização  
✔ Tratamento de exceções personalizadas  
✔ Organização modular do código  
✔ Sistema de backup  

---

## 📊 Resultados Obtidos

- Redução de erros de cálculo
- Maior agilidade no processo
- Padronização do fechamento
- Melhor controle financeiro interno

---
