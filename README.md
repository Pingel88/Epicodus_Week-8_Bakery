## <div align="center">Pierre's Bakery</div>
#### <div align="center">📚 *Epicodus Week 8 C# Project 2/26/2021* </div> 
***<p align="center">By Mike Pingel***</p>   
<p align="center">
<br>

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## 🚩 *Description*:    
### *A console application for Pierre's Bakery. Upon being greeted with a message, the user can specify how many loaves of bread or pastries they'd like to order and the application will return the total price. The application will adjust the total price for Pierre's current specials when buying multiple loaves or pastries. This project utilizes thorough model testing with custom classes and namespaces as well as auto-implemented properties.*


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to the GitHub repository for this project: [https://github.com/Pingel88/Epicodus_Week-8_Bakery.git](https://github.com/Pingel88/Epicodus_Week-8_Bakery.git).
* At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

  <img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>
* Unzip the file, navigate to the **'Bakery/Models'** folder to check code or to the **'Bakery.Tests/ModelTests'** folder to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/Pingel88/Epicodus_Week-8_Bakery.git` in your terminal or GitBash
* Navigate to the downloaded folder using `cd` command
* Execute `code .` command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet)*
### 📋 Specs:
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :------------- | :------------ | :-------------: |
| 01 | Creates a new instance of bread | `new Bread(0)` | Instance created | ✅ |
| 02 | Creates a new instance of pastry | `new Pastry(0)` | Instance created | ✅ |
| 03 | Bread has a static price of 5 | `Bread.GetIndividualPrice()` | 5 | ✅ |
| 04 | Pastry has a static price of 2 | `Pastry.GetIndividualPrice()` | 2 | ✅ |
| 05 | Bread has a static special price of twice the price for 'buy two get one free' | `Bread.GetSpecialPrice()` | 10 | ✅ |
| 06 | Pastry has a static price of 5 for 'buy three for $5' | `Pastry.GetSpecialPrice()` | 5 | ✅ |
| 07 | 2 loaves of bread as an auto-implemented property | `breadOrder.Quantity` | 2 | ✅ |
| 08 | 3 pastries as an auto-implemented quantity property | `pastryOrder.Quantity` | 3 | ✅ |
| 09 | Static method `breadOrder.getTotalPrice()` returns the total price | `new Bread(2)` | 10 | ✅ |
| 10 | Static method `pastryOrder.getTotalPrice()` returns the total price | `new Pastry(2)` | 4 | ✅ |
| 11 | Static method `breadOrder.getTotalPrice()` returns the total price and adjusts for specials | `new Bread(6)` | 20 | ✅ |
| 12 | Static method `pastryOrder.getTotalPrice()` returns the total price and adjusts for specials | `new Pastry(10)` | 17 | ✅ |

</details>



#### 🏁 Running Tests:
* To run MSTest, verify you are in the root project folder and enter `dotnet restore Bakery.Tests` in your terminal.
* You should now see **'obj'** folders in both the **'Bakery.Tests'** folder and **'Bakery'** folder.
* At this point you should be able to successfully run `dotnet test Bakery.Tests` to perform the tests.

####  🖥️ View website:
*A GitHub page is not available for this project. To view functionality in your terminal you need to navigate to the **'Bakery'** folder using `cd Bakery` then `dotnet run`.*

## 🛠️ *Technologies used:*
* C# 9
* .NET Core v5.0
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
  * No known bugs.

## 📬 Contact Information
#### For any questions *[email Mike Pingel](mailto:mdpingel+github@gmail.com?subject=[GitHub]Epicodus%20Project%20-%20Pierre's%20Bakery)*



## 📘 *License and copyright:*

> ***© Michael Pingel, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*