﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.WindowsAPI;

namespace BaseAutomationFramework.PageObjects.Encompass
{
	public class RegZCD : BaseScreen
	{
		public static SearchCriteria scWindow = SearchCriteria.ByAutomationId("LoanPage");
		public static SearchCriteria[] scArray = new SearchCriteria[] { EncompassMain.scWindow };//, scWindow };
		public const bool SET_MAXIMIZED = false;
		public RegZCD()
		{
			PropertyCondition pcWindow = new PropertyCondition(AutomationElement.AutomationIdProperty, "MainForm");
			PropertyCondition pcsubWindow = new PropertyCondition(AutomationElement.AutomationIdProperty, "LoanPage");
			aeScreen = AutomationElement.RootElement.FindFirst(TreeScope.Children, pcWindow);
			aeScreen = aeScreen.FindFirst(TreeScope.Descendants, pcsubWindow);
			aeScreen.WaitWhileBusy();

			if (aeScreen == null)
				throw new Exception("Screen is null!!!");
		}

		public static RegZCD OpenForm_FromFormsTab()
		{
			new FormsTab()
				.lstbx_Forms_SelectForm("RegZ - CD");
				Thread.Sleep(8000);

			return new RegZCD();
		}

		#region Text Boxes

		private PropertyCondition txt_FirstPaymentDate = new PropertyCondition(AutomationElement.AutomationIdProperty, "l_682");

		public RegZCD txt_FirstPaymentDate_SendKeys(string Input)
		{
			aElement = aeScreen.FindFirst(TreeScope.Descendants, txt_FirstPaymentDate);
			aElement.SetFocus();
			aElement.ClickCenterOfBounds();
			Thread.Sleep(500);
			Keyboard.Instance.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
			Keyboard.Instance.Enter("a");
			Keyboard.Instance.LeaveAllKeys();
			Thread.Sleep(250);
			Keyboard.Instance.Enter(Input);
			Keyboard.Instance.PressSpecialKey(KeyboardInput.SpecialKeys.TAB);
			aElement.WaitWhileBusy();
			Thread.Sleep(1000);

			return this;
		}

		#endregion
	}
}