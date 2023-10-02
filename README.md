# SyoSec_Advent

28/08/2023
O SyoSec é um sistema de Organização da secretaria para as Igrejas Adventistas do sétimo Dia, Nomeadamente a Mabor;
Este sistema visa Organizar todas recomendações Recebidas e Enviadas, bem como das actas elaboradas ao longo do ano Eclesiástico, e dos prazos de controle dos prazos das disciplinas por sencura.
Módulos: 1. Recomendações 2. Actas 3. Disciplinas

Módulo 1: Recomendações

Tipos de Cartas de Recomendações

1. Recomendações Solicitadas:
   - Registrar solicitação e devolução.
   - Detalhes a serem registrados na solicitação:
     - Nome do membro
     - Telefone
     - Morada do Membro
     - Igreja a ser visitada
     - Morada da igreja
     - Data da solicitação
     - Observação (opcional)
   - Para devolução, registrar:
     - Data do regresso
     - Anexar a carta devolvida
   - O membro pode manifestar o desejo de transferência.
   - Gerar PDF da carta de recomendação no momento da solicitação.
2. Recomendações Recebidas:
   - Detalhes a serem registrados na recepção:
     - Nome do membro
     - Telefone
     - Morada atual do Membro
     - Data da recomendação
     - Data da recepção
     - Igreja de origem
     - Morada da igreja de origem
     - Observação(Optional)
   - Recepção do membro e registado o regresso à procedência.
   - Para regresso, informar a data de regresso.
   - Para solicitação de transferência, informar:
     - Número e data da ata
     - Número do voto
   - Membros não podem ter informações duplicadas (nome, morada, telefone).
   - Acompanhantes podem ser adicionados à observação.

Restrições e Funcionalidades Adicionais

- Não aceitar cartas de recomendação com data superior a 6 meses.
- Exibir o número de dias restantes até que as cartas expirem.
- Estados das cartas de recomendação: Valida, Inválida, Devolvida, Transferência.
- Anexar cartas correspondentes às recomendações recebidas.
- As cartas de recomendação devem ser únicas por membro.
- Um membro pode solicitar várias recomendações.
- Um membro pode ter apenas uma recomendação em andamento.
- Manter histórico de ações realizadas em relação a cada carta de recomendação.

Módulo 2: Actas

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

Módulo 3: Disciplinas

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

Tecnologias A ser Usada

- C#
- Asp.Net core 7.0
- Entity Framework core 7.0
- Sql Server para produção e SqLite para desenvolvimento
- Razor page
- CQRS
- Clean Architecture
- SOLID
- DRY
- Mapster
- Teste de Unidade (MStest)
- Git e GitHub.

Diagrama de Classes

- Modulo 1: Recommendações
-
- Modulo 2: Actas
-
- Modulo 3: Disciplinas
  Diagrama de caso de uso

Idioma para o Desenvolvimento: Inglês
