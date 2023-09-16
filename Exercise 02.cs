using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    private void Awake()
    {
        int a = 3;                              // 0000 0011

        Debug.Log($"{a} << 1 = {a << 1}");      // 0000 0110 = 6
        Debug.Log($"{a} << 2 = {a << 2}");      // 0000 1100 = 12
        Debug.Log($"{a} << 3 = {a << 3}");      // 0001 1000 = 24
        Debug.Log($"{a} << 4 = {a << 4}");      // 0011 0000 = 48

        a = 255;                                // 1111 1111
        Debug.Log($"{a} >> 1 = {a >> 1}");      // 0111 1111 = 127
        Debug.Log($"{a} >> 2 = {a >> 2}");      // 0011 1111 = 63
        Debug.Log($"{a} >> 3 = {a >> 3}");      // 0001 1111 = 31
        Debug.Log($"{a} >> 4 = {a >> 4}");      // 0000 1111 = 15

        a = -255;                               // 0000 0001
        Debug.Log($"{a} >> 1 = {a >> 1}");      // 1000 0000 = -128
        Debug.Log($"{a} >> 2 = {a >> 2}");      // 1100 0000 = -64
        Debug.Log($"{a} >> 3 = {a >> 3}");      // 1110 0000 = -32
        Debug.Log($"{a} >> 4 = {a >> 4}");      // 1111 0000 = -16

        //������ ���·� ���
        Debug.Log(Convert.ToString(a >> 4, 2));

        //���� ������ &
        Debug.Log($"10 & 6 = {10 & 6}");

        //���� ������ |
        Debug.Log($"10 | 6 = {10 | 6}");

        //��Ÿ�� ���� ������ ^
        Debug.Log($"10 ^ 6 = {10 ^ 6}");

        //���� ������ ~
        Debug.Log($"~10 = {~10}");


        /* �� ������, ���� ������
        bool result=false;
        int x = 5, y = 2;

        // && ������ (�� ������ ��� ���� ���� ��)
        result = x > 2 && y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        // || ������ (�� ������ ��� ������ ������ ����)
        result = x < 4 || y == 5;
        Debug.Log($"{x} < 4 || {y} == 5 = {result}");

        // ! ������ ( �� -> ����, ���� -> ��);
        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        //����(����) ������
        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("ü�� : " + hp);
        */

        /* �� ������
        int x = 5, y = 2;

        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");
        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");
        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
        */

        /* ���� ������
        int a = 10;
        Debug.Log(a);

        a++;            // ���� ���� ������
        Debug.Log(a);

        ++a;            // ���� ���� ������
        Debug.Log(a);

        Debug.Log(a++); // Debug.Log() ���� �� a �� ����
        Debug.Log(a);
        Debug.Log(++a); // a �� ���� �� Debug.Log() ����
        Debug.Log(a);
        */

        /* ����(�Ҵ�) ������
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : ��� �� {a}");

        //���ڿ� ������ �����Ŀ� ������ �־ ����
        Debug.Log($"a -= 9 : ��� �� {a -= 9}");
        Debug.Log($"a *= 8 : ��� �� {a *= 8}");
        Debug.Log($"a /= 7 : ��� �� {a /= 7}");
        Debug.Log($"a %= 6 : ��� �� {a %= 6}");
        Debug.Log($"a &= 5 : ��� �� {a &= 5}");
        Debug.Log($"a |= 4 : ��� �� {a |= 4}");
        Debug.Log($"a ^= 3 : ��� �� {a ^= 3}");
        Debug.Log($"a <<= 2 : ��� �� {a <<= 2}");
        Debug.Log($"a >>= 1 : ��� �� {a >>= 1}");
        */

        /* ��� ������
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        //Debug.Log(a + " = 5 + 6");
        Debug.Log($"{a} = 5 + 6");
        Debug.Log($"{b} = {a} - 3");
        Debug.Log($"{c} = {a} * {b}");
        Debug.Log($"{d} = {c} / 8");
        Debug.Log($"{e} = {d} % 4");
        */

        /* ���ڿ� ����
        string position = "3, 5, 6";
        // Split()�� �̿��� ���ڿ��� �����ϸ� ������ ������ŭ �迭�� ����
        // ��ǥ�� �������� ����
        string[] str=position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD!";
        //7��° ��ġ���� �ڿ� �ִ� ���ڿ��� �ٽ� ����
        str2 = str2.Substring(7);
        Debug.Log(str2);
        */

        /* ���ڿ� ����
        string str = "Hello, World";
        Debug.Log(str);

        str=str.ToLower();                      // �빮�� -> �ҹ���
        Debug.Log($"ToLower() - {str}");

        str=str.ToUpper();                      // �ҹ��� -> �빮��
        Debug.Log($"ToUpper() - {str}");

        str = str.Insert(0, "Hi~ ");             // ���ϴ� ��ġ�� ���ڿ� ����
        Debug.Log($"Insert() - {str}");

        str = str.Remove(0, 4);                 // ���ϴ� ��ġ�� ���ڿ� ����
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");
        //���� �߰�
        str = "     " + str + "     ";
        Debug.Log(str + "���� üũ");

        str = str.Trim();                       // ���ڿ��� ��, �� ���� ����
        //str = str.TrimStart();                // ���ڿ��� �� ���� ����
        //str = str.TrimEnd();                   // ���ڿ��� �� ���� ����
        Debug.Log(str + "���� üũ");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");      //HELLO ���ڿ��� BYE ���ڿ��� ��ü
        Debug.Log($"After Replace : {str}");
        */

        /* ���ڿ� Ž��
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf("o");
        Debug.Log($"o�� �տ������� {numeric + 1}��°�� �ֽ��ϴ�.");

        numeric = str.LastIndexOf("o");
        Debug.Log($"o�� �ڿ������� {numeric}��°�� �ֽ��ϴ�.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} ������ Hello���� �����Ѵ�? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} ������ World���� �����Ѵ�? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} ������ Hello�� ������? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} ������ World�� ������? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} ���忣 Hell�� ���ԵǾ� �ִ�? {isTrue}");
        */

        /* string.Format() vs ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        //string.Format()
        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));
        //���ڿ� ����
        Debug.Log($"{minutes} : {seconds}");

        //string.Format()
        Debug.Log(string.Format("{0,-10:D5}", minutes));
        //���ڿ� ����
        Debug.Log($"{minutes,10:D5}");
        */

        /* string.Format()�� �̿��� ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        //���� �׸� - ����
        Debug.Log(string.Format("�⺻ : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("���� ���� : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("������ ���� : {0, 5}{1}{2}", minutes, ":", seconds));

        //���� �׸� - ���� ���ڿ� ����(����)

        Debug.Log(string.Format("10���� ����ȭ : {0:D}", 123));
        Debug.Log(string.Format("10���� ����ȭ(5�ڸ�) : {0:D5}", 123));

        Debug.Log(string.Format("16���� ����ȭ : {0:X}", 0x00));
        Debug.Log(string.Format("16���� ����ȭ(10�ڸ�) : {0:X10}", 0x00));

        Debug.Log(string.Format("�����Ҽ��� ����ȭ : {0:F}", 1.23));
        Debug.Log(string.Format("�����Ҽ��� ����ȭ(�Ҽ��� 1�ڸ�) : {0:F1}", 1.23));

        Debug.Log(string.Format("�޸��� ���� : {0:N}", 1234567890));
        Debug.Log(string.Format("���� : {0:E}", 1234567890));

        //���� ���ڿ� ����(��¥)
        // DateTime ����ü�� ����Ϸ��� using System; �߰�
        DateTime dt = new DateTime(2023, 09, 15, 15, 42, 30);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)");
        Debug.Log(str);
        */
    }
}

