# 🚗 Sistema de Estacionamento (Desafio)

Este projeto é parte de um **desafio proposto pelo meu professor** de programação com C#. O objetivo era criar um sistema simples de controle de entrada e saída de veículos em um estacionamento, usando **Windows Forms**, **biblioteca de classes** e **banco de dados**.

## 🎯 Funcionalidades do Desafio

- Registrar entrada de veículos (placa, modelo, hora atual).
- Registrar saída de veículos com cálculo de tempo e valor.
- Calcular valor a pagar (R$5,00 por hora, mínimo de 1h).
- Emitir recibo simples.
- Listar veículos atualmente estacionados.
- Exibir histórico de movimentações.

## ✅ Funcionalidades Implementadas

- Registro de entrada e saída de veículos.
- Cálculo automático do valor a pagar.
- Emissão de recibo.
- Listagem e histórico de veículos.

## 🧪 Extras (Ideia)

- Adicionei um teste de **sistema de vagas visuais** (com botões interativos), mas foi **apenas por diversão** e **não faz parte da atividade original**. Ainda não está finalizado nem funcional como o restante.

## 🗃️ Banco de Dados

Tabela: `movimentacoes`

```sql
CREATE TABLE movimentacoes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    placa VARCHAR(10),
    modelo VARCHAR(50),
    hora_entrada DATETIME,
    hora_saida DATETIME,
    valor_pago DECIMAL(10,2)
);
