using System.Text.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Crawler {
    
    public void Main() {
        IWebDriver driver = new ChromeDriver();
        try {
            driver.Navigate().GoToUrl("https://www.instagram.com/uciclass.2028/");
            
        }
        finally {
            driver.Quit();
        }
    }
}