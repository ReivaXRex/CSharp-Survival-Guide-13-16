using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{
    public int salary;
    public int workingWeeks = 52;
    public int hoursWorked = 40;
    public int workTotal;
    public int hourlyPay;
    public override void CalculateSalary()
    {
        workTotal = hoursWorked * workingWeeks;
        hourlyPay = salary / workTotal;

        Debug.Log("$" + hourlyPay);
    }

    private void Start()
    {
        CalculateSalary();
    }
}
