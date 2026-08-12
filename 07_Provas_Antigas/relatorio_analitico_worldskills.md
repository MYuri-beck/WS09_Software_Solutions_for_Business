# Relatório Analítico Detalhado: Evolução e Projeção das Provas de Software Applications Development (Skill 09) - WorldSkills

Este relatório apresenta uma análise crítica, histórica e comparativa das provas (Test Projects) da ocupação de **Software Applications Development** (anteriormente denominada **IT Software Solutions for Business**) [6, 71, 74]. A análise cruza dados estruturais, metodológicos e tecnológicos de três edições principais: **Kazan 2019**, **Special Edition 2022 (Seoul)** e **Lyon 2024**, projetando o cenário competitivo para a **WorldSkills 2026 (Shanghai)** com base nos novos padrões do Technical Description [71, 74].

---

## 1. Escopo e Desmembramento das Provas

Cada edição analisada possui uma temática de negócio centralizada (estudo de caso), simulando cenários corporativos reais onde o competidor atua como o engenheiro de software responsável por idealizar, modelar, codificar, integrar e analisar o ecossistema digital [92, 93].

### A. WorldSkills Kazan 2019 (Estudo de Caso: Kazan Neft)
O problema proposto girava em torno da **Kazan Neft**, uma petroleira russa em forte expansão internacional que apresentava uma necessidade urgente de catalogação, controle de inventário, manutenção preventiva e gerenciamento de ativos corporativos (Enterprise Asset Management - EAM) [6, 8].

*   **Sessão 1 (Mobile - Android Native):** Entrega de um aplicativo móvel voltado para os técnicos em campo realizarem a catalogação inicial de ativos [6, 7]. O app deveria funcionar conectado a uma base de dados remota via rede [7].
*   **Sessão 2 (Desktop & Modelagem de Dados):** Criação física do banco de dados relacional ("Session2") em MySQL ou Microsoft SQL Server [9]. Desenvolvimento da interface desktop padrão para controle básico de manutenção corporativa [8].
*   **Sessão 3 (Mobile - Android Native):** Desenvolvimento de interface para gerenciamento em campo de rotinas de manutenção preventiva (inspeções, lubrificação, calibração e ajustes) [10, 11].
*   **Sessão 4 (Desktop & Inventário):** Continuação do desenvolvimento da aplicação desktop ("Session4") [12, 13]. Integração das rotinas de requisição de peças, pedidos de compra e gerenciamento do estoque [5].
*   **Sessão 5 (Mobile - Modo Offline & Sincronização):** Desenvolvimento de algoritmo para lidar com perdas de conexão (offline logging) em perfurações isoladas de poços de petróleo [5, 14, 15]. O app deveria atualizar um banco local e sincronizá-lo bidirecionalmente com a base central quando a conectividade fosse restabelecida [5, 15].
*   **Sessão 6 (Desktop Dashboard & Internacionalização):** Criação de um dashboard gerencial desktop para os administradores, com visualização de KPIs de manutenção, e implementação de internacionalização dinámica de idioma através da leitura de arquivos estruturados XML (`Default.xml`) [16].
*   **Sessão 7 (Engenharia Reversa & Modificação):** Sessão disruptiva onde o competidor recebia um software legado compilado (`Session7.exe`), um vídeo explicativo de novos requisitos e um arquivo de especificações (`New_Features.pdf`) [17]. A entrega consistia em aplicar modificações/correções e novas funcionalidades diretamente no pacote existente [17].

### B. WorldSkills Special Edition 2022 - Seoul (Estudo de Caso: Seoul Stay)
A temática de 2022 foi a plataforma **Seoul Stay**, o único marketplace que permite a viajantes internacionais alugar residências, condomínios ou propriedades em Seul [27, 29, 31, 54]. O ecossistema envolvia múltiplos atores e plataformas operando em tempo real (viajantes, anfitriões e administradores) [36, 40].

