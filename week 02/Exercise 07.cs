using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Cache;
using System.Runtime.CompilerServices;


public class Exercise07 : MonoBehaviour 
{

    private void Awake()
    {
        Player player = new Player()
        {
            ID = "유니티",
            Shield = 50,
            Defense = 10,

        };

        Debug.Log($"{player.ID}");
        Debug.Log($"Shield = {player.Shield}, Defense = {player.Defense}");
    }
}
public abstract class BaseEntity
{
    abstract public int Shield
    {//추상 프로퍼티의 get,set는 구현되지 않으므로 자식 클래스에서 재정의 해야한다.
        get;set;
    }
    public int Defense
    {//추상 프로퍼티가 아니므로 재정의하지 않아도 된다.
        get; set;
    }
}

public class Player : BaseEntity
{
    public override int Shield { get; set; }
    public string ID
    {
        get;set;
    }
}

/* 인터페이스의 프로퍼티
interface IBaseEntity
{
    //인터페이스의 get,set는 자동 구현이 아니므로 자식 클래스에서 재정의해야 한다.
    string ID { get; set; }
    int Damage { get; set; }
    int CurrentHP { get; set; }
}

public class Player : IBaseEntity
{
    private string id;
    public string ID
    {
        get => id;
        set=> id = value;
    }
    //아래는 자동 구현 프로퍼티
    public int Damage { get; set; }
    public int CurrentHP { get; set; } 
}
*/

/* 프로퍼티
public class Exercise07:MonoBehaviour
{
    void Awake()
    {
        Player player = new Player();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
        player.CurrentHP = -100;
        Debug.Log($"Player HP : {player.CurrentHP}");

        player.WRITEONLY = 4;
        //player.READONLY = 1;//읽기 전용 프로퍼티에는 쓸 수 없고,
        //Debug.Log(player.WRITEONLY);//쓰기 전용 프로퍼티는 읽을 수 없다.

        //CS1922 오류가 발생한다.
        //Player player1 = new Player()
        //{
        //    player1.ID = "유니티",
        //    player1.CurrentHP = 100
        //};
        //
        //Debug.Log($"{player1.ID} HP : {player1.CurrentHP}");
    }
}
public class Player
{
    private int currentHP;
    private int ReadOnly;
    private int WriteOnly;
    private int PrivateProp;
    public int CurrentHP//프로퍼티 선언.
    {
        get => currentHP;//이 접근자는 멤버 변수로부터 값을 읽어온다
        set//이 접근자는 멤버 변수에 값을 할당한다
        {
            if (currentHP > 0)
            {
                currentHP = value;//set 접근자의 암묵적 매개변수
            }
            else
            {
                currentHP = 0;
            }
        }
    }
    public string ID//자동 구현 프로퍼티. 변수의 이름은 컴파일러가 자동으로 생성한다.
    {//그러므로 변수의 이름은 컴파일러만 알며, 변수에 접근하기 위해서는 ID 프로퍼티를 사용해야 한다.
        get;set;//암묵적으로 get와 set를 만들어준다.
    }

    public int READONLY
    {
        get => ReadOnly;//get만 있는 경우 이 변수는 읽기 전용이 된다.
    }

    public int WRITEONLY
    {
        set => WriteOnly = value; // set만 있는 경우 이 변수는 쓰기 전용이 된다.
    }

    public int PRIVATEPROP
    {
        private set => PrivateProp = value;
        get => PrivateProp;//이때는 클래스 외부에서 set에 접근할 수 없지만 내부에서는 접근할 수 있다.
    }
}
*/

/* public의 멤버 변수의 유혹과 은닉
public class Exercise07
{
    private void Awake()
    {
        Player player=new Player();
        player.currentHP = 100;
        Debug.Log($"Player HP : {player.currentHP}");

        Player2 player2 = new Player2();
        //player2.currentHP= 100;//private로 지정되었으므로 직접 접근할 수 없다.
        player2.SetCurrentHP( 100 );
        Debug.Log($"Player HP : {player2.GetCurrentHP()}");
    }
}

public class Player
{
    //변수 은닉을 신경쓰지 않으면 변수에 이상한 값이 들어갈 수 있다.
    //하지만 변수 은닉을 지키기는 번거로우므로 public를 쓰고 싶다.
    public int currentHP;
}

public class Player2
{
    private int currentHP;//멤버 변수를 private로 선언 후 get,set 메소드를 작성한다.
    public int GetCurrentHP() { return currentHP; }//Get() 멤버 함수
    public void SetCurrentHP(int hp) { currentHP = hp; }//Set() 멤버 함수
}
*/

/* 네임스페이스
//이름공간에 있는 클래스, 구조체 사용
using MySpace;
//하지만 같은 이름의 클래스가 있는 구조체를 동시에 사용할 경우
//using YourSpace; // 이름 중복으로 Player player01에 오류가 발생한다.
public interface Exercise07
{
    private void Awake()
    {
        //MySpace에 정의된 Player 사용(using Myspace)
        Player player01;
        //YourSpace에 정의된 Player 사용
        YourSpace.Player player02;
    }
}

//이름공간 선언
namespace MySpace
{
    public class Player
    {
        //...
    }
}

//이름공간 선언
namespace YourSpace
{
    public class Player
    {
        //...
    }
}
*/

