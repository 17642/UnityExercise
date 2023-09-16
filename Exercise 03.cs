using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise03 : MonoBehaviour
{
    [SerializeField] //  Inspector View에서 멤버 변수 값 설정 가능
    private int x = 10;
    // Start is called before the first frame update
    private void Awake()
    {
        int[][] array = new int[3][];

        array[0] = new int[3] {1,2,3};
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400, 500 };

        for(int i = 0; i < array.Length; i++)
        {
            for(int j=0; j < array[i].Length; j++)
            {
                Debug.Log($"[{i}][{j}] = {array[i][j]}");
            }
        }

        /* 배열
        int[] enemys = new int[5];

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($"배열의  기본 타입 : {enemys.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");
        for(int index = 0; index < enemys.Length; index++)
        {
            //using System에도 Random 클래스가 있기 떄문에
            //앞에 UnityEngine 이름공간을 붙여준다.
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }
        
        Array.Sort( enemys );       //매개변수로 사용한 enemys를 정렬

        Debug.Log("== 정렬 후 ==");
        for (int index = 0; index < enemys.Length; index++)
        {
            Debug.Log(enemys[index]);
        }

        Debug.Log($"Dimensions : {enemys.Rank}"); // 배열의 차원
        */

        /* 반복문 While
        int result = 0;
        int index  = 1;

        while (index <= 100)
        {
            result += index;

            index++;
        }

        Debug.Log($"1부터 100까지의 합은 {result}");
        */

        /* 반복문 for
        // For 반복문에서 사용하는 index 변수는
        // 반복문 내부에서 선언된 지역 변수로 취급되어
        // 반복문이 종료되면 데이터가 사라진다.
        for(int index=0;index<10;++index)
        {
            Debug.Log(index);
        }

        //조건문과 마찬가지로 반복문도 중첩할 수 있다.
        for(int x = 1; x < 10; ++x)
        {
            for(int y= 1; y < 10; y++)
            {
                Debug.Log($"{x} * {y} = {x * y}");
            }
        }
        */

        /* 조건문 switch - case
        x /= 10;

        switch (x)
        {
            case 10:
                Debug.Log("학점 : A+");
                break;
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;
            default:
                Debug.Log("학점 : F");
                break;
        }
        */

        /* 조건문 if else if else
        if (x >= 90)
        {
            Debug.Log("학점: A+");
        }else if (x >= 80) {
            Debug.Log("학점: B+");
        }else if(x >= 70)
        {
            Debug.Log("학점: C+");
        }else if(x >= 60)
        {
            Debug.Log("학점: D");
        }
        else
        {
            Debug.Log("학점: F");
        }
        */

        /* 조건문 if
        if (x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다.");
        }
        //조건문 내부에 여러 개의 조건식을 동시에 만족하도록 설정할 수 있다.
        if (x > 5 && x < 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다.");
        }
        //조건문 내부에 조건문을 중첩해서 작성할 수 있다,
        //위의 if문과 같은 결과를 출력할 것이다.
        if (x > 5)
        {
            if(x < 10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다.");
            }
        }
        Debug.Log($"x의 값은 {x}");
        */
    }
}