*   **Sessão 1 (Desktop - Call Center):** Aplicação para o setor de atendimento telefônico de call center, permitindo gerenciar usuários, cadastros e resolver pendências básicas [27, 28].
*   **Sessão 2 (Mobile - Android Native):** Aplicativo móvel para proprietários de imóveis gerenciarem seus anúncios, disponibilidades, tarifas dinámicas e datas de reserva [29, 30].
*   **Sessão 3 (Web & Web API):** Primeira sessão puramente web. Construção de uma interface responsiva (testada no Chrome) para busca e reserva de imóveis por período [31, 33, 34]. Exigia a integração com uma Web API centralizada fornecida pela organização e com uma Payment API externa simulada [32, 34].
*   **Sessão 4 (Desktop - Busca Avançada e Autocomplete):** Interface de busca avançada para operadores de call center [36]. Exigia a criação de um componente de busca inteligente dinâmica com autossugestão (live autocomplete) disparado a partir de 3 caracteres digitados [39].
*   **Sessão 5 (Mobile & Sintaxe Customizada):** Aplicativo móvel para os viajantes reservarem serviços adicionais (addons) [40, 42]. O principal desafio era importar arquivos Excel de dados dinâmicos (`Session5-Data.xls`) e interpretar regras de sintaxe altamente específicas definidas pelo negócio através do manual `Syntax.pdf` (Seoul Custom Syntax) [41].
*   **Sessão 6 (Desktop Dashboard - Monitoramento):** Dashboard executivo desktop para gerentes regionais visualizarem tempos médios de resposta de reservas, taxas de ocupação, faturamento de taxas e tendências de satisfação [43].
*   **Sessão 7 (Design de Sistemas, UML & Apresentação Oral):** Avaliação de habilidades conceituais de engenharia de software [46]. O competidor deveria criar diagramas de sequência detalhados (UML / SSD) para interações complexas do sistema [48], desenhar wireframes de alta fidelidade para as telas web (usando MS Visio ou ferramentas similares) [50, 51] e realizar uma apresentação presencial (pitch de negócios) de exatos 5 minutos para uma banca de avaliadores [51].

### C. WorldSkills Lyon 2024 (Estudo de Caso: Belle Croissant Lyonnais)
O problema de 2024 envolveu a modernização e transformação digital da **Belle Croissant Lyonnais**, uma tradicional confeitaria e padaria francesa de Lyon com imenso volume histórico de dados operacionais que necessitava de digitalização completa [59, 60].

*   **Sessão 1 (Data Analysis & Analytics):** Sessão inicial puramente de análise de dados. Usando ferramentas analíticas da estação (como Python/Pandas ou Excel), o competidor analisou o histórico de vendas, produtos e comportamento do consumidor para gerar insights estatísticos preditivos [59].
*   **Sessão 2 (Arquitetura e Design de Software):** Elaboração de especificações técnicas, diagramas de arquitetura, diagramação de banco de dados (DER), mapa de endpoints e design de telas (mockups) para orientar o desenvolvimento de todo o ecossistema [60].
*   **Sessão 3 (REST API Backend & Desktop Staff App):** O competidor assumiu o papel de desenvolvedor full-stack, construindo simultaneamente uma RESTful Web API segura do lado do servidor e um cliente desktop em C# para o staff da padaria gerenciar pedidos de produção [61, 62].
*   **Sessão 4 (Customer Mobile App & API Integration):** Criação de um app mobile nativo ou híbrido para clientes realizarem pedidos online [63, 64]. O app devia integrar-se de forma assíncrona com os endpoints da API desenvolvida na Sessão 3 [63, 64], gerando também um inventário formalizado em `Session4_UserAPI_Endpoints.txt` [65].
*   **Sessão 5 (Desktop App Enhancements):** Expansão do sistema desktop adicionando controle de promoções dinâmicas, regras de fidelidade de clientes e monitoramento refinado de estoque de ingredientes com receitas estruturadas [66].
*   **Sessão 6 (Mobile App Enhancements):** Evolução do app mobile para habilitar pedidos personalizados (custom orders), onde o cliente escolhe ingredientes específicos e gera fluxos de cálculo complexos de precificação dinâmicamente integrados à API [67].
*   **Sessão 7 (Business Intelligence & Dashboards):** Integração e saneamento de bases de dados heterogêneas utilizando o Power BI [68]. Envolveu extração de dados, ETL, modelagem dimensional e a entrega de um dashboard interativo completo com slicers, drill-downs e relatórios gerenciais estruturados [68].

---

## 2. Mapeamento Tecnológico (Geral e por Sessão)

A infraestrutura oficial detalhada no Technical Description (WSOS) delimita formalmente as ferramentas homologadas de desenvolvimento [71, 95]. Abaixo é detalhado o mapeamento comparativo da stack utilizada em cada edição:

