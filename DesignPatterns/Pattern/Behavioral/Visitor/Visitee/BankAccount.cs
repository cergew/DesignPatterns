﻿using DesignPatterns.Pattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Pattern.Behavioral.Visitor.Visitee {
  public class BankAccount : IVisitee {
    public BankAccount(int amount, double monthlyInterest) {
      Amount = amount;
      MonthlyInterest = monthlyInterest;
    }

    public int Amount { get; }

    public double MonthlyInterest { get; }

    public void Accept(IPersonVisitor visitor) {
      visitor.Visit(this);
    }
  }
}