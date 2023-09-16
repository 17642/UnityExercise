using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise01 : MonoBehaviour
{
    enum PlayerState
    { Idle, Move, Attack }
    private void Awake()
    {


        /* Nullable�� var
        //Nullable
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue);
        //Debug.Log(intValue.Value);// ���� intValue�� Null�̱� ������ ���� ��� �� ���� �߻�

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        //var

        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valueString = "���ڿ�";

        Debug.Log("���� : " + valueInt);
        Debug.Log("�Ǽ� : " + valueFloat);
        Debug.Log("���ڿ� : " + valueString);
        */

        /* �������� �̿��� �÷��̾� ���� ����
        PlayerState playerState = PlayerState.Move;

        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerState.Move:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerState.Attack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
        */

        /* ����� �̿��� �÷��̾� ���� ����
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int PlayerState = PlayerMove;

        switch (PlayerState)
        {
            case PlayerIdle:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerMove:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerAttack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
        */

        /* ���ڸ� ���ڿ��� ����ȯ - ToString()
        string stringValue = "�ʱ�ȭ";
        int intValue = 33;
        float floatValue = 12.3456f;

        Debug.Log("stringValue : " + stringValue);

        //������ ���ڿ��� ����ȯ
        stringValue = intValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        //�Ǽ��� ���ڿ��� ����ȯ
        stringValue=floatValue.ToString();
        Debug.Log("stringValue : " + stringValue);
        */

        /* ���ڿ��� ���ڷ� ����ȯ II - TryParse()
        string stringValue = "�� ���� �ƴ�";
        int intValue = 10;

        bool isconversion = int.TryParse(stringValue, out intValue);
        if (isconversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue ������ ����ִ� ���ڰ� �ƴϾ ����ȯ�� �����߽��ϴ�.");
        }
        */

        /* ���ڿ��� ���ڷ� ����ȯ I - Parse()
        //���ڿ��� ���ڰ� �ƴ� �����Ͱ� ���� ��� ���ڷ� ����ȯ�ϸ� ���� �߻�
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        //33.4567 �� �Ǽ��� int�� ����ȯ�ϸ� ���� �߻�
        //stringValue = "33.4567";
        intValue=int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue=float.Parse(stringValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);
        */

        /* �ε��Ҽ����� ���� ������ ����ȯ
        float floatValue = 0.9f;
        int intValue=(int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);
        */

        /* �ε� �Ҽ��� ������ ����ȯ
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue= (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);
        */

        /* ��ȣ �ִ� ������ ��ȣ ���� �������� ����ȯ
        sbyte sbyteValue = 31;
        byte byteValue=(byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //��ȣ ���� ������ ������ ��
        sbyteValue = -31;
        byteValue=(byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //��ȣ ���� ������ ��ȣ �ִ� ���� �ִ밪���� Ŭ ��
        byteValue = 200;
        sbyteValue=(sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);
        */

        /* ũ�Ⱑ ���� �ٸ� ����(int,sbyte)���� ����ȯ
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        //Sbyte�� �ִ� ������ 137�� �ʰ��� ��� �����÷ο� �߻�
        intValue = 130;                     // int     -2147483648 ~ 2147483647
        sbyteValue = (sbyte)intValue;       // sbyte   -128~127
            
        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);
        */

        /* ������Ʈ ����
        object ValueInt     = 31;                       //�ڽ�(������ ����)
        object ValueFloat   = 3.1415926535f;            //�ڽ�(������ ����)
        object ValueString  = "��ü���� ���α׷���";    //�ڽ�(������ ����)
        object ValueBool    = false;                    //�ڽ�(������ ����)

        Debug.Log("���� : " + ValueInt);                //��ڽ�(������ ���)
        Debug.Log("�Ǽ� : " + ValueFloat);              //��ڽ�(������ ���)
        Debug.Log("���ڿ� : " + ValueString);           //��ڽ�(������ ���)
        Debug.Log("�� : " + ValueBool);               //��ڽ�(������ ���)
        */

        /* ���ڿ��� ��
        string  stringValue     = "������ ������ ã�� �־��";
        bool boolValue          = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);
        */

        /* �Ǽ�
        float   floatValue01 = 3.14159265358979323846264338279f; // 7�ڸ� ǥ��
        float   floatValue02 = 31.4159265358979323846264338279f; // 7�ڸ� ǥ��
        double  doubleValue  = 3.14159265358979323846264338279;  //15�ڸ� ǥ��
        decimal decimalValue = 3.14159265358979323846264338279m; //29�ڸ� ǥ��

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);
        */

        /* ����
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
