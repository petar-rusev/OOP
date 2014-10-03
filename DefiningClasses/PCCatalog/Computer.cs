using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PCCatalog
{
    class Computer
    {
        private string ComputerName;
        private double price;
        private List<Components>components=new List<Components>();
        public string Name
        {
            get
            {
                return this.ComputerName;
            }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid copmuter name argument. The computer name must not be empty string!");
                }
                else
                {
                    this.ComputerName = value;
                }
            }
        }
        public double CompPrice
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Invalid copmuter name argument. The computer name must not be empty string!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public List<Components>comps
        {
            get
            {
                return this.components;
            }
            set
            {
                this.components = value;
            }
        }
        public static  List<List<String>> ComponentsData(List<Components>CompList)
        {
            
            List<String>ComponentData=new List<String>();
            Components[]arrComp=CompList.ToArray();
            string temp = "";
            for (int i = 0; i < arrComp.Length; i++)
            {
                temp += arrComp[i].ComponentName+"\n";
                if (arrComp[i].CompDetails != null && string.IsNullOrEmpty(arrComp[i].CompDetails))
                {
                    temp += arrComp[i].CompDetails+"\n";
                }
                else
                {
                    temp += arrComp[i].ComponentPrice+"\n";
                }
                ComponentData.Add(temp);
                temp = "";
                
            }
            string pat=@"[^\n]+";
            Regex reg=new Regex(pat);
            //Match match=reg.Match()
            List<String>data=new List<String>();
            string []arrCompData=ComponentData.ToArray();
            
            for (int i = 0; i < arrCompData.Length; i++)
            {
                MatchCollection mc = Regex.Matches(arrCompData[i],pat);
                foreach (Match m in mc)
                {
                    data.Add(m.ToString()+"\n");
                }

            }
            string []res=data.ToArray();
            
            List<String>elems=new List<String>();
            List<String>prices=new List<String>();
            for(int i=0;i<res.Length;i++)
            {

                if (i % 2 != 0)
                {
                    prices.Add(res[i]);

                }
                else
                {
                    elems.Add(res[i]);
                }
            }
            List<List<String>> final = new List<List<String>>();
            final.Add(elems);
            final.Add(prices);
            return final;
            }
       
        public Computer(string name, double price,List<Components>Components)
        {
            this.Name = name;
            this.CompPrice = price;
            this.components = Components;
        }
        public static void Display(string name,double price,List<String> one, List<String> two)
        {
            Console.WriteLine("Computer: {0}\nPrice: {1}\n---------------------------------------",name,price);
            double overallPrice = 0;
            for (int i = 0; i < one.Count; i++)
            {
                Console.WriteLine("Component: {0}"+"Price: {1}",one[i],two[i]);
                overallPrice += double.Parse(two[i]);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("The overall price of the components if you buy them separately is: {0}",overallPrice);
        }
       
    }
}
