using System;
namespace PayCenter.ViewModels
{
    public class BalancePageViewModel
    {
        public BalancePageViewModel()
        {
            Title = "My Balance";
            Message = "You can leave the funds in your balance and it will automatically be used when you shop online. " +
                      "Or you can withdraw your funds to yout bank account.";
        }

        #region Properties
        public string Title { get; set; }
        public string Message { get; set; }
        #endregion
    }
}
