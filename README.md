# ☕ Cafeteria - Sistema com Design Patterns
## 📌 Descrição

Este projeto consiste na simulação de um sistema de pedidos de uma cafeteria, desenvolvido em C#/.NET, com foco na aplicação prática de 8 padrões de projeto (GoF) de forma integrada e coerente.

O sistema permite:

 - Criar bebidas
 - Personalizar pedidos
 - Calcular entrega
 - Simular finalização do pedido
 - Notificar clientes sobre atualizações
## 🎯 Objetivo
 - Aplicar múltiplos padrões de projeto em um único sistema
 - Demonstrar arquitetura modular e desacoplada
 - Simular um fluxo real de pedidos de cafeteria
 - Consolidar conceitos de Programação Orientada a Objetos
## 🧩 Padrões de Projeto Utilizados
### **Factory**

Responsável por criar diferentes tipos de notificações:

 - WhatsApp
 - Email
 - SMS

Utilizado para avisar eventos como:

 - pedido saiu para entrega
 - ingrediente indisponível
 - ingrediente reposto

### **Singleton**

Gerencia configurações globais da cafeteria:

 - nome da aplicação
 - cofigurações gerais
 - lista de ingredientes
 - limites do sistema
### **Facade**

Simplifica a criação de pedidos:

 - criar pedidos
 - gerenciar bebidas
 - controlar fluxo do pedido
### **Observer**

Clientes cadastrados recebem notificações quando:

 - ingrediente acaba
 - ingrediente é reposto
 - novo ingrediente é adicionado
### **Adapter**

- converter formato de dados externo → interno

### **Proxy**

Implementa um Proxy de notificações com:

 - controle de tentativas
 - logs de envio
 - bloqueio ao atingir limite
### **Strategy**

Define diferentes estratégias de cálculo de entrega:

 - retirada no local
 - entrega padrão
 - entrega expressa
### **Decorator**

Permite adicionar ingredientes dinamicamente às bebidas:

 - leite
 - canela
 - chantili
 - calda

## ▶️ Como Executar o Projeto
### 🔹 Executar a simulação
```
dotnet run --project Cafeteria.App
```
### 🔹 Executar os testes
```
dotnet test
```

## 🏗️ Arquitetura do Sistema
```
Cliente
   ↓
Facade (criação do pedido)
   ↓
Decorator (adicionais)
   ↓
Strategy (cálculo de entrega)
   ↓
Proxy (protection/logging)
   ↓
Adapter (API externa clientes)
   ↓
Factory (criação de notificações)
   ↓
Observer (clientes recebem aviso)
   ↓
Singleton (configurações globais)
```
## 🔄 Fluxo de Execução
 - O cliente inicia um pedido através do Facade
 - Uma bebida base é criada
 - Ingredientes adicionais são aplicados via Decorator
 - A entrega é calculada usando Strategy
 - O Proxy controla o envio de notificações
 - O Factory cria o tipo de notificação
 - O Observer notifica os clientes
 - O Singleton fornece configurações globais
 - O Adapter integra dados externos de clientes
## 📂 Estrutura do Projeto
```
├── src/ 
│   ├── Adapter/ 
│   ├── Decorator/ 
│   ├── Factory/ 
│   ├── Facade/  
│   ├── Observer/ 
│   ├── Proxy/ 
│   ├── Singleton/ 
│   ├── Strategy/ 
│
├── Cafeteria.Tests/ 
├── Cafeteria.App/ (Executável)
│ 
└── README.md
 ```
## 🚀 Tecnologias
 - C#
 - .NET
 - Programação Orientada a Objetos
 - Design Patterns (GoF)
 - Engenharia de Software Moderna (Marco Tulio Valente)
 - xUnit (testes)
## 💡 Aprendizados
 - Aplicação prática de Design Patterns
 - Arquitetura modular
 - Redução de acoplamento
 - Separação de responsabilidades
 - Uso combinado de múltiplos padrões
## 📚 Objetivo Acadêmico

Este projeto tem fins educacionais e demonstra a aplicação integrada de múltiplos padrões de projeto em um único sistema.

## 👨‍💻 Autor

**João Vitor Moreira Gomes**