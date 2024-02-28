<!-- PROJECT LOGO -->
<div><br/>

![Product Name Screen Shot][product-screenshot]

  <p align="center">
    <h2 align="center">OpenAI model in the form of Console App</h2>
    <br/>
    <br/>
</div>



<!-- ABOUT THE PROJECT -->
## About The Project

ChatCMD is an amator project of recreating basic functionalities of the real ChatGPT ChatBot. The Project uses OpenAI completion API with the Free Plan API Key. At this stage of development, ChatCMD offers single chat converstaion with the language model, with application's session-based chat history.

The future objective of the development is to:
- give the user access multiple chats with the model
- save previous conversation to a file or database
- additional application options - like Model's Request Lenght

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

* [![.NET][.NetCsharp]][.NetCsharp-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

In order to setup the project, you need to follow few simple steps:
1. Create a new account on https://openai.com/
2. In the "API keys" section, create a new key and copy it
3. Paste your key in a "ApiKey" field of "ApiConnection/apiconfig.json" file located in the "Infrastructure" project

<!-- ROADMAP -->
## Roadmap

- [x] Valid communication with single POST and GET requests
- [x] Chat history
	- [x] Session based chat history
	- [ ] Saved to file
- [x] Terminal UI with Menu
- [x] Terminal UI animations
- [ ] Multiple language Terminal UI
	- [ ] Polish
	- [x] English
- [ ] Multiple chats, to continue multiple conversation
- [ ] Additional Options - Language, Token lenght and Terminal windows size

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

Jakub Nowak - [@LinkedIn Profile](https://www.linkedin.com/in/jakub-nowak-a245312b7/)
<br/> jakubszymonnowak@gmail.com

Project Link: [github.com/JakubNovvak/ChatCMD](https://github.com/JakubNovvak/ChatCMD)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
[product-screenshot]: https://i.ibb.co/ZJVhMH4/var3.png
[.NetCsharp]: https://img.shields.io/badge/-.NET%208.0%20%7C%20%20C%23%2012.0-blueviolet?style=for-the-badge
[.NetCsharp-url]: https://dotnet.microsoft.com/en-us/