| Tecnologia / Ferramenta | Kazan 2019 [6] | Seoul 2022SE [27] | Lyon 2024 [59] | Projeção Shanghai 2026 [71, 95] |
| :--- | :--- | :--- | :--- | :--- |
| **Sistemas Gerenciadores de Banco de Dados (SGBD)** | MySQL / MS SQL Server [6, 9] | MySQL / MS SQL Server [28, 32] | MS SQL Server / MariaDB | MS SQL Server / MariaDB / PostgreSQL [95] |
| **Desenvolvimento Desktop** | C# (.NET Framework / WPF ou WinForms) | C# (.NET Framework ou .NET Core / WPF) | C# (.NET 8 / WPF ou WinForms) | C# (.NET 8/9 / WPF ou cross-platform WinUI/MAUI) [95, 117] |
| **Desenvolvimento Web** | Não aplicável | HTML5 / CSS3 / Vanilla JS ou Angular/React/Vue [34] | Não aplicável (foco em REST API) | React / Angular / Vue / Blazor WebAssembly [95, 117] |
| **Desenvolvimento Mobile** | Android Native (Java/Kotlin) [7] | Android Native (Java/Kotlin) [24, 42] | Android Native ou Flutter/React Native [63] | Flutter / React Native / Android Native (Kotlin) / .NET MAUI [82, 95, 120] |
| **Desenvolvimento de API** | Não aplicável | Web API (ASP.NET Core ou Java) [34] | RESTful Web API (ASP.NET Core) [61, 62] | RESTful Web API (ASP.NET Core / Node.js) [95, 117] |
| **Análise de Dados e BI** | Não aplicável | Não aplicável | Python (Pandas) / Power BI [59, 68] | Python (Pandas/NumPy) / Power BI / Tableau [95, 120] |
| **Design de Arquitetura e UML** | StarUML / Papyrus | MS Visio / Draw.io [51] | MS Visio / Draw.io / Figma | MS Visio / Draw.io / Figma / Enterprise Architect [95] |

### Distribuição Tecnológica Específica por Sessão

A tabela matricial a seguir especifica qual tecnologia e paradigma foram exigidos em cada bloco das competições:

| Edição | Sessões de Modelagem e Design | Sessões de Desenvolvimento Desktop | Sessões de Desenvolvimento Web / API | Sessões de Desenvolvimento Mobile | Sessões Analíticas e de BI |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Kazan 2019** | Modelagem de Banco Relacional (S2, S4) [9, 13] | C# (WPF/WinForms) + CRUD direto (S2, S4, S6) [9, 12, 16] | Não exigido | Android Native (Java/Kotlin) com conexões remotas SQL diretas (S1, S3, S5) [7, 11, 15] | Não exigido (Rotinas de relatório básicas geradas em desktop) [5] |
| **Seoul 2022SE** | UML (SSD) e Prototipagem de Telas com MS Visio (S7) [48, 50, 51] | C# (WPF) + Integração de UI avanzada com Live Autocomplete (S1, S4, S6) [27, 36, 43] | Web SPA (HTML5/JS) conectando a Web API + Integração de Gateway de Pagamento (S3) [31, 32, 34] | Android Native (Java/Kotlin) com Parser customizado e importação XLS (S2, S5) [29, 41] | Relatórios gerenciais baseados em visualizações gráficas desktop nativas (S6) [43] |
| **Lyon 2024** | Modelagem C4, DER, mockups Figma e mapeamento de endpoints (S2) [60] | C# (WPF/.NET Core) conectando à REST API desenvolvida pelo competidor (S3, S5) [61, 66] | Back-end RESTful Web API completo utilizando ASP.NET Core (.NET 8) (S3) [61, 62] | Android Native ou Flutter/React Native integrado de forma assíncrona com REST API (S4, S6) [63, 67] | Análise Exploratória de Dados em Python (S1) e Dashboards Analíticos ETL com Power BI (S7) [59, 68] |

---

## 3. Análise Comparativa (O que mudou?)

Uma análise cronológica detalhada revela profundas transições na metodologia de prova e nos padrões arquiteturais exigidos pela indústria.

