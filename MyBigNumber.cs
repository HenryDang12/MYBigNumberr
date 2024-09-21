using System;
using System.Collections.Generic;
using System.Text;

namespace Testthuattoan
{
    public class MyBigNumber
    {
        
        public string Sum(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                throw new ArgumentException("Input strings cannot be null or empty");
            }

            // Đảm bảo chuỗi str1 luôn có độ dài lớn hơn hoặc bằng str2
            if (str1.Length < str2.Length)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
            }

            // Khai báo biến để lưu trữ các chữ số đã đảo ngược (cộng từ phải sang trái)
            char[] num1 = str1.ToCharArray();
            char[] num2 = str2.ToCharArray();
            Array.Reverse(num1);
            Array.Reverse(num2);

            int carry = 0; // Biến lưu số dư khi cộng vượt 10
            string result = ""; // Chuỗi để lưu kết quả tổng

            // Thực hiện phép cộng từng chữ số
            for (int i = 0; i < num1.Length; i++)
            {
                // Lấy giá trị của từng chữ số trong 2 chuỗi
                int digit1 = num1[i] - '0'; // Lấy chữ số từ chuỗi đầu tiên
                int digit2 = (i < num2.Length) ? num2[i] - '0' : 0; // Nếu chuỗi thứ hai ngắn hơn, coi như chữ số là 0

                // Cộng hai chữ số và thêm phần dư từ bước trước (carry)
                int sum = digit1 + digit2 + carry;
                carry = sum / 10; // Lấy phần dư nếu sum >= 10
                result += (sum % 10).ToString(); // Ghi lại chữ số ở vị trí hàng đơn vị
            }

            // Nếu còn phần dư thì thêm vào kết quả
            if (carry > 0)
            {
                result += carry.ToString();
            }

            // Đảo ngược lại chuỗi kết quả vì chúng ta đã đảo chuỗi ban đầu
            char[] finalResult = result.ToCharArray();
            Array.Reverse(finalResult);

            return new string(finalResult);
        }
    }
}
