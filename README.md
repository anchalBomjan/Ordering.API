# Ordering.API




Create solution and projects.

Create a solution name Ecommerce
Add a new web api project, name - Ordering.API in the solution.
Add 3 class library project, name - Ordering.Application, Odering.Core and Ordering.Infrastructure in the solution.
Step 2: Install nuget packages.

Install following nuget packages in Ordering.Infrastructure Project
PM> Install-Package Dapper
PM> Install-Package Microsoft.Data.Sqlite.Core
PM> Install-Package Microsoft.EntityFrameworkCore
PM> Install-Package Microsoft.EntityFrameworkCore.Design
PM> Install-Package Microsoft.EntityFrameworkCore.Relational
PM> Install-Package Microsoft.EntityFrameworkCore.Tools
PM> Install-Package Microsoft.Extensions.Configuration.Abstractions
PM> Install-Package Microsoft.AspNetCore.Identity
PM> Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite

Install following nuget packages in Ordering.Application Project
PM> Install-Package AutoMapper
PM> Install-Package MediatR
PM> Install-Package FluentValidation
PM> Install-Package FluentValidation.DependencyInjectionExtensions
PM> Install-Package Microsoft.Extensions.DependencyInjection.Abstractions
PM> Install-Package Microsoft.Extensions.Identity.Core
PM> Install-Package Microsoft.IdentityModel.Tokens
PM> Install-Package System.IdentityModel.Tokens.Jwt
Install following nuget packages in Ordering.API Project
PM> Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
PM> Install-Package MediatR
PM> Install-Package MediatR.Extensions.Microsoft.DependencyInjection
PM> Install-Package Microsoft.EntityFrameworkCore.Design
PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite
PM> Install-Package Microsoft.EntityFrameworkCore.Tools
PM> Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
PM> Install-Package System.Configuration.ConfigurationManager
Step 3: Create Entity class in Ordering.Core project