### A. Transição Arquitetural: Do Monolito de Acesso Direto para Microsserviços e APIs REST
*   **Em 2019 (Kazan):** O paradigma era essencialmente o de duas camadas (Client-Server tradicional) [7, 15]. As aplicações mobile e desktop conectavam-se **diretamente** ao banco de dados relacional (MySQL/SQL Server), muitas vezes expondo credenciais diretamente nas strings de conexão no código cliente [7, 15].
*   **Em 2022SE (Seul):** Introduziu-se o conceito de camada intermediária, exigindo o uso de uma **Web API central** para processar requisições [34]. Contudo, isso foi focado principalmente na sessão Web (Sessão 3) [31, 34], enquanto as demais sessões desktop e móvel ainda utilizavam lógicas híbridas de acesso a banco [29, 36, 43].
*   **Em 2024 (Lyon):** Consolidou-se a **arquitetura moderna de desacoplamento completo**. O backend (Sessão 3) tornou-se o coração do ecossistema [61, 62]. Toda a comunicação dos aplicativos móveis dos clientes (Sessão 4, 6) [63, 67] e sistemas desktop do staff (Sessão 5) [66] passou obrigatoriamente pelas rotas da REST API desenvolvida pelo competidor, refletindo as melhores práticas de microsserviços e APIs desacopladas do mercado corporativo internacional.

### B. Transição de Plataforma Móvel: Da Rigidez Nativa para a Flexibilidade Multiplataforma (Cross-Platform)
Anteriormente, em Kazan 2019, o desenvolvimento móvel exigia estritamente programação nativa (Java/Kotlin no Android Studio) [7]. Em Lyon 2024 e na especificação atual para 2026, embora o desenvolvimento nativo continue homologado, ferramentas multiplataforma como **Flutter** e **React Native** foram ativamente adotadas [82, 120]. Essa flexibilidade transfere o peso da avaliação da proficiência em APIs de sistemas operacionais específicos para a capacidade de entrega de aplicativos responsivos, rápidos e multiplataforma de forma altamente ágil [82].

### C. A Reinvenção da "Sessão 7" e a Ascensão do Data Analytics / BI
A Sessão 7, historicamente reservada para encerramento de escopo, mudou de foco radicalmente:
1.  **Em 2019:** Foco em engenharia reversa de um executivo legado (`Session7.exe`) e correção/manutenção de código antigo [17].
2.  **Em 2022SE:** Foco em design de arquitetura de alto nível (UML) [48], wireframes de interfaces web [50] e uma apresentação oral (soft skills de comunicação) de 5 minutos [51].
3.  **Em 2024:** Foco absoluto em **Business Intelligence corporativo** utilizando o Microsoft Power BI (ETL de bancos desnormalizados, mapeamento de dados multidimensionais e design de gráficos) [68].
4.  **Em 2026:** Consolidação do peso analítico. O relatório, modelagem dimensional e a exploração de dados estatísticos são tratados como fundamentais na pontuação geral [117, 120].

---

## 4. Curva de Dificuldade e Evolução

A complexidade das provas aumentou de maneira exponencial, não apenas no volume bruto de trabalho exigido nas 21 horas regulamentares de competição [55, 91], mas também no nível de sofisticação dos critérios de avaliação adotados pela WorldSkills Standards Specification (WSOS) [72, 77, 85].

```
  Dificuldade
     ▲
     │                                                      [WorldSkills 2026 Shanghai]
     │                                                      • Arquitetura Cloud-Native
     │                                                      • Autenticação JWT/OAuth2
     │                                                      • Testes Unitários/Integrados
     │                                                      • CI/CD & DevOps de Alto Nível [117, 120]
     │                                                      
     │                                [WorldSkills 2024]
     │                                • Arquitetura REST API puramente desacoplada
     │                                • Análise exploratória inicial (Python) [59]
     │                                • Business Intelligence e ETL (Power BI) [68]
     │                                • Customização complexa de produtos móveis [67]
     │
     │                  [WorldSkills 2022SE]
     │                  • Arquitetura Híbrida (Web API + Desktop) [34]
     │                  • Conectividade IIS/Tomcat [23]
     │                  • Custom Parsers de arquivo [41]
     │                  • Wireframing & Pitch de 5 min [51]
     │
     │    [WorldSkills 2019]
     │    • DB Relacional Local [9]
     │    • Sincronização offline básica [5, 15]
     │    • Manutenção de código legado [17]
     │    • Layouts desktop nativos CRUD [9, 12]
     └─────────────────────────────────────────────────────────────────────────────► Cronologia / Edições
```

