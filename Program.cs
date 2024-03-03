// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

class Program
{
    static void Main(string[] args)
    {

        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--headless");
        var driver = new ChromeDriver("C:\\Users\\USER\\Documents\\Programming\\chromedriver.exe");

    try
    {

        driver.Navigate().GoToUrl("https://academic.ui.ac.id/main/Authentication/");

        IWebElement username = driver.FindElement(By.CssSelector("#u"));
        username.SendKeys("username");

        IWebElement password = driver.FindElement(By.CssSelector("#login > form > p:nth-child(2) > input"));
        password.SendKeys("password");

        IWebElement loginButton = driver.FindElement(By.CssSelector("#submit > input[type=submit]"));
        loginButton.Click();
        
        // Thread.Sleep(100); 

        IWebElement IRSButton = driver.FindElement(By.CssSelector("#nv > li:nth-child(6) > a"));

        HoverOverElement(driver, IRSButton);

        IWebElement isiIRSButton = driver.FindElement(By.CssSelector("#nv > li:nth-child(6) > ul > li:nth-child(2) > a"));
        isiIRSButton.Click();

    } 
    finally
    {
        // driver.Quit();
    }
    }

    static void HoverOverElement(IWebDriver driver, IWebElement element)
    {
        Actions actions = new Actions(driver);
        actions.MoveToElement(element).Perform();
    }
}