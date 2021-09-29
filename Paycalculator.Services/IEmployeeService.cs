﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Paycalculator.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycalculator.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int Id);
        Task Delete(int employeeId);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
        IEnumerable<Employee> GetAll();
        IEnumerable<SelectListItem> GetAllEmployeesForPayroll();

    }
}
