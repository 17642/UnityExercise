using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.Mathematics;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    //반복문 문제
    private void Awake()
    {
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65 + y)}\t";
            for (int x = 0; x < y; x++)
            {
                sentence += " ";
            }
            for (int x = 0; x < 26 - y; x++)
            {
                sentence += (char)(65 + y + x/3);
            }

            Debug.Log(sentence);
        }

        /* Q18
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65 + y)}\t";
            for (int x = 0; x < 26 - y; x++)
            {
                sentence += (char)(65 + x / 3);
            }
            sentence += " ";
            for (int x = 0; x < 26 - y; x++)
            {
                sentence += (char)(65 + y + x);
            }
            Debug.Log(sentence);
        }
        */

        /* Q17
        for(int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65 + y)}\t";
            for (int x = 0; x < 26 - y; x++)
            {
                sentence += (char)(65 + x/3);
            }
            Debug.Log(sentence);
        }
        */

        /* Q16
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65 + y)}\t";
            for (int x = 0; x < y; x++)
            {
                sentence += "  ";
            }
            for (int x = 0; x < 26 - y*2; x++)
            {
                sentence += (char)(65 + y + x);
            }

            Debug.Log(sentence);
        }
        */

        /* Q15
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65 + y)}\t";
            for (int x = 0; x <26; x++)
            {
                sentence += (char)(65 + x);
                if (x == y)
                {
                    sentence += (char)(65 + x);
                }
            }

            Debug.Log(sentence);
        }
        *

        /* Q14
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65+y)}\t";
            for (int x = 0; x <= y; x++)
            {
                sentence += (char)(65 + x);
            }

            Debug.Log(sentence);
        }
        */

        /* Q13
        for (int y = 0; y < 26; y++)
        {
            string sentence = $"{(char)(65+y)}\t";
            for (int x = 0; x < y; x++)
            {
                sentence += " ";
            }
            for (int x = 0; x < 26-y; x++)
            {
                sentence += (char)(65 +y +x);
            }

            Debug.Log(sentence);
        }
        */

        /* Q12
        for (int y = 0; y < 26; y++)
        {
            string sentence = "";
            for(int x = 0; x < y; x++)
            {
                sentence += " ";
            }
            for (int x = 0; x <= y; x++)
            {
                sentence += (char)(65 + x);
            }

            Debug.Log(sentence);
        }
        */

        /* Q11
        for (int y = 0; y < 26; y++)
        {
            string sentence = "";
            for (int x = 0; x <= y; x++)
            {
                sentence += (char)(65 + y);
            }

            Debug.Log(sentence);
        }
        */

        /* Q10
        for(int y=0;y<26; y++)
        {
            string sentence = "";

            // 바깥쪽 반복문의 y값이 증가함에 따라 안쪽 반복문은 1,2...26번 실행되도록 한다.
            for(int x = 0; x <= y; x++)
            {
                //char형은 문자를 출력하는 타입으로
                //숫자 65를 char에 대입하면 대문자 'A'를 나타낼 수 있다.

                sentence += (char)(65 + x);
            }

            Debug.Log(sentence);
        }
        */

        /* Q9
        int num = 1;
        for (int i = 0; i < 9; i++)
        {
            string sentence = "";
            for (int j = 0; j < 5 - (num - 1) / 2 - 1; j++)
            {
                sentence += "★";
            }
            for (int j = 0; j < num; j++)
            {
                sentence += "☆";
            }
            for (int j = 0; j < 5 - (num - 1) / 2 - 1; j++)
            {
                sentence += "★";
            }
            if (i < 4)
            {
                num += 2;
            }
            else
            {
                num -= 2;
            }
            Debug.Log(sentence);
        }
        */

        /* Q8
        int num = 1;
        for(int i = 0; i < 9; i++)
        {
            string sentence = "";
            for (int j = 0; j < 5 - (num-1)/2-1; j++)
            {
                sentence += "☆";
            }
            for (int j = 0; j < num; j++)
            {
                sentence += "★";
            }
            for (int j = 0; j < 5 - (num - 1) / 2-1; j++)
            {
                sentence += "☆";
            }
            if (i < 4)
            {
                num += 2;
            }
            else
            {
                num -= 2;
            }
            Debug.Log(sentence);
        }
        */

        /* Q7
        int num = 1;
        for (int i = 0; i < 5; i++)
        {
            string sentence = "";
            for (int j = 0; j < 5 - i - 1; j++)
            {
                sentence += "☆";
            }
            for (int j = 0; j < num; j++)
            {
                sentence += "★";
            }
            for (int j = 0; j < 5 - i - 1; j++)
            {
                sentence += "☆";
            }
            num += 2;
            Debug.Log(sentence);
        }
        */

        /* Q6
        for (int y = 0; y < 5; y++)
        {
            string sentence = "";

            for (int x = 0; x <= y; x++)
            {
                sentence += "★";
            }
            for (int x = y + 1; x < 5; x++)
            {
                sentence += "☆";
            }
            for (int x = 0; x < 5 - y; x++)
            {
                sentence += "★";
            }
            for (int x = 0; x < y; x++)
            {
                sentence += "☆";
            }
            Debug.Log(sentence);
        }
            for (int y = 0; y < 5; y++)
            {
                string sentence = "";
                for (int x = 0; x < 5 - y - 1; x++)
                {
                    sentence += "☆";
                }
                for (int x = 0; x <= y; x++)
                {
                    sentence += "★";
                }
                for (int x = 0; x < y; x++)
                {
                    sentence += "☆";
                }
                for (int x = y + 1; x <= 5; x++)
                {
                    sentence += "★";
                }
                Debug.Log(sentence);
            }
        }
        */

        /* Q5
        for (int y = 0; y < 5; y++)
        {
            string sentence = "";

            for (int x = 0; x < y; x++)
            {
                sentence += "☆";
            }
            for (int x = y + 1; x <= 5; x++)
            {
                sentence += "★";
            }
            Debug.Log(sentence);
        }
        */

        /* Q4
        for (int y = 0; y < 5; y++)
        {
            string sentence = "";
            for (int x = 0; x < 5 - y-1; x++)
            {
                sentence += "☆";
            }
            for (int x = 0; x <= y; x++)
            {
                sentence += "★";
            }
            Debug.Log(sentence);
        }
        */

        /* Q3
        for(int y = 0; y < 5; y++)
        {
            string sentence = "";
            for(int x = 0; x < 5 - y; x++)
            {
                sentence += "★";
            }
            for(int x = 0; x < y; x++)
            {
                sentence += "☆";
            }
            Debug.Log(sentence);
        }
        */

        /* Q2
        //★☆

        for(int y = 0; y < 5; y++)
        {
            string sentence = "";

            for (int x = 0; x <= y; x++)
            {
                sentence += "★";
            }
            for(int x = y + 1; x < 5; x++)
            {
                sentence += "☆";
            }
            Debug.Log(sentence);
        }
        */

        /* Q1
        int result = 0;
        for (int index = 1; index <= 10; index++)
        {
            if (index % 3 != 0)
            {
                Debug.Log(index);
                result += index;
            }
        }

        Debug.Log($"1~10중 3으로 나누어 떨어지지 않는 수의 합: {result}");
        */
    }
}
