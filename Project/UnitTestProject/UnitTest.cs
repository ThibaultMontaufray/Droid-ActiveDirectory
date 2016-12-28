using System;
using Droid_ActiveDirectory;
using NUnit.Framework;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void Test_NewEnterprise()
        {
            try
            {
                Enterprise ent = new Enterprise();
                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_LDAP()
        {
            try
            {
                LDAP l = new LDAP("LDAP://SRVSECDC1001");
                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_login_form()
        {
            try
            {
                LoginForm lf = new LoginForm();
                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_ACPreview()
        {
            try
            {
                ActiveDirectoryPreview adp = new ActiveDirectoryPreview();
                adp.Enterprise = new Enterprise();
                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_DomainManager()
        {
            try
            {
                string ret;
                ret = DomainManager.ComputerName;
                ret = DomainManager.DomainControllerName;
                ret = DomainManager.DomainName;
                ret = DomainManager.DomainPath;
                ret = DomainManager.RootPath;

                var v1 = DomainManager.GetADList();

                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_InterfaceAD()
        {
            try
            {
                Droid_ActiveDirectory.Controler.Interface_activedirectory intAd = new Droid_ActiveDirectory.Controler.Interface_activedirectory();

                var v1 = Droid_ActiveDirectory.Controler.Interface_activedirectory.ACTION_130_lister_utilisateurs();
                var v2 = Droid_ActiveDirectory.Controler.Interface_activedirectory.ACTION_131_nommer_ordinateur();
                var v3 = Droid_ActiveDirectory.Controler.Interface_activedirectory.ACTION_132_lister_domaines();
                var v4 = Droid_ActiveDirectory.Controler.Interface_activedirectory.ACTION_133_lister_activeDirectory();

                Assert.IsTrue(true);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Assert.Fail(exp.Message);
            }
        }
    }
}