/* 확장 메소드
public class Exercise07 : MonoBehaviour
{
    private void Awake()
    {
        string str = "안녕하세요";
        str.PrintData();
    }
}

//string 클래스에 PringData() 메소드를 추가하기
public static class StringExtension
{
    //첫번째 매개변수는 확장하려 하는 대상
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
*/

/* 정적 (static)
public class Exercise07 : MonoBehaviour
{
    private void Awake()
    {
        //static 메소드 호출
        Enemy.StaticRun();

        Enemy enemy = new Enemy();
        int i = enemy.InstanceRun();
        //int i= enemy.StaticRun();//Static 메소드는 new로 만들어진 클래스 객체에서 호출할 수 없다.

        //instance 변수 사용
        Enemy enemy2= new Enemy();
        enemy.numeric = 9;
        enemy2.numeric = 10;

        Debug.Log(enemy.numeric);
        Debug.Log(enemy2.numeric);

        //static 변수 사용

        Enemy.species = "슬라임";
        Debug.Log(Enemy.species);

        //static 클래스의 메소드 호출
        Debug.Log(Calculator.Sum(20, 30));
        //static 클래스의 변수 사용
        Debug.Log(Calculator.num);
    }
}
public class Enemy 
{
    //instance 변수
    public int numeric;
    //static 변수
    public static string species;

    //instance 메소드
    public int InstanceRun() { return 1; }
    //static 메소드
    public static int StaticRun()
    {
        //InstanceRun();//호출할 수 없음
        return 1;
    }
}

//정적 클래스
public static class Calculator
{
    public static int num;
    //public int num2;//static 클래스는 모든 멤버가 static이어야 한다.

    //static 생성자
    //static 클래스는 객체를 생성할 수 없으므로 public 생성자를 가질 수 없다.
    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
*/

/* 튜플
public class Exercise07 : MonoBehaviour
{
    private void Awake()
    {
        var a = ("유니티", 35);
        Debug.Log($"{a.Item1}, {a.Item2}");//튜플의 요소는 Item으로 접근한다.

        a.Item2 = 36;
        Debug.Log($"{a.Item1}, {a.Item2}");

        var b = (Name: "유니티", Age: 23);//튜플 내부 변수에는 이름을 지정할 수 있다.
        Debug.Log($"{b.Name}, {b.Age}");

        var (name, newage) = b;//튜플을 분해해서 특정 변수에 저장할 수 있다.
        Debug.Log($"{name}, {newage}");

        var (newname, _) = b; //튜플 분해 시 _를 사용하면 특정 변수를 무시할 수 있다.
        //Debug.Log($"{newname}, {age}");//여기서 나이 필드를 무시했기 때문에 age를 사용할 수 없다.
    }
}
*/

/* 구조체
public class Exercise07 : MonoBehaviour
{
    private void Awake()
    {
        Stats player01= new Stats();//new를 붙일 경우 기본 생성자를 이용해 내부 변수를 초기화해준다.(0,null로)
        Stats player02;//new를 붙이지 않는다면 초기화되지 않은 채로 선언된다.

        player02.ID = "유니티";
        player02.CurrentHP = 10000;
        player02.damage = 9;

        Debug.Log($"{player01.ID}, 체력 : {player01.CurrentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, 체력 : {player02.CurrentHP}, 공격력 : {player02.damage}");
    }
}
public struct Stats // 구조체.
{
    public string ID;
    public int CurrentHP;
    public int damage;
}
*/

/* 분할 클래스 */
//partial Keyword를 사용하여 클래스를 분할할 수 있다.
//다음 클래스는 Exercise 06과 분할되어 있음.
public partial class PartClass
{
    public void CounterAttack() { }
}

/* 중첩 클래스
public class OuterClass
{
    public class InnerClass
    {
        //클래스는 중첩하여 사용할 수 있다.
    }
}
*/

/* 오버라이딩 봉인(sealed)
public class Entity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}

public class MovingEntity : Entity
{
    public override void TakeDamage(int damage)
    {
        //base.TakeDamage(damage);와 동일
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
    
    //public sealed override void TakeDamage(int damage)
    //{
    //    Debug.Log($"Entity : {damage}만큼 체력 감소");
    //}
    //이 경우 위 함수와 달리 Player에서 TakeDamage를 오버라이딩할 수 없어 오류 발생
    //sealed는 virtual로 선언된 가상 메소드만 봉인 가능
}

public class Player : MovingEntity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}
*/

/* 메소드 숨기기
public class Exercise07 : MonoBehaviour
{
    void Awake()
    {
        Parent p=new Parent();
        p.Method01();

        Child c=new Child();
        c.Method01();//이때 부모 클래스의 Method01을 숨긴다.

        Parent pc=new Child();
        pc.Method01();
    }
}
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public new void Method01()//자식클래스에서 구현한 메소드를 보여주기 위해
    {//부모 클래스의 Method01을 감춤.
        Debug.Log("Child");
    }
}
*/
