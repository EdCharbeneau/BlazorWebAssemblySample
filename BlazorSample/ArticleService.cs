using BlazorSample.Client;
using System;

namespace BlazorWasmSample
{
    public class ArticleService : IArticleService
    {
        string[] articleTitles = {
    "Mastering Asynchronous Programming in .NET",
    "Exploring the Power of LINQ in C#",
    "Building Scalable Web Applications with ASP.NET Core",
    "Deep Dive into Entity Framework: Tips and Tricks",
    "Understanding Dependency Injection in .NET",
    "Securing Your .NET Applications: Best Practices",
    "Exploring the New Features in C# 10",
    "Debugging Techniques for .NET Developers",
    "Cross-Platform Development with Xamarin.Forms",
    "Performance Optimization in .NET: A Comprehensive Guide",
    "Building RESTful APIs with ASP.NET Core",
    "Getting Started with Blazor: A WebAssembly Framework",
    "Exploring Design Patterns in .NET",
    "Containerizing .NET Applications with Docker",
    "Working with SignalR for Real-Time Communication",
    "Mastering Unit Testing in .NET",
    "Integrating Machine Learning with .NET Applications",
    "Exploring Microservices Architecture in ASP.NET Core",
    "Building a Cloud-Native .NET Application with Azure",
    "Continuous Integration and Deployment in .NET"
        };

        public Task<string[]> GetArticleTitles(int count) => Task.FromResult(
            Enumerable.Range(1, count)
            .Select(index => articleTitles[Random.Shared.Next(articleTitles.Length)])
            .ToArray()
            );
    }
}
