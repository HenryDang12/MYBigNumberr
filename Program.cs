using System;

namespace Testthuattoan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyBigNumber myBigNumber = new MyBigNumber();

                // Nhập số thứ nhất từ người dùng
                Console.Write("Nhập số thứ nhất: ");
                string str1 = Console.ReadLine();

                // Nhập số thứ hai từ người dùng
                Console.Write("Nhập số thứ hai: ");
                string str2 = Console.ReadLine();

                // Gọi phương thức sum để cộng hai số
                string result = myBigNumber.Sum(str1, str2);

                // In kết quả
                Console.WriteLine("Kết quả cộng: " + result);
            }
            catch (Exception ex)
            {
                // Bắt lỗi và in ra thông báo
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
