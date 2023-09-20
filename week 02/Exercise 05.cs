using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Exercise05 : MonoBehaviour
{

    private void Awake()
    {
        Player("플레이어 1", 1200);
        Player(health: 40, ID :"플레이어 2");//매개 변수명을 데이터와 함께 쓰므로 순서가 바뀌어도 됨
        //Player(40, "플레이어 2"); //이 코드는 에러가 남
        Player("플레이어 3"); // 기본값인 hp : 100이 출력될 것.
        Player(health: 104);//플레이어 이름이 기본값으로 나옴
        //Player(104);//불가능
        //Player();
    }
    public void Player(string ID="기본값", int health=100) // 값이 정해지지 않을 경우 기본값이 나옴.
    {
        Debug.Log($"ID : {ID}, Health : {health}");
    }
    //public void Player()
    //{
    //    Debug.Log("이름과 체력을 입력해 주세요");
    //}
    /* 가변 길이 매개변수
    int[] a = { 1, 2, 3 };
    Sum(3, 4, 2, 1, 5);
    Sum(a);
}
public void Sum(params int[] nums)
{
    int sum = 0;
    for(int i=0; i<nums.Length; i++)
    {
        sum += nums[i];
    }
    Debug.Log($"합계 : {sum}");
}
    */

    /* 메소드 오버로딩
    int Intnum1 = 5, Intnum2 = 4;
    float Floatnum1 = 2.3f, Floatnum2 = 1.4f;
    AddInt(Intnum1, Intnum2);
    AddFloat(Floatnum1, Floatnum2);

    Add(Intnum1, Intnum2);
    Add(Floatnum1, Floatnum2);//매개 변수의 데이터 형식에 따라 다른 메소드가 호출됨
}

public void AddInt(int num1, int num2) // int 두 개를 더하는 함수
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
public void AddFloat(float num1, float num2) // float 두 개를 더하는 함수
{
    float result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

public void Add(int  num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
public void Add(float num1, float num2) // 메소드 오버로딩
{
    float result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
    */

    /* 두 개의 출력을 하는 함수
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, ref result1, ref result2);
    Debug.Log($"몫 = {result1}, 나머지 = {result2}");

    Divide2(a,b,out result1,out result2);
    Debug.Log($"몫 = {result1}, 나머지 = {result2}");


}
//두 개의 ref를 받아 두 가지의 출력을 함.
public void Divide(int num1, int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2;
    result2=num1 % num2;
}
//out 키워드를 사용하면 메소드 내부에서 결과를 저장하지 않을 경우 컴파일 에러가 남
public void Divide2(int num1, int num2, out int result1, out int result2)
{
    result1=num1 / num2;
    result2=num1 % num2; // 여기를 주석으로 할 경우 컴파일 에러
}
    */

    /* 값에 의한 전달과 참조에 의한 전달
    int a = 3, b = 4;
    Debug.Log($"Before a = {a}, b = {b}");
    Swap(a, b); // 함수 내부의 변수는 바뀌지만 기존 a,b는 바뀌지 않음.
    Debug.Log($"After a = {a}, b = {b}");

    Debug.Log($"Before a = {a}, b = {b}");
    Swap2(ref a, ref b); // 값이 바뀐다.
    Debug.Log($"After a = {a}, b = {b}");
}
public void Swap(int a,int b) // 값에 의한 전달
{
    int temp = a;
    a = b;
    b = temp;
}
public void Swap2(ref int a,ref int b) // 참조에 의한 전달
{
    int temp = a; // a와 b는 메소드 외부의 변수와 값을 공유한다.
    a = b;
    b = temp;
}
    */

    /* 메소드
    Debug.Log($"20 x 3 = {20 * 3}");
    Multiple(20, 3);

    int a = Max(10, 20);//변수의 결과로 사용할 수 있지만
    Debug.Log(Max(100, 200));//변수를 만들지 않고 바로 사용해도 된다
    Max(5, 10);//반환값이 필요 없을 경우 반환하지 않아도 된다.

    Divide(10, 3);
    Divide(2, 0);

}

public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
}

public int Max(int num1,int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    return num2;
}

public void Divide(int num1, int num2)
{
    if(num2==0)
    {
        Debug.Log("나누려는 값이 0이기 때문에 계산할 수 없습니다,");
        return;//그 자리에서 메소드를 빠져나간다.
    }
    float result = num1 / num2;
    Debug.Log($"{num1} / {num2} = {result}");
}
    */

}

/*
public class Calculator//클래스 선언
{
    public int Add(int num1, int num2)//메소드는 클래스 내부에 정의되어야 함.
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)//값을 반환하지 않는 메소드
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
}
*/
