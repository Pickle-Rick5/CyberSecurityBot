CyberSecurity Awareness ChatBot

A C# console-based chatbot designed to educate users on basic cybersecurity practices such as password safety, phishing awareness, and safe browsing.

Project Overview

This application simulates an interactive chatbot that communicates with users through a styled console interface. It provides helpful tips and guidance to improve online safety awareness.

Features

* 🤖 Interactive chatbot with real-time user input
* 🔐 Cybersecurity tips (passwords, phishing, safe browsing)
* 🎨 Styled console interface using a custom UIHelper class
* 🔊 Audio feedback system
* ⚠️ Input validation and error handling
* ✅ GitHub Actions CI for automatic build verification

Technologies Used

* C# (.NET)
* Console Application
* Git & GitHub
* GitHub Actions (CI/CD)

Project Structure

CyberSecurityBot/
│
├── CyberSecurityBot/
│   ├── Program.cs
│   ├── Chatbot.cs
│   ├── UIHelper.cs
│   ├── AudioPlayer.cs
│   └── CyberSecurityBot.csproj
│
└── .github/
└── workflows/
└── dotnet.yml

How to Run the Project

1. Clone the repository:
   git clone https://github.com/Pickle-Rick5/CyberSecurityBot.git

2. Open the project in Visual Studio

3. Build and run the application

Continuous Integration

This project uses GitHub Actions to automatically:

* Restore dependencies
* Build the project
* Detect errors on every push

You can view workflow runs in the **Actions** tab of the repository.


Example Usage

User input:

> how do I stay safe online?

Bot response:

> Use strong passwords, avoid suspicious links, and always verify websites.


Author

Developed by Jason Basil Adams.


License

This project is for educational purposes.