### Análise dos Fatores Dinâmicos da Curva de Dificuldade:

1.  **Volume e Carga de Trabalho contra o Tempo:**
    *   **Kazan 2019:** O tempo de 3 horas por sessão era utilizado principalmente para desenhar telas CRUD [91, 92]. Se o competidor dominasse binds de dados básicos e consultas SQL [5], conseguia entregar telas completas [3].
    *   **Seoul 2022SE:** Exigiu-se a configuração física de redes virtuais completas (VLANs, conexões IP manuais, servidores IIS locais e Apache Tomcat de suporte no ambiente virtualizado do competidor) [19, 23, 25, 56]. A carga de trabalho expandiu significativamente para além da codificação básica.
    *   **Lyon 2024:** O volume exigido tornou-se monumental. Em apenas duas sessões de 3 horas (Sessão 3 e 4), o competidor precisava projetar e codificar do zero: banco de dados robusto, uma REST Web API corporativa com controle de rotas assíncronas [61, 62, 65], um sistema desktop totalmente operacional e um aplicativo mobile integrado [61, 63]. A tolerância a lentidões ou falta de planejamento arquitetural tornou-se nula.

2.  **Profundidade das Regras de Negócio Algorítmicas:**
    *   Em 2019, o maior desafio algorítmico era a rotina de sincronização offline de dados (comparações de timestamps e controle de concorrência) [5, 15].
    *   Em 2022SE, elevou-se a complexidade com a implementação de interpretadores de texto baseados em regras exclusivas desenhadas em documento PDF (`Syntax.pdf` - Seoul Custom Syntax), forçando o competidor a codificar uma árvore sintática de análise (AST) no aplicativo Android em poucas horas [41, 42].
    *   Em 2024, as regras evoluíram para o gerenciamento de inventário proporcional de ingredientes com base em receitas escaláveis de confeitaria [66] e o cálculo dinâmico e aninhado de modificações personalizadas em pedidos mobile [67], exigindo domínio absoluto de estruturas de dados e otimização de queries complexas.

3.  **Refinamento dos Critérios de Avaliação (WSSS / WSOS):**
    *   A avaliação evoluiu de "Medição Simples de Funcionamento" (funciona/não funciona) para auditorias de segurança [61], qualidade de arquitetura (modularidade de código) [81], tratamento estrito de exceções [30, 33], desempenho assíncrono e conformidade cirúrgica com o estilo visual (Style Guide) [18, 30, 33, 47]. Códigos sem estruturação de padrões de projeto (como MVC/MVVM) ou com vulnerabilidades críticas de segurança perdem pontuação massiva nos critérios de Julgamento dos Experts [84, 85, 116].

---

## 5. Previsão para a WorldSkills 2026 (Projeção Baseada em Dados)

Analisando sistematicamente a evolução histórica e o alinhamento com a indústria estipulado no novo Technical Description de 2026 [71, 74, 122], é possível consolidar previsões de alta confiabilidade para a próxima edição em Xangai.

### A. Curva de Dificuldade Esperada: O que se tornará ainda mais complexo?
*   **Integração e Segurança:** A segurança das APIs deixará de ser um item secundário de avaliação. Autenticação robusta utilizando tokens temporários assinados (**OAuth 2.0 / JWT**) e o bloqueio de requisições via middlewares de segurança (prevenindo SQL Injection e ataques de escalabilidade de privilégio de dados) serão avaliados sistematicamente [117].
*   **Testabilidade Automatizada (DevOps e QA):** Espera-se uma cobrança direta e automatizada de testes na API [117]. A capacidade de escrever **Testes Unitários** (com xUnit / NUnit) e testes de integração automatizados em tempo recorde será um dos principais divisores de águas entre medalhistas [117, 120].
*   **Arquitetura Cloud-Native e Containers:** Com a consolidação de VMs Linux e Docker no ambiente preparatório, os competidores precisarão dominar a implantação conteinerizada de suas soluções (Dockerfiles, Docker Compose) e orquestração leve local para garantir o funcionamento imediato do ecossistema [98, 100].

