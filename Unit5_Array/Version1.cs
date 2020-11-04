using System;
using System.Collections.Generic;
using System.Text;

namespace Unit5_Array
{
    class Version1
    {
        /* Chú ý:
        * - Phiên bản này dễ hơn so với Add_Elements_To_Array_Ver1 vì ta tạo mảng thừa phần tử nên khi muốn thêm số chỉ cần tăng số lượng phần tử nhập vào
        * - Không giống vs Add_Elements_To_Array_Ver1 khi ta dùng hết mảng rồi thì phải tạo mảng mới
        * - Nhưng ta sẽ gặp phải 1 vấn đề mà ở Add_Elements_To_Array_Ver1 sẽ k gặp là ở method Selection_Sort
        *   + Khi sắp xếp không được sử dụng array.Length 
        *   + Tại nếu sử dụng arr.Length thì ta sẽ sử dụng hết các phần tử thừa của mảng ( các phần tử thừa mặc định bằng 0 )
        *   + Tác hại nếu làm như thế thì khi muốn sắp xếp dãy tăng dần theo chiều tăng dần thì sẽ mất hết các số ta nhập 
        *   + VD: Dãy nhập: ( 1 4 2 4 || 0 0 0 0 ... 0 ) -> Sắp xếp ( 0 0 0 0 ... 0 || 1 2 4 4 )
        *   ==> Mất kết quả: Thực chất không phải mất mà là nó bị xếp ở cuối dãy nhưng ta lại chỉ in ra n phần tử đầu dãy
        */
        public void Set_Value(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Get_Value(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0, 5}", a[i]);
            }
        }

        public void Selection_Sort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }

        public void Add_Length(ref int n)
        {
            n++;
        }

        public void Add_Value(int[] a, int n, int value)
        {
            for (int i = 0; i < n; i++)
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
