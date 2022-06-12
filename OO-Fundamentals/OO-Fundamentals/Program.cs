using OO_Fundamentals.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OO_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach(var article in articles)
            {
                Console.WriteLine($"id: {article.Id}");
                Console.WriteLine($"Title: {article.Title}");
                Console.WriteLine($"Url: {article.Url}");
                Console.WriteLine("------------------------");
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);


            var careers = new List<Career>();   
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Learn OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Start here", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Learn .NET", "", courseAspNet);

            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }

            Thread.Sleep(5000);
        }
    }
}
