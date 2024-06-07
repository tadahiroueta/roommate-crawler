using System.Text.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Crawler {

    public Cookie[] ImportCookies(){
        string text = File.ReadAllText("data/cookies.json");
        return JsonSerializer.Deserialize<Cookie[]>(text);
    }
    
    public void Main() {
        IWebDriver driver = new ChromeDriver();
        try {
            driver.Navigate().GoToUrl("https://www.instagram.com/uciclass.2028/");
            // driver.Manage().Cookies.AddCookie(new Cookie());
            
        }
        finally {
            driver.Quit();
        }
    }
}