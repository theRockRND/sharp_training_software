using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {       
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData ("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("bbb");
            group.Footer = "fff";
            group.Header = "ddd";
            FillGroupForm(group);
            Submit();
            ReturnsToGroupPage();
            Logout();
        }
    }
}
