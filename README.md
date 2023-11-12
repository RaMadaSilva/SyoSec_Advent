# SyosecAdvent

## Introdução
28/08/2023
O SyoSec é um sistema de Organização da secretaria das Igrejas Adventistas do sétimo Dia, em particular para  a Mabor;
Este sistema visa Organizar todas recomendações Recebidas e Enviadas,  actas elaboradas ao longo do ano Eclesiástico, e controle dos prazos das disciplinas por sencura.

## Modulos

1. Recomendações
2.  Actas
3.  Disciplinas

## Funcionalidades
### Módulo 1: Recomendações

### Registar a Recomendação

O registo da Recommendação deve ser realizado por um utilizador com perfil de Secretario ou vice Secretario
   - Dados da Recomendação: 
     - Nome do membro
     - Telefone
     - Morada do Membro
     - Nome da Igreja 
     - Morada da igreja
     - Tipo de Recomendação (solicitado ou Recebido) 
     - Observação (opcional)
     - Url da Recommendação anexa(opcional)

### Devolução da Recomendação

   - Para devolução, registrar:
     - Data
     - Anexar a carta devolvida(opcional)
     
### Desejo de Transferencia

- Quando um membro com recomendação(solicitada ou recebida) manifestar o desejo de Transferencia 
     - Desejo de Transferencia
     - Data
       
### Restrições e Funcionalidades Adicionais

- Não aceitar cartas de recomendação com data de criação de 6 meses atrás.
- Exibir o número de dias restantes para a carta expirar.
- Estados das cartas de recomendação: Valida, Inválida, Devolvida, Transferência.
- Anexar cartas correspondentes às recomendações recebidas.
- Um membro pode solicitar várias recomendações.
- Um membro pode ter apenas uma recomendação Valida no maximo.
- Manter histórico de ações realizadas em relação a cada carta de recomendação.
- O membro pode manifestar o desejo de transferência.
- Gerar PDF da carta de recomendação no momento da solicitação.
- Evitar Membros duplicados com os mesmo: nome, morada e telefone.
- Acompanhantes podem ser adicionados à observação.

### Módulo 2: Actas

- Detalhes a serem registados
  - Numero da Acta
  - Numero de Membros presente
  - Presidente da mesa
  - Secretario da mesa
  - Data da Realização da Acta
  - URL da Acta(Ficheiro Digitado)Localização
- Deve ser Obrigatório inserir A acta Digitalizada;
- Deve ser possível visualizar a acta sempre que necessário
- deve ser possível fazer filtros separados ou filtro por intervalo de data.

### Módulo 3: Disciplinas

- A disciplina é efetuado sobre um membro , mas o nosso sistema não irá tratar de algumas validações de membro, como um cadastro especifico de membro, pois já existe um sistema faz o controle de membro. O iremos fazer aqui é ter uma entidade disciplina que terá um Value Object Membro devido algumas validações necessárias
- Detalhe da disciplina
  - Numero da Acta
  - Data da acta
  - Data do Voto
  - Numero do Voto
  - Motivo da Disciplina
  - Membro Disciplinado
  - Prazo da Duração em meses
  - Quantidade de Dias para o Termino da Disciplina
- O sistema deve apresentar sempre de forma dinâmica o numero de dias que faltam para que a Disciplina Termine.
- Quando o numero de dias for Atinge em zero, começa a contar o numero de dias passado deste o termino da disciplina. e apresenta com uma coloração diferente.

## Tecnologias

- C#
- Asp.Net core 7.0
- Entity Framework core 7.0
- Sql Server
- WebApi
- CQRS
- Clean Architecture
- Flunt
- SOLID
- Mapster
- Teste de Unidade (xUnit)
- Git e GitHub.

## Diagrama de Classes e de caso de uso

### Modulo 1: Recommendações
-
### Modulo 2: Actas
-
### Modulo 3: Disciplinas

 * 

## Idioma para Desenvolvimento

* Inglês
