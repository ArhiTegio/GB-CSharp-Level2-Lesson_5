using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    /// <summary>
    /// Базовый класс работников
    /// </summary>
    public abstract class BaseEmployee : IComparable<BaseEmployee>
    {
        double rate = 0;
        public BaseEmployee(string Name, int Age, int Salary, double rate)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.rate = rate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public double Rate { get => rate; set => rate = value; }

        /// <summary>
        /// Зарплата за месяц
        /// </summary>
        /// <returns></returns>
        public abstract double PaymentInManth();

        /// <summary>
        /// Данные о работнике
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Name}, {this.Age} лет,  {this.Salary} р. ";
        }

        /// <summary>
        /// Сравнение двух работников
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(BaseEmployee obj)
        {
            return obj.Salary > this.Salary ? -1 : 1;
        }

    }

    /// <summary>
    /// Работники с фиксированной оплатой труда
    /// </summary>
    class Employee : BaseEmployee
    {
        public Employee(string Name, int Age, int Salary, double rate) : base(Name, Age, Salary, rate)
        {
        }

        public override double PaymentInManth()
        {
            Salary = (int)Rate;
            return Salary;
        }
    }
}
