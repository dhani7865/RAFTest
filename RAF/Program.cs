using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Xunit;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using RAF.Test_Cases;

namespace RAF
{
    public class Program
    {
        private static ExtentReports extent;
        private static object perform;


        // Start method for extent reports
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            extent = new ExtentReports();

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            // string reportPath = projectPath + "TestReport\\Start Script Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Tasks Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Next Tasks Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Contacts Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Role Admin Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Task Admin Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Squadrons Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Call Forward Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Newsletters Button Test Documentation - Passed - 10-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Agent Message Admin Button Test Documentation - Passed - 10-02-2022.html";
            string reportPath = projectPath + "TestReport\\Media Admin Button Test Documentation - Passed - 10-02-2022.html";



            var htmlReporter = new ExtentV3HtmlReporter(reportPath);

            extent.AttachReporter(htmlReporter);

        }



        public void ExtentClose()
        {
            extent.Flush();
        }


        class OneTimeSetUpAttribute : Attribute
        {
        }


        [Fact]
        static void Main()
        {
            // Test
            // This is where everything is run
            IWebDriver driver = new ChromeDriver();

            ExtentStart();


            // StartScriptTest.StartScript(driver, extent);
            // TasksTest.Tasks(driver, extent);
            // NextTasksTest.NextTasks(driver, extent);
            // ContactsTest.Contacts(driver, extent);
            // RoleAdminTest.RoleAdmin(driver, extent);
            // TaskAdminTest.TaskAdmin(driver, extent);
            // SquadronsTest.Squadrons(driver, extent);
            // CallForwardTest.CallForward(driver, extent);
            // NewslettersTest.Newsletters(driver, extent);
            // AgentMessageAdminTest.AgentMessageAdmin(driver, extent);
            MediaAdminTest.MediaAdmin(driver, extent);








        }
    }
}
