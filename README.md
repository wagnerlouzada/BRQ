# Projeto para classificação de risco

Projeto foi criado em ASP.NET MVC, utilizando .Net Framework, DDD, EF (apenas para poder persistir as regras em momento oportuno), IoC e AutoMapper

# Execução

Para compilar e rodar o app poderá ser necessário a instalação do ef, para tanto no Console do Gerenciador de Pacotes execute

PM> Install-Package EntityFramework

# Descritivo

Este é um projeto que tem foco no IoC, e que pretende demonstrar como "Regras de Classificação" com base em 2 valores podem ser utilizadas de forma dinâmica, utilizando algumas tecnologias e padrões de projetos:
- ASP.NET MVC para front end
- .Net Framework - para o core do app (poderia ser adotado também o net.core)
- DDD (Domain Drive Design) - Como pattern para desacoplamento)
- IoC (Simple Injector)
- Fluent API
- Linq/Lambda para filtragens
- EF para manter as regras - utilizando SQLServer.

# Observação

Para diminuir o tempo necessário foi utilizado um modelo de aplicação previamente preparado, como base da estrutura e alguns outros itens acessórios.
