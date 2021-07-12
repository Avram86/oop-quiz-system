using System;
using OopQuizSystem.Library;

namespace OopQuizSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializare baza de date (specificam setul general de intrebari)
            InitializeQuestionsDatabase();

            // Alegand un set de intrebari din baza de date, sa putem creea un Quiz
            Quiz quiz = QuestionsDatabase.GenerateQuiz(4);

            // John Doe is preparing to answer the quiz
            QuizRespondent johnDoe = new QuizRespondent("John Doe", quiz);

            johnDoe.Resolve(new ConsoleGraphicalInterface());
        }

        private static void InitializeQuestionsDatabase()
        {
            QuestionsDatabase.Initialize(new Question[]
            {
                new SingleSelectionQuestion(
                    1,
                    "What is the best language?",
                    new[]
                    {
                        new Option("C#", true),
                        new Option("Java", false),
                        new Option("Phyton", false),
                    }),

                new SingleSelectionQuestion(
                    2,
                    "What is the best database system?",
                    new[]
                    {
                        new Option("MySQL", false),
                        new Option("SQL Server", true),
                        new Option("Oracle", false)
                    }),

                new SingleSelectionQuestion(
                    3,
                    "What is the best mobile platform?",
                    new[]
                    {
                        new Option("Android", true),
                        new Option("iOS", false)
                    }),

                new SingleSelectionQuestion(
                    4,
                    "What is the best OS?",
                    new[]
                    {
                        new Option("Windows 10", false),
                        new Option("Mac OS", false),
                        new Option("Linux", true)
                    }),

                 new MultipleSelectionQuestion(
                    5,
                    "What is C#?",
                    new[]
                    {
                        new Option("C# is a computer programming language", true),
                        new Option("C# is one of the most popular programming languages in the world", true),
                        new Option("C# is the primary language for building Microsoft .NET software applications", true),
                        new Option("C# is a deprecated language", false),
                        new Option("C# language is an object-oriented programming language", true)
                    }),

                  new MultipleSelectionQuestion(
                    6,
                    "What is an object in C#?",
                    new[]
                    {
                        new Option("Objects are created using class instances", true),
                        new Option("Objects store real values in computer memory", true),
                        new Option("This object is also called an instance", true),
                        new Option("An object is a template that defines what a data structure will look like", false)
                    }),

                  new MultipleSelectionQuestion(
                    7,
                    "What is managed or un-managed code?",
                    new[]
                    {
                        new Option("Managed code is directly executed by the Common Language Runtime", true),
                        new Option("Languages such as C or C++ or Visual Basic are unmanaged", true),
                        new Option("The code that is developed outside of the .NET framework is known as unmanaged code", true),
                        new Option("Any language that is written in .NET Framework is managed code", true)
                    })
            });
        }
    }
}