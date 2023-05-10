using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;

namespace CourseProject.View
{
    public interface IViewCustomer
    {
        string Name { get; }
        string Surname { get; }
        DateTime DateOfBirth { get; }
        double Wallet { get; set; }
        string NameOfCard { get; }
        double ScoresCard { get; set; }
        string Content { get; set; }
        bool? Score { get; }
        IEnumerable? ListOfPurchases { get; }
        IEnumerable? Basket { get; set; }
        IEnumerable? Repository { get; set; }
    }
}
