using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;
        public int NodeCount = 0;

        //Method for create a position
        public void CreatePosition(
            PositionNode parent, 
            Position positionToCreate, 
            string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if(Root == null)
            {
                Root = newNode;
                return;
            }

            if(parent == null)
            {
                return;
            }

            if(parent.Position.Name == parentPositionName)
            {
                if(parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }
        
        //Method for print tree
        public void PrintTree(PositionNode from)
        {
            if(from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary} : {from.Position.Taxes}%");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        //Method for count nodes
        public int CountNode(PositionNode from)
        {
            if (from != null)
            {
                NodeCount++;
                CountNode(from.Left);
                CountNode(from.Right);
            }
            return NodeCount;
        }

        //Method for Longest Salary
        float TotalSalaryLeft = 0;
        float TotalSalaryRight = 0;
        public void LongestSalary(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            else
            {
                TotalSalaryLeft = from.Left.Position.Salary + AddSalaries(from.Left.Left) + AddSalaries(from.Left.Right);
                TotalSalaryRight = from.Right.Position.Salary + AddSalaries(from.Right.Left) + AddSalaries(from.Right.Right);
                if (TotalSalaryLeft > TotalSalaryRight)
                {
                    Console.WriteLine($"The longest Salary is of the position {from.Left.Position.Name} and the sumatory is: ${TotalSalaryLeft}");
                }
                else
                {
                    Console.WriteLine($"The longest Salary is of the position {from.Right.Position.Name} and the sumatory is: ${TotalSalaryRight}");
                }
            }                 
        }

        //Method for highest salary
        float HighSalary = 0;
        public float HighestSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Salary > HighSalary)
            {
                HighSalary = from.Position.Salary;              
            }
            if(from.Position.Name == "Rector")
            {
                HighSalary = 0;
            }
            HighestSalary(from.Left);
            HighestSalary(from.Right);
            
            return HighSalary;
        }
        
        //Method for average salaries
        public float AverageSalaries(PositionNode from)
        {
            if(from == null)
            {
                return 0;
            }

            float average = ((from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right)) / NodeCount);
            return average;
        }

        //Method for print salary for specific position
        public void PrintSalary(Position from)
        {
            if (from == null)
            {
                return;
            }
            Console.WriteLine($"The salary of the position {from.Name} is ${from.Salary}");
        }

        //Method for total salaries
        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);
        }

        //Method for taxes
        public float AddTaxes(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            float moneyTaxes = (from.Position.Salary * from.Position.Taxes)/100;
            return moneyTaxes + AddTaxes(from.Left) + AddTaxes(from.Right);
        }
    }
}