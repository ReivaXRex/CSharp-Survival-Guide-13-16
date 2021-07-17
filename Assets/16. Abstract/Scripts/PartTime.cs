using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{
    public int hoursWorked;
    public int hourlyRate;
    public int totalPay;

    public override void CalculateSalary()
    {
        totalPay = hoursWorked * hourlyRate;
        Debug.Log("$" + totalPay);
    }

    private void Start()
    {
        CalculateSalary();
    }
}
