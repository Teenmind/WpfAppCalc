using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFieldsCalc
{
    [TestClass]
    public class UnitTestFields
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfApplicationCalc\\WpfApplicationCalc\\obj\\Debug\\WpfApplicationCalc.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<TextBox>("aTxt").Text = "5";
            window.Get<TextBox>("bTxt").Text = "5";
            window.Get<TextBox>("oPer").Text = "+";
            window.Get<Button>("res").Click();
            string res = window.Get<TextBox>("resTxt").Text;
            application.Kill();
            Assert.AreEqual("10", res);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfApplicationCalc\\WpfApplicationCalc\\obj\\Debug\\WpfApplicationCalc.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<TextBox>("aTxt").Text = "5";
            window.Get<TextBox>("bTxt").Text = "5";
            window.Get<TextBox>("oPer").Text = "-";
            window.Get<Button>("res").Click();
            string res = window.Get<TextBox>("resTxt").Text;
            application.Kill();
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void TestMethodMult()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfApplicationCalc\\WpfApplicationCalc\\obj\\Debug\\WpfApplicationCalc.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<TextBox>("aTxt").Text = "5";
            window.Get<TextBox>("bTxt").Text = "5";
            window.Get<TextBox>("oPer").Text = "*";
            window.Get<Button>("res").Click();
            string res = window.Get<TextBox>("resTxt").Text;
            application.Kill();
            Assert.AreEqual("25", res);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfApplicationCalc\\WpfApplicationCalc\\obj\\Debug\\WpfApplicationCalc.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<TextBox>("aTxt").Text = "10";
            window.Get<TextBox>("bTxt").Text = "5";
            window.Get<TextBox>("oPer").Text = "/";
            window.Get<Button>("res").Click();
            string res = window.Get<TextBox>("resTxt").Text;
            application.Kill();
            Assert.AreEqual("2", res);
        }
    }
}