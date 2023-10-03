using AutoMapper;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Gestion.Parc.Informatique.Controllers;


// [Authorize]
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "Gestion Parc Informatique")]
public class WebScraberController : ControllerBase
{
    public WebScraberController()
    {
    }

    [HttpGet("webScraber")]
    public async Task<ActionResult> Te_ster()
    {
        string Url = "https://algeria.blsspainglobal.com/DZA/Account/LogIn";
        string TestUrl = "https://algeria.blsspainglobal.com/DZA/Account/LogIn";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(Url);

        var title = driver.Title;
        // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        // var textBox = driver.FindElement(By.Id("UserId4"));
        for (int i = 1; i <= 10; i++)
        {
            try
            {
                var passwordBox = driver.FindElement(By.Id("Password"+i.ToString()));
                passwordBox.SendKeys("pass");

            }
            catch (Exception e)
            {
                Console.WriteLine("Password" + i.ToString() + " Not Found");
            }
        }
        for (int i = 1; i <= 10; i++)
        {
            try
            {
                var UserBox = driver.FindElement(By.Id("UserId"+i.ToString()));
                UserBox.SendKeys("pass");

            }
            catch (Exception e)
            {
                Console.WriteLine("UserId" + i.ToString() + " Not Found");
            }
        }




        // var submitButton = driver.FindElement(By.TagName("button"));

        // submitButton.Click();

        return Ok(title);
    }

}


