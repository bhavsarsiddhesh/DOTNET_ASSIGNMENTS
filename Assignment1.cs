using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            
            Employee E1 = new Employee("Yash", 5700, 10);
            Employee E2 = new Employee("Yashya", 6200);
            Employee E3 = new Employee("Aksahy");
            Console.WriteLine(E1.Name);
            Console.WriteLine(E1.EmpNo);
            Console.WriteLine(E2.EmpNo);
            Console.WriteLine(E3.EmpNo);
            Console.ReadLine();
        }
    }

    class Employee
    {
        // Properties

        string EName;
        public string Name
        {
            set
            {
                if (value != " ")
                    EName = value;
                else
                    Console.WriteLine("Plz Enter Name");
            }
            get
            {

                return EName;
            }
        }
        int Eno;
        public int EmpNo
        {
            get
            {
                return Eno;
            }
        }
        decimal EBasic;
        public decimal Basic
        {
            set
            {
                if (value >= 5000 && value <= 7000)
                    EBasic = value;
                else
                    Console.WriteLine("Basic Should In Between 5000 to 7000");
            }
            get
            {
                return EBasic;
            }
        }
        short EDeptNno;

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    EDeptNno = value;
                else
                    Console.WriteLine("Department No Should Be More than 0");
            }
            get
            {
                return EDeptNno;
            }
        }

        // Methods
        public decimal GetNetSalary() {
            decimal netSal;
            netSal = EBasic + 3000 + 1500;
            return netSal;
        }

        // Constructors
        static int auto = 0;
       public Employee(string name, decimal basic, short deptno) {
            this.EName = name;
            this.EBasic = basic;
            this.EDeptNno = deptno;
            auto++;
            this.Eno = auto;
        }

       public Employee(string name, decimal basic) {
            this.EName = name;
            auto++;
           this.EBasic = basic;
            this.Eno = auto;
        }

       public Employee(string name){
            this.EName = name;
            auto++;
            this.Eno = auto;
        }
       
    }
}
