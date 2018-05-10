﻿///------------------------------------------------------------------------------------------------------------------------
///   Namespace:      <Namespace>
///   Class:          <BorrowerLoanCenterLogIn>
///   Description:    <Borrower_Loan_Center_Log_In>
///   Author:         <Hannah_Charls>           Date: <Novmeber_21_2017>
///   Notes:          <>
///   Revision History:
///   Name:				 Date:					Description:
///   
/// 
///------------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAutomationFramework.PageObjects.EncompassLoanCenter
{
	public class BorrowerLoanCenterLogIn : BaseSeleniumPage
	{
		public BorrowerLoanCenterLogIn()
		{
			WaitForPageLoadToComplete(300);
			WaitForAjax();
			PageFactory.InitElements(webDriver, this);
		}		
		public static BorrowerLoanCenterLogIn Initialize()
		{
			return new BorrowerLoanCenterLogIn();
		}

		#region Buttons

		private By btn_Login = By.XPath("//span[contains(.,'Login')]");
		//
		public void btn_Login_Click()
		{
			wElement = btn_Login.GetWebElement();
			wElement.Click();
			wElement.WaitUntilStale();
		}

		#endregion

		#region Text Boxes

		private By txt_Email = By.XPath("//input[@id='ctl01_contentContainerHolder_textboxEmail']");
		private By txt_Password = By.XPath("//input[@id='ctl01_contentContainerHolder_textboxPassword']");
		//
		public BorrowerLoanCenterLogIn txt_Email_SendKeys(string Email)
		{
			wElement = txt_Email.GetWebElement();
			wElement.SendKeys(Email);

			return this;
		}
		public BorrowerLoanCenterLogIn txt_Password_SendKeys(string Password)
		{
			wElement = txt_Password.GetWebElement();
			wElement.SendKeys(Password);

			return this;
		}

		#endregion



	}
}
