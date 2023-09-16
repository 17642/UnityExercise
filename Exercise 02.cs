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

        //이진수 형태로 출력
        Debug.Log(Convert.ToString(a >> 4, 2));

        //논리곱 연산자 &
        Debug.Log($"10 & 6 = {10 & 6}");

        //논리합 연산자 |
        Debug.Log($"10 | 6 = {10 | 6}");

        //배타적 논리합 연산자 ^
        Debug.Log($"10 ^ 6 = {10 ^ 6}");

        //보수 연산자 ~
        Debug.Log($"~10 = {~10}");


        /* 논리 연산자, 조건 연산자
        bool result=false;
        int x = 5, y = 2;

        // && 연산자 (두 조건이 모두 참일 때만 참)
        result = x > 2 && y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        // || 연산자 (두 조건이 모두 거짓일 때에만 거짓)
        result = x < 4 || y == 5;
        Debug.Log($"{x} < 4 || {y} == 5 = {result}");

        // ! 연산자 ( 참 -> 거짓, 거짓 -> 참);
        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        //조건(삼항) 연산자
        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("체력 : " + hp);
        */

        /* 비교 연산자
        int x = 5, y = 2;

        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");
        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");
        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
        */

        /* 증감 연산자
        int a = 10;
        Debug.Log(a);

        a++;            // 후위 증가 연산자
        Debug.Log(a);

        ++a;            // 전위 증가 연산자
        Debug.Log(a);

        Debug.Log(a++); // Debug.Log() 실행 후 a 값 증가
        Debug.Log(a);
        Debug.Log(++a); // a 값 증가 후 Debug.Log() 실행
        Debug.Log(a);
        */

        /* 대입(할당) 연산자
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : 결과 값 {a}");

        //문자열 보간의 보간식에 수신을 넣어서 연산
        Debug.Log($"a -= 9 : 결과 값 {a -= 9}");
        Debug.Log($"a *= 8 : 결과 값 {a *= 8}");
        Debug.Log($"a /= 7 : 결과 값 {a /= 7}");
        Debug.Log($"a %= 6 : 결과 값 {a %= 6}");
        Debug.Log($"a &= 5 : 결과 값 {a &= 5}");
        Debug.Log($"a |= 4 : 결과 값 {a |= 4}");
        Debug.Log($"a ^= 3 : 결과 값 {a ^= 3}");
        Debug.Log($"a <<= 2 : 결과 값 {a <<= 2}");
        Debug.Log($"a >>= 1 : 결과 값 {a >>= 1}");
        */

        /* 산술 연산자
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

        /* 문자열 분할
        string position = "3, 5, 6";
        // Split()를 이용해 문자열을 분할하면 분할한 개수만큼 배열에 저장
        // 쉼표를 기준으로 분할
        string[] str=position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD!";
        //7번째 위치부터 뒤에 있는 문자열만 다시 저장
        str2 = str2.Substring(7);
        Debug.Log(str2);
        */

        /* 문자열 변형
        string str = "Hello, World";
        Debug.Log(str);

        str=str.ToLower();                      // 대문자 -> 소문자
        Debug.Log($"ToLower() - {str}");

        str=str.ToUpper();                      // 소문자 -> 대문자
        Debug.Log($"ToUpper() - {str}");

        str = str.Insert(0, "Hi~ ");             // 원하는 위치에 문자열 삽입
        Debug.Log($"Insert() - {str}");

        str = str.Remove(0, 4);                 // 원하는 위치의 문자열 삭제
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");
        //공백 추가
        str = "     " + str + "     ";
        Debug.Log(str + "공백 체크");

        str = str.Trim();                       // 문자열의 앞, 뒤 공백 제거
        //str = str.TrimStart();                // 문자열의 앞 공백 제거
        //str = str.TrimEnd();                   // 문자열의 뒤 공백 제거
        Debug.Log(str + "공백 체크");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");      //HELLO 문자열을 BYE 문자열로 대체
        Debug.Log($"After Replace : {str}");
        */

        /* 문자열 탐색
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf("o");
        Debug.Log($"o는 앞에서부터 {numeric + 1}번째에 있습니다.");

        numeric = str.LastIndexOf("o");
        Debug.Log($"o는 뒤에서부터 {numeric}번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} 문장은 World부터 시작한다? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 Hello로 끝난다? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 World로 끝난다? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} 문장엔 Hell이 포함되어 있다? {isTrue}");
        */

        /* string.Format() vs 문자열 보간
        int minutes = 1;
        int seconds = 15;

        //string.Format()
        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));
        //문자열 보간
        Debug.Log($"{minutes} : {seconds}");

        //string.Format()
        Debug.Log(string.Format("{0,-10:D5}", minutes));
        //문자열 보간
        Debug.Log($"{minutes,10:D5}");
        */

        /* string.Format()를 이용한 문자열 가공
        int minutes = 1;
        int seconds = 15;

        //서식 항목 - 맞춤
        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0, 5}{1}{2}", minutes, ":", seconds));

        //서식 항목 - 서식 문자열 설정(숫자)

        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : {0:X10}", 0x00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

        //서식 문자열 설정(날짜)
        // DateTime 구조체를 사용하려면 using System; 추가
        DateTime dt = new DateTime(2023, 09, 15, 15, 42, 30);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)");
        Debug.Log(str);
        */
    }
}

