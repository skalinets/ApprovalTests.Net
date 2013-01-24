using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace ApprovalDemos.GettingStartedDemos
{
	[TestFixture]
	[UseReporter(typeof (DiffReporter))]
	public class SampleTest
	{
		[Test]
		public void TestList()
		{
			var names = new[] {"Llewellyn", "James", "Dan", "Jason", "Katrina"};
			Array.Sort(names);
			Approvals.VerifyAll(names, "");
		}
	}
}