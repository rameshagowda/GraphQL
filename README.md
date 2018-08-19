# GraphQL
Query AspNetCore Api using GraphQL - DotNet Core (C#) Api development using GraphQL package

Using too many REST Api endpoints get complicated when we try to retrive data which is nested,
hierarchical and relational (parent-child). This problem can be overcome by introducing GraphQL to Api development.

#1. GraphQL is a query language for APIs - GraphQL solves the roundtrip problem by allowing the client to create 
a single query which calls several related functions on the server to construct a response with 
multiple resources - in a single request.

#2. GraphQL is about asking for specific fields on objects. This core principle solves both the over- and 
underfetching problem by giving the client complete control over the data it receives.

Screenshot of the postman Api call available here: ..\wwwroot\Postman_example.JPG

Important concepts:
1. Querying / Filtering fields from multiple sources - databases, services and Redis cache. 
2. Updates through Mutations. 
3. Push notifications to subscribed clients (push model).
