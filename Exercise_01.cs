using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    private void Awake()
    {
        string stringValue = "초기화";
        int intValue = 33;
        float floatValue = 12.3456f;

        Debug.Log("stringValue : " + stringValue);

        //정수를 문자열로 형변환
        stringValue = intValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        //실수를 문자열로 형변환
        stringValue=floatValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        /* 문자열을 숫자로 형변환 II - TryParse()
        string stringValue = "나 숫자 아님";
        int intValue = 10;

        bool isconversion = int.TryParse(stringValue, out intValue);
        if (isconversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue 변수에 들어있는 숫자가 아니어서 형변환에 실패했습니다.");
        }
        */

        /* 문자열을 숫자로 형변환 I - Parse()
        //문자열에 숫자가 아닌 데이터가 있을 경우 숫자로 형변환하면 오류 발생
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        //33.4567 등 실수를 int로 형변환하면 에러 발생
        //stringValue = "33.4567";
        intValue=int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue=float.Parse(stringValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);
        */

        /* 부동소수점과 정수 사이의 형변환
        float floatValue = 0.9f;
        int intValue=(int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);
        */

        /* 부동 소수점 사이의 형변환
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue= (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);
        */

        /* 부호 있는 정수와 부호 없는 정수간의 형변환
        sbyte sbyteValue = 31;
        byte byteValue=(byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //부호 없는 정수가 음수일 때
        sbyteValue = -31;
        byteValue=(byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //부호 없는 정수가 부호 있는 정수 최대값보다 클 때
        byteValue = 200;
        sbyteValue=(sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);
        */

        /* 크기가 서로 다른 정수(int,sbyte)간의 형변환
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        //Sbyte가 최대 범위인 137을 초과할 경우 오버플로우 발생
        intValue = 130;                     // int     -2147483648 ~ 2147483647
        sbyteValue = (sbyte)intValue;       // sbyte   -128~127
            
        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);
        */

        /* 오브젝트 변수
        object ValueInt     = 31;                       //박싱(데이터 저장)
        object ValueFloat   = 3.1415926535f;            //박싱(데이터 저장)
        object ValueString  = "객체지향 프로그래밍";    //박싱(데이터 저장)
        object ValueBool    = false;                    //박싱(데이터 저장)

        Debug.Log("정수 : " + ValueInt);                //언박싱(데이터 사용)
        Debug.Log("실수 : " + ValueFloat);              //언박싱(데이터 사용)
        Debug.Log("문자열 : " + ValueString);           //언박싱(데이터 사용)
        Debug.Log("논리 : " + ValueBool);               //언박싱(데이터 사용)
        */

        /* 문자열과 논리
        string  stringValue     = "적당한 문장을 찾고 있어요";
        bool boolValue          = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);
        */

        /* 실수
        float   floatValue01 = 3.14159265358979323846264338279f; // 7자리 표현
        float   floatValue02 = 31.4159265358979323846264338279f; // 7자리 표현
        double  doubleValue  = 3.14159265358979323846264338279;  //15자리 표현
        decimal decimalValue = 3.14159265358979323846264338279m; //29자리 표현

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);
        */

        /* 정수
        sbyte   byteValue    = -128;                    // -128 ~ 127
        byte    ubyteValue   = 255;                     // 0 ~ 255
        short   shortValue   = -32768;                  // -32768 ~ 32767
        ushort  ushortValue  = 65535;                   // 0 ~ 65535
        int     intValue     = -2147483648;             // -2147483648 ~ 2147483647
        uint    uintValue    = 4294967295;              // 0 ~ 4294967295
        long    longValue    = -922337203685477508;     // -92233203685477508 ~ 92233203685477507
        ulong   ulongValue   = 18446744073709551615;    // 0 ~ 18446744073709551615
        char    charValue    = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data : " + charValue);
        */
    }
}
