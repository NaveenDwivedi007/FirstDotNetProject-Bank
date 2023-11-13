using bankApp;

namespace BankingTest
{
    public class BankAppTest
    {
        [Fact]
        public void InvaildOperationTest()
        {
            var testAccount = new BankAccount("Naveen",1000);
            Assert.Throws<InvalidOperationException>(() =>testAccount.makeWithdrawal(2000, DateTime.Now, "Test withdrqwal"));
        }

        [Fact] 
        public void NegativeAmountDepositTest() 
        {
            var testAccount = new BankAccount("Naveen", 1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => testAccount.makeDeposit(-2000, DateTime.Now, "Test Deposit"));
        }
    }
}