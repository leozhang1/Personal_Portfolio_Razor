
namespace Personal_Portfolio_Razor.Services;

public class SkillsDataRepository : ISkillsDataRepository<string>
{
    private List<string> programmingLanguages;
    private List<string> techs;
    private List<string> pythonLibraries;
    private List<string> linuxTools;

    public SkillsDataRepository()
    {
        programmingLanguages = new List<string>()
        {
            "C# - I learned this language when I was learning to use the Unity Game engine to make video games. The language was easy to pick up because it was syntactically similar to Java, which I learned in high school and college.",
            "Python - This has become my favorite programming language. It reads like English and has many sweet syntactic sugars. I use it for leetcode, OpenCV, filehandling, and automating tasks via webscraping.",
            "JavaScript - I have learned this language through using Vue.js for frontend web applications and Node.js for building APIs for managing my own passwords, storing images in the cloud, and general storage purposes for any frontend applications I build. Although I do use TypeScript (\"typed javascript\") much more often because the type checking aspect of the language is very important for easing the process of scaling up projects.",
            "Dart - This is the language I use for flutter development. I love workflow and design of flutter for cross-platform mobile development. I have found this language very intuitive to learn because of its similarity to Java and JavaScript.",
            "C++ - This is the language that had the highest learning curve for me so far. Luckily the C knowledge I acquired from college helped a lot because of pointers and memory address concepts, which most other modern languages lacked. I use this language mainly at my research position for building OpenCV projects which requires low-level control and processing performance-heavy tasks.",
            "C, Java, Haskell, Erlang - These are mainly languages that I have used for university classes and have built me a solid foundation for learning other languages or frameworks in the software field.",
        };

        techs = new List<string>()
        {
            "Razor Pages (.Net) - Fun fact: This website was built using this beautiful framework! I actually rebuilt my entire website from scratch using this because I needed to learn this for work! I already have a good knowledge on writing RESTful APIs in .Net so learning razor pages wasn't so bad",
            "Unity - I have always been one of the biggest gamers I know before I got into coding in college and being able to build any game I want using a proprietary game engine such as this one is simply amazing. The most common scripting option for this engine is C# and it is a beautiful and easy-to-use language that is very similar to Java, which I learned in high school and college, so picking this language up was a piece of cake.",
            "Flutter - This is the framework I used to build mobile applications. What is special about this framework is that it is cross platform so you write the code once and the application will be deployable on both Android and iOS devices. There is a saying that time is money, and this framework really gets the job done when you need to quickly build a scalable app that is reliable.",
            "Next.js - I really love how this framework simplfies how we work with React. I love the server-side rendering capabilities and the out of the box typescript support it provides."
        };

        pythonLibraries = new List<string>()
        {
            "OpenCV & DJI-TelloPy - I always found robots fascinating and I loved controlling robots in first person shooter games back when I was a kid. Now that I have been coding for years, I wanted to experience what it was like to control robots in real life via programming, so I bought a Tello drone on Amazon and decided to build some projects with it.",
            "Python-Selenium & Python-Beautiful Soup - I used these libraries for all my webscraping projects. They are very powerful tools when you learn to use them properly and can help you quickly collect the data you need for testing out machine learning models.",
            "Python-Pandas, Numpy, and Matplotlib - These were powerful libraries I used for data manipulation and collection for different data applications I may have.",
            "Python-ScikitLearn - This was the main library we used for importing different machine learning models from simple decision trees to complex state of the art models such as xgboost.",
            "Python-prophet - I use this model to make predictions about the future based on the current data collected."
        };

        linuxTools = new List<string>()
        {
            "Endeavour OS - This is the linux distro I finally settled on after hopping around several other distros. It is arch-based, so it has pacman as the package manager, which is in my opinion, the most intuitive one out of all the other linux distros such as apt and dnf.",
            "Vim - This is my favorite text editor that can be used via the terminal and is very handy for making edits to files on my computer.",
            "KDE - This is the desktop environment that I use for my linux operating system. It is by far one of the most customizable desktop environments I have ever seen for all the linux distributions out there, which gives me plenty of room and freedom to customize my workspace however I choose."
        };
    }

    public Dictionary<string, IEnumerable<string>> GetData()
    {
        return new Dictionary<string, IEnumerable<string>>()
        {
            {"programmingLanguages", programmingLanguages.AsEnumerable<string>()},
            {"techs", techs.AsEnumerable<string>()},
            {"pythonLibraries", pythonLibraries.AsEnumerable<string>()},
            {"linuxTools", linuxTools.AsEnumerable<string>()},
        };
    }
}

