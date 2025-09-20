using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Models.Entities;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString)); 

var app = builder.Build();

using var scope = app.Services.CreateScope();
var dbcontext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

if (!dbcontext.Questions.Any())
{
    var question1Answer = Guid.NewGuid();

    var question1 = new Question()
    {

        Text = "Which of the following is not a Java feature?",
        Options = new List<Option>
        {
            new Option()
            {
                Id = Guid.NewGuid(),
                Text = "Object-oriented",
            },
            new ()
            {
                Id = question1Answer,
                Text = "Use of pointers",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "Portable",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "Dynamic and Extensible",
            }
        },
        CorrectOption = question1Answer

    };

    var question2Answer = Guid.NewGuid();
    var question2 = new Question()
    {

        Text = "Which of these is a valid keyword in Java?",
        Options = new List<Option>
        {
            new Option()
            {
                Id = question2Answer,
                Text = "interface",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "unsigned",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "friend",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "extern",
            }
        },
        CorrectOption = question2Answer

    };


    var question3Answer = Guid.NewGuid();
    var question3 = new Question()
    {

        Text = "Which of the following is the correct way to create an object in Java?",
        Options = new List<Option>
        {
            new Option()
            {
                Id = question3Answer,
                Text = "MyClass obj = new MyClass();",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "obj = MyClass();",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "new MyClass obj;",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "extern",
            }
        },
        CorrectOption = question3Answer

    };

    var question4Answer = Guid.NewGuid();
    var question4 = new Question()
    {

        Text = "Which of the following is used to find and fix bugs in Java programs?",
        Options = new List<Option>
        {
            new Option()
            {
                Id = Guid.NewGuid(),
                Text = "JVM",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "JDK",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "JRE",
            },
            new ()
            {
                Id = question4Answer,
                Text = "JDB",
            }
        },
        CorrectOption = question4Answer

    };

    var question5Answer = Guid.NewGuid();
    var question5 = new Question()
    {

        Text = "What is the size of an int data type in Java?",
        Options = new List<Option>
        {
            new Option()
            {
                Id = question5Answer,
                Text = "4 bytes",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "8 bytes",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "2 bytes",
            },
            new ()
            {
                Id =  Guid.NewGuid(),
                Text = "16 bytes",
            }
        },
        CorrectOption = question5Answer

    };

    var question6Answer = Guid.NewGuid();
    var question6 = new Question()
    {

        Text = "What is the size of an int data type in Java?",
        Options = new List<Option>
        {
            new Option()
            {
                Id =  Guid.NewGuid(),
                Text = "implement",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "inherits",
            },
            new ()
            {
                Id = question6Answer,
                Text = "extends",
            },
            new ()
            {
                Id =  Guid.NewGuid(),
                Text = "super",
            }
        },
        CorrectOption = question6Answer

    };

    var question7Answer = Guid.NewGuid();
    var question7 = new Question()
    {

        Text = "Which of these exceptions is thrown when a divided-by-zero operation occurs?",
        Options = new List<Option>
        {
            new Option()
            {
                Id =  Guid.NewGuid(),
                Text = "NullPointerException",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "NumberFormatException",
            },
            new ()
            {
                Id = question7Answer,
                Text = "ArithmeticException",
            },
            new ()
            {
                Id =  Guid.NewGuid(),
                Text = "ArrayIndexOutOfBoundsException",
            }
        },
        CorrectOption = question7Answer

    };

    var question8Answer = Guid.NewGuid();
    var question8 = new Question()
    {

        Text = "Which of the following is not a Java access modifier?",
        Options = new List<Option>
        {
            new Option()
            {
                Id =  Guid.NewGuid(),
                Text = "public",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "private",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "protected",
            },
            new ()
            {
                Id =  question8Answer,
                Text = "friendly",
            }
        },
        CorrectOption = question8Answer

    };

    var question9Answer = Guid.NewGuid();
    var question9 = new Question()
    {

        Text = "Which method is the entry point for a Java program?",
        Options = new List<Option>
        {
            new Option()
            {
                Id =  Guid.NewGuid(),
                Text = "start()",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "init()",
            },
            new ()
            {
                Id = question9Answer,
                Text = "main()",
            },
            new ()
            {
                Id =  Guid.NewGuid(),
                Text = "run()",
            }
        },
        CorrectOption = question9Answer

    };

    var question10Answer = Guid.NewGuid();
    var question10 = new Question()
    {

        Text = "Which of these is a marker interface in Java?",
        Options = new List<Option>
        {
            new Option()
            {
                Id =  Guid.NewGuid(),
                Text = "Runnable",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "Serializable",
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Text = "Remote",
            },
            new ()
            {
                Id =  question10Answer,
                Text = "Both B and C",
            }
        },
        CorrectOption = question10Answer

    };

    dbcontext.Questions.AddRange([question1,
        question2,
        question3,
        question4,
        question5,
        question6,
        question7,
        question8,
        question9,
        question10
    ]);
    dbcontext.SaveChanges();

}





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Quiz}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