### B. Tecnologias Previstas com Alta Probabilidade de Aparição
Com base nas atualizações da infraestrutura (IL) e nos frameworks modernos recomendados pelo comitê técnico [95, 96, 120]:

1.  **Back-End Core:** ASP.NET Core (.NET 8/9) de alta performance com uso avançado de Entity Framework Core (EF Core) para mapeamento relacional ágil e seguro.
2.  **Linguagens Dominantes:** C# como linguagem estrutural do ecossistema backend e administrativo [95, 117], acompanhado por JavaScript/TypeScript para soluções web/mobile.
3.  **Mobile Multiplataforma:** **Flutter (Dart)** ou **React Native (JS/TS)** como padrão de mercado amplamente preferido, eliminando a dependência de emuladores pesados através de implantação em tablets reais via Wi-Fi [25, 82, 120].
4.  **Front-End Web:** React ou Blazor WebAssembly, permitindo a construção rápida de sistemas administrativos interativos integrados nativamente com as APIs em C#.
5.  **Analytics & Analytics Engines:** Python associado a bibliotecas Pandas, NumPy e Scikit-Learn para modelagens preditivas complexas na Sessão 1 [59, 120].
6.  **SGBD:** PostgreSQL ou MariaDB como repositórios escaláveis altamente robustos [95, 117].

### C. Estrutura de Prova Projetada para 2026 (Módulos e Sessões)

Com base no limite regulamentar de **7 sessões com 2.5 a 3 horas de duração cada** [91], propomos o seguinte desmembramento provável de prova para 2026:

*   **Sessão 1 (Data Analytics & Insights de Negócio):** Análise exploratória inicial de um grande volume histórico de dados, modelagem preditiva utilizando scripts em Python e criação de um sumário de insights gerenciais focado na tomada de decisões estratégicas [59, 118].
*   **Sessão 2 (Análise de Sistemas, Modelagem & Planejamento):** Elaboração de especificações arquiteturais sob metodologia de microserviços. Criação de diagramas UML detalhados (Classe, Sequência e Caso de Uso) [81, 116], desenho dimensional de dados e prototipagem rápida de telas gerenciais [81].
*   **Sessão 3 (Backend API Development):** Desenvolvimento rápido e robusto de uma RESTful Web API altamente segura, implementando autenticação JWT, tratamento global de exceções e persistência de dados ágil [61, 62, 117].
*   **Sessão 4 (Multi-platform Customer Application):** Desenvolvimento de um aplicativo móvel cross-platform para o cliente final consumir os serviços da API (browsing, agendamento, compras assíncronas e notificações de status em tempo real) [63, 64, 82].
*   **Sessão 5 (Administrative Web Application):** Desenvolvimento de uma aplicação web reativa para administração e operações da empresa, integrada à REST API (controle de fluxo de trabalho, controle de pedidos e permissões administrativas de usuários) [31, 34, 82].
*   **Sessão 6 (Automated Testing & Security Hardening):** Desenvolvimento de suite de testes unitários para a lógica crítica de negócios da REST API [117], acompanhado pela implementação de middlewares de proteção e auditoria de vulnerabilidades de segurança das rotas (DevOps e QA integrados) [81, 117, 120].
*   **Sessão 7 (Business Intelligence & Executive Dashboards):** Extração, consolidação de bases de dados históricas e transacionais através de rotinas ETL sofisticadas, culminando na entrega de dashboards dinâmicos analíticos utilizando Power BI para monitoramento gerencial do ecossistema [68, 120].

---

## Conclusão e Recomendações para Treinamento

A ocupação de **Software Applications Development** atingiu um patamar de maturidade técnica extrema [71, 74]. Para alcançar a excelência e competir por medalhas na WorldSkills 2026, os treinamentos devem focar na **velocidade de entrega através de padrões de arquitetura e boilerplate de código sólidos e pré-testados**. 

O competidor não deve gastar tempo decidindo como estruturar a API ou como autenticar as rotas; essas rotinas devem estar internalizadas e prontas para uso imediato em um "esqueleto" arquitetural robusto e em conformidade estrita com o Technical Description [81, 82, 117]. O foco em **Data Analytics (Python)** e **Business Intelligence (Power BI)** deve ser elevado ao mesmo nível de importância do desenvolvimento de software tradicional, assegurando a pontuação máxima nas sessões analíticas que hoje definem os campeões mundiais [59, 68, 120].
