//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Dimitar";
        string middleName = "Krasimirov";
        string lastName = "Keremedchiev";
        string bankName = "Fibank";
        string IBAN = "BG22UNCR2132546987";
        string BIC = "UNCRBGSHIFT";
        string firstC = "4521254196871256";
        string secondC = "5897452369874512";
        string thirdC = "4785258798451236";
        decimal moneyBalance = 25.26556114m;
    }
}
