using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paint;

namespace UnitTestProjectProgram
{
    [TestClass]
    public class CmdTest
    {
        [TestMethod]
        public void CheckIfValidation()
        {
            string input;
            TextBox textbox = new TextBox();
            input = "counter = 5 \r\n If counter = 5 then \r\n radius + 25 \r\n Circle 5 \r\n EndIf";

            textbox.Text = input;
            Validation validation = new Validation(textbox);

            Boolean expectedOutcome;
            Boolean realOutcome;
            expectedOutcome = true;
            validation.checkLoopAndIfValidation();
            realOutcome = validation.isValidCommand;
            Assert.AreEqual(expectedOutcome, realOutcome);
        }

    }
}
