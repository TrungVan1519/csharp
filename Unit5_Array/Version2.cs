using System;
using System.Collections.Generic;
using System.Text;

namespace Unit5_Array
{
    class Version2
    {
        /* Chú ý:
        * - Ở phiên bản này ta tạo ra 1 mảng vs n phần tử và sử dụng hết n phần tử ( không giống trong Add_Elements_To_Array )
        * - Nên cách giải quyết ở đây là: Bắt buộc phải tạo ra 1 mảng mới vs số phần tử tăng thêm 1, sau đó copy mảng cũ vào và sử dụng các thuật toán thêm
        * - Không sử dụng cách giải quyết như trong Add_Elements_To_Array được vì array.Length là không thể thay đổi được, nên đã sử dụng hết rồi là không sử dụng đc nữa
        * - Còn bên Add_Elements_To_Array là ta khai bao thừa phần tử nên chỉ cần công số phần tử nhập lên 1 là có thể sử dụng đc bình thường
        * - Bài này khoai hơn 1 chút nhưng sẽ không phải gặp vấn đề về method Selection_Sort như phiên bản Add_Elements_To_Array :)))
        */
        public void Set_Value(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Get_Value(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0, 5}", a[i]);
            }
        }

        public void Copy_Array(int[] target_array, int[] original_array)
        {
            for (int i = 0; i < original_array.Length; i++)
            {
                target_array[i] = original_array[i];
            }
        }

        public void Selection_Sort(int[] a)
        {
            int i, j, tmp;
            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                    }
                }
            }
        }

        public void Add_Element(int[] a, int n, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (value < a[0])
                {
                    for (int j = n - 2; j >= 0; j--)
                    {
                        a[j + 1] = a[j];
                    }
                    a[0] = value;
                }

                else if (value <= a[i] && value > a[i - 1])
                {
                    for (int j = n - 2; j >= i; j--)
                    {
                        a[j + 1] = a[j];
                    }
                    a[i] = value;
                }

                else if (value > a[n - 2])
                {
                    a[n - 1] = value;
                }
            }
        }
    }
}
