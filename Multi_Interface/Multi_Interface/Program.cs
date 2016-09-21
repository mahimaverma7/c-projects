using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multi_Interface
{
    public interface employeeInfo
    {
        void showEmployeeData();
    }
    public interface compInfo
    {
        void showCompData();
    }

    public class Organisation : employeeInfo, compInfo
    {
        private int empId = 0;
        private string empname = " ";
        private string age = " ";
        private double salary = 0.0;
        private string compId = " ";
        private string compname = " ";
        /// <summary>
        /// This is for Organisation details
        /// </summary>
        /// <param name="eid">This is Employee ID</param>
        /// <param name="empn">This is Employee Name</param>
        /// <param name="a">This is Employee Age</param>
        /// <param name="s">This is Employee Salary</param>
        /// <param name="cid">This is Company ID</param>
        /// <param name="compn">This is Company Name</param>
        public Organisation(int eid, string empn, string a,double s, string cid,string compn)
        {
            empId = eid;
            empname = empn;
            age = a;
            salary = s;
            compId = cid;
            compname = compn;

        }

      

        public void showEmployeeData()
        {
            Console.WriteLine("Employee ID is : " + empId);
            Console.WriteLine("Employee Name is : " + empname);
            Console.WriteLine("Employee Age is : " + age);
            Console.WriteLine("Employee Salary is : " + salary);

        }

        public void showCompData()
        {
            Console.WriteLine("Company ID is : " + compId);
            Console.WriteLine("Company Name is : " + compname);
            Console.ReadLine();

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Organisation org1 = new Organisation(01,"James","24",20000.0,"0001A","XYZ");
            Organisation org2 = new Organisation(02, "Ronald", "26", 30000.0, "0001A", "XYZ");
            org1.showEmployeeData();
            org1.showCompData();
            org2.showEmployeeData();
            org2.showCompData();
        }
    }
}
