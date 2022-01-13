using System;
using System.Collections.Generic;
namespace QLSinhVien{
    class SinhVien{
        public string fistName{get; set;}
        public string lastName{get; set;}
        public string gender{get;set;}
        public string dateOfBitrh{get;set;}
        public int phoneNumber{get; set;}
        public string birthPlace{get; set;}
        public int age{get;set;}
        public string graduated{get;set;}
    }
}

namespace BaiTapQLSinhVien
{
    class QuanLySinhVien
    {
        private List<SinhVien> ListSinhVien = null;
        public QuanLySinhVien(){
            ListSinhVien = new List<SinhVien>();
        }
        public void NhapSinhVien(){
            SinhVien sv = new SinhVien();
            Console.WriteLine("Fist Name: ");
            sv.fistName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Last Name: ");
            sv.lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Gender: ");
            sv.gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Date Of Birth: ");
            sv.dateOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Phone Number: ");
            sv.phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Place: ");
            sv.birthPlace = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Age: ");
            sv.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is Guaduated: ");
            sv.guaduated = Convert.ToString(Console.ReadLine());
            ListSinhVien.Add(sv);
        }


    }



}