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
        public void ShowSinhVien(List<SinhVien> ListSV){
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} ",
                  "Fist Name", "Last Name", "Gender", "Date Of Birth", "Phone Number", "Birth Place", "Age", "Is Guaduated");
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} ",
                                      sv.fistName, sv.lastName, sv.gender, sv.dateOfBirth, sv.phoneNumber, sv.birthPlace, sv.age,
                                      sv.duaduated);
                }
            }
            Console.WriteLine();
        }

    }
    public List<SinhVien> getListSinhVien(){
        return ListSinhVien;
    }
    class program{
        static void Main(string[] args){
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            while(true){
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Hien thi danh sach sinh vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                 switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        quanLySinhVien.NhapSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;
                    case 2:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }




}
