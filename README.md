# ☕ Cafeteria - Sistema com Design Patterns
## 📌 Descrição

Este projeto implementa uma simulação de um sistema de pedidos de uma cafeteria.
O sistema recebe pedidos, permite personalização de bebidas, calcula custos e simula a entrega, além de notificar clientes sobre atualizações no estoque.

O principal objetivo é aplicar 8 padrões de projeto (GoF) em uma arquitetura única, coerente e modular.

## 🎯 Objetivo
 - Simular pedidos de uma cafeteria
 - Permitir personalização de bebidas
 - Calcular entrega
 - Notificar clientes
 - Integrar com API externa
 - Utilizar múltiplos padrões de projeto
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

 - nome
 - telefone
 - site
 - taxa base de entrega
### **Facade**

Simplifica a criação de pedidos:

 - combos prontos
 - escolha de ingredientes
 - interface única para o cliente
### **Observer**

Clientes cadastrados recebem notificações quando:

 - ingrediente acaba
 - ingrediente é reposto
 - novo ingrediente é adicionado
### **Adapter**

Integra o sistema com uma API externa de clientes, convertendo dados e filtrando clientes ativos (menos de 6 meses sem pedidos).

### **Proxy**

Implementa cache para consultas ao “banco de dados”, evitando acessos repetidos e melhorando o desempenho.

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
## 🏗️ Arquitetura do Sistema
Cliente
   ↓
Facade (criação do pedido)
   ↓
Decorator (adicionais)
   ↓
Strategy (cálculo de entrega)
   ↓
Proxy (cache)
   ↓
Adapter (API externa clientes)
   ↓
Factory (criação de notificações)
   ↓
Observer (clientes recebem aviso)
   ↓
Singleton (configurações globais)
## 🔄 Fluxo de Execução
 - Cliente realiza pedido
 - Facade cria bebida base
 - Decorator adiciona ingredientes
 - Strategy calcula frete
 - Proxy verifica cache
 - Adapter obtém clientes ativos
 - Factory cria notificação
 - Observer notifica clientes
 - Singleton fornece configurações
## 📂 Estrutura do Projeto
```
├──src/
│  ├── Factory/
│  ├──Singleton/
│  ├── Facade/
│  ├── Observer/
│  ├── Adapter/
│  ├── Proxy/
│  ├── Strategy/
│  └── Decorator/
└──README.md/
 ```
## 🚀 Tecnologias
 - C#
 - .NET
 - Programação Orientada a Objetos
 - Design Patterns (GoF)
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