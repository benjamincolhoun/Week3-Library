﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;


        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } 
        }
        public string Name
        {
            get { return name; }  
            set { name = value; } 
        }
        public string Address
        {
            get { return address; }  
            set { address = value; } 
        }
        public int Phone
        {
            get { return phone; } 
            set { phone = value; } 
        }

        
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"memberId: {memberId}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"address: {address}");
            Console.WriteLine($"phone: {phone}");
            Console.WriteLine();
        }
    }
}