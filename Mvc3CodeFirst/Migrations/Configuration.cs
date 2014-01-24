namespace Mvc3CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Mvc3CodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc3CodeFirst.Models.SampleDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc3CodeFirst.Models.SampleDataContext context)
        {
            AddStudents(context);
            AddActivities(context);
        }

        public static void AddStudents(Mvc3CodeFirst.Models.SampleDataContext context)
        {
            context.Students.AddOrUpdate(p => p.Name,
               new Student
               {
                   Name = "Debra Garcia",
                   Seniority = "Graduate Student",
                   Affiliation = "University of Washington",
                   City = "Redmond",
                   State = "WA",
                   Zip = "10999",
                   Email = "debra@example.com",
               },
                new Student
                {
                    Name = "Joel Smith",
                    Seniority = "Sophomore CS Major",
                    Affiliation = "Washington State University",
                    City = "Washington",
                    State = "DC",
                    Zip = "20002",
                    Email = "joesmith@sample.com",
                },
                new Student
                {
                    Name = "Fred Catz",
                    Seniority = "Sophomore CS Major",
                    Affiliation = "University of Washington",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "fredcatz@sample.com",
                },
                new Student
                {
                    Name = "Cindy Miller",
                    Seniority = "CS Graduate Student",
                    Affiliation = "Washington State University",
                    City = "Rockville",
                    State = "MD",
                    Zip = "20850",
                    Email = "cindymiller@sample.com",
                },
                new Student
                {
                    Name = "Rick Johnson",
                    Seniority = "Freshman CS Major",
                    Affiliation = "University of Maryland",
                    City = "Rockville",
                    State = "MD",
                    Zip = "20950",
                    Email = "rickjohnson@sample.com",
                },
                new Student
                {
                    Name = "Thorsten Weinrich",
                    Seniority = "Senior in CS Major",
                    Affiliation = "Washington State University",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "thorsten@example.com",
                },
                new Student
                {
                    Name = "Yuhong Li",
                    Seniority = "Senior CS Major",
                    Affiliation = "Washington State University",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "yuhong@example.com",
                },
                new Student
                {
                    Name = "Jon Orton",
                    Seniority = "Freshman CS Major",
                    Affiliation = "Washington State University",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "jon@example.com",
                },
                new Student
                {
                    Name = "Diliana Alexieva-Bosseva",
                    Seniority = "Assistant Professor",
                    Affiliation = "Washington State University",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "diliana@example.com",
                }
                );
        }

        public static void AddActivities(Mvc3CodeFirst.Models.SampleDataContext context)
        {
            context.Activities.AddOrUpdate(p => p.Name,
               new Activity
               {
                   Name = "Linq to Twitter",
                   Description = "LINQ to Twitter is an open source 3rd party LINQ Provider for the Twitter micro-blogging service. It uses standard LINQ syntax for queries and includes method calls for changes via the Twitter API.",
                   Category = 1,
                   CommentCounts = 2,
                   ViewCounts = 35,
                   LikertScale = 3,
               },
               new Activity
               {
                   Name = "Streaming Tweets with LinqToTwitter C#",
                   Description = "Is there any chance to retrive the email from a twitter user? I'm using the LinqToTwitter Nuget in C# Mvc4. Please if you know anything :)!",
                   Category = 2,
                   CommentCounts = 3,
                   ViewCounts = 58,
                   LikertScale = 2,
               },
               new Activity
               {
                   Name = "Is it possible to retrieve the Twitter userid of a user from the access token?",
                   Description = @"Let me explain my problem, currently I use LinqToTwitter to perform the authorization of a user.<br/>
                                    I have the Connect Twitter button on my website, when the user click on it, an ajax request requests the method to perform authorization, the user is redirect to :<br />
                                    <div styles=""padding:5px;background-color:#eee;"">api.twitter.com/oauth/authorize?oauth_token=</div>
                                    and then enter his login and password.<br />
                                    Once it's done, he is redirect to the urlReferrer of my website and I receive the fields I need like username, userid, ....",
                   Category = 2,
                   CommentCounts = 5,
                   ViewCounts = 39,
                   LikertScale = 3,
               },
               new Activity
               {
                   Name = "Cannot post Tweets with Linq to Twitter",
                   Description = @"I have no problems using the Linq to Twitter WebAuthorizer to post Tweets to Twitter if my end-users are directed to Twitter's Oauth page and returned to our site. Using WebAuthorizer in this manner works great.<br />
                                    However, if I try to store the end-user's Oauth credentials and use them to Tweet, I get a 401 Unauthorized error ...",
                   Category = 2,
                   CommentCounts = 3,
                   ViewCounts = 69,
                   LikertScale = 2,
               },
               new Activity
               {
                   Name = "Display a table/list data dynamically",
                   Description = @"<p>I have a view page, users.cshtml. And I have a JsonResult action method, jsongetusers() that returns the list of users in json format. </p>
                                    <p>On users.cshtml page load, I want to get the list of users, build a table and display it. What is the best way to implement this in ASP.Net MVC using Razor? I am pretty new to MVC3 and Razor. My initial thought was to loop through the json result and build a table using javascript/jquery and append it to the DOM. But I am guessing there must be a better way to do this?</p>
                                    <p>Thanks.</p>
                                    ",
                   Category = 2,
                   CommentCounts = 3,
                   ViewCounts = 69,
                   LikertScale = 2,
               },
               new Activity
               {
                   Name = @"Sample N-tier ASP.NET MVC3 application",
                   Description = @"<div class=""post-text"">
                                    <p>I was in the same position not long ago. </p>
                                    <p>The things you linked are OK, but certainly not enough on their own.</p>
                                    <p>I find this topic lacking in the free resources, as it is quite big and needs good organization and breadth. On the other hand, there are good resources if you are willing to pay a little.</p>
                                    <p>Here are the courses that are great on the topic:</p>
                                    <p><a href=""http://www.pluralsight-training.net/microsoft/Courses/TableOfContents?courseName=principles-oo-design"">Principles of Object Oriented Design</a> - by Steve Smith, he is a great lector.</p>
                                    <p><a href=""http://www.pluralsight-training.net/microsoft/Courses/TableOfContents?courseName=patterns-library"">Design Patterns Library</a> - over 10 hours of videos on design patterns. Can't compare them to DotFactory, but they are very well done.</p>
                                    <p><a href=""http://www.pluralsight-training.net/microsoft/Courses/TableOfContents?courseName=inversion-of-control"">Inversion of Control</a> - what the name says, important topic in depth.</p>
                                    <p>There are also lots of stuff on TDD, MVC, EF etc. All worthy topics.</p>
                                    <p><a href=""http://rads.stackoverflow.com/amzn/click/B004I6DDFQ"">Professional Enterprise .NET</a></p>
                                    <p><a href=""http://rads.stackoverflow.com/amzn/click/B001FA0NX8"">Microsoft® .NET: Architecting Applications for the Enterprise</a> </p>
                                    <p><a href=""http://rads.stackoverflow.com/amzn/click/B0054KOKQQ"">Applying Domain-Driven Design and Patterns: With Examples in C# and .NET</a></p>
                                    ",
                   Category = 3,
                   CommentCounts = 6,
                   ViewCounts = 169,
                   LikertScale = 5,
               },
               new Activity
               {
                   Name = "LINQ to Twitter Support Xamarin.iOS?",
                   Description = "I wonder if anyone try using LINQ to Twitter 3.0 beta with Xamarin.iOS > Joe Mayo provide an example of how using the library with Xamarin.Android However i can't seems to get that work on IOS > it's compiling, but it crashes at runtime because it's looking for not-existing assemblies",
                   Category = 2,
                   CommentCounts = 1,
                   ViewCounts = 50,
                   LikertScale = 6,
               }
               );
        }
    }
}
