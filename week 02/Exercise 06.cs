using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public partial class PartClass
{//이 클래스는 분할 클래스이다.
 //Exercise 07 파일과 Exercise 06 파일에 나누어서 분할되어 있다.
    public void TakeDamage(int damage)
    {
        //체력 감소
        //같은 클래스이므로 호출 가능
        CounterAttack();
    }
}

/*
public class Exercise06 : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;
    private IPerson player;

    private void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();
        player = new Player();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3(2, 5, 1));
        butterfly.MoveTo(new Vector3(1, 2, 5));
        player.MoveTo(new Vector3(0, 4, 1));
        player.Talk("안녕하세요.");
    }

    //인터페이스를 매개 변수로 넣거나 반환하려면
    //인터페이스 앞에 public 키워드를 붙여야 함.
    public void Method(IMovingEntity entity) // 입력 타입이 인터페이스라면 인터페이스를 구현한 클래스의 인터페이스를 입력
    {
        //..
    }
    public IMovingEntity Method() // 반환 타입이 인터페이스라면 인터페이스를 구현한 클래스의 인스턴스를 반환
    {
        Goblin goblin = new Goblin();

        return goblin;
    }
}
public interface IMovingEntity // 가능하면 대문자 I를 첫글자에 붙이면 좋음
{
    void MoveTo(Vector3 destination);//접근 지정자 사용 X, 메소드 선언만 가능
}
interface ICombatEntity
{
    void Attack(string Entity);
}

public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)//인터페이스에 선언된 메소드를 무조건 구현해야 함.
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class Slime: IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 기어서 이동");
    }
}

public class Butterfly : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 날아서 이동");
    }
}

interface IPerson : IMovingEntity // 이때 IPerson을 상속받는 클래스는 MoveTo와 Talk를 구현해야 함.
{
    void Talk(string word);
}

public class Player : IPerson,ICombatEntity//인터페이스는 다중상속 할 수 있다.
{
    string ID = "유니티";

    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{ID}님이 {destination}으로 이동");
    }
    public void Talk(string word) // IPerson을 상속받았기 떄문에 MoveTo와 Talk를 정의
    {
        Debug.Log($"{ID} : {word}");
    }
    public void Attack(string target)//ICombatEntity를 상속받았기 떄문에 Attack를 정의해야 한다.
    {
        Debug.Log($"{target} 공격");
    }
}

//다음 경우(클래스 다중 상속)
public abstract class CombatEntity
{
    public abstract void Attack();
}

public class Berserker : CombatEntity
{
    public void Sword() 
    {
        Debug.Log("칼 사용"); 
    }
    public override void Attack() 
    { 
        Sword(); 
    }
}

public class Archer : CombatEntity
{
    public void Arrow()
    {
        Debug.Log("활로 공격");
    }
    public override void Attack()
    {
        Arrow();
    }
}

//public class Player2 : Berserker, Archer { }//이때는 오류 발생(두 개의 클래스를 동시에 상속 X
public class Player2
{//다음처럼 객체 인스턴스 생성 후 사용할 경우 가능
    private Berserker berserker;
    private Archer archer;

    private void Awake()
    {
        berserker=new Berserker();
        archer=new Archer();
    }

    public void SwordAttack() { berserker.Sword(); }
    public void ArrowAttack() { archer.Arrow(); }
}
*/

/* 추상화
public class GameController : MonoBehaviour
{
    Entity entity;
    Entity goblin;
    Entity slime;
    private void Awake()
    {
        //entity=new Entity();// 추상 클래스는 인스턴스 생성 X
        goblin = new Goblin(5, 100);
        slime = new Slime(10, 50);

        goblin.Attack(slime);
        slime.Attack(goblin);
    }
}
public abstract class Entity // 추상 클래스 정의
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target); // 추상 메소드 정의. 무조건 자식 클래스에서 구현해야 한다.
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage}만큼 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}

public class Goblin : Entity
{
    public Goblin(int damage,int HP)
    {
        base.damage = damage;
        currentHP = HP;
    }
    public override void Attack(Entity target)//무조건 Attack 메소드를 구현해야 함.
    {
        Debug.Log("고블린의 몽둥이 후리기");
        target.TakeDamage(damage);
    }
}

public class Slime : Entity
{
    public Slime(int damage, int HP)
    {
        base.damage = damage;  
        currentHP = HP;
    }
    public override void Attack(Entity target)
    {
        Debug.Log("슬라임의 몸통박치기");
        target.TakeDamage(damage);
    }
}
*/

/* 다형성 2 Up Casting와 is,as 연산자
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        Enemy goblin = new Goblin(); 
        Enemy slime = new Slime();
        Enemy dragon = new Dragon();

        Enemy enemy = new Goblin(); // 부모 참조 변수 = 자식 메모리, 업 캐스팅.
        Goblin goblin2 = (Goblin)enemy; //자식 = (자식)부모, 다운 캐스팅

        Enemy enemy2 = new Enemy();//부모 참조 변수=부모 메모리
        //Goblin goblin3=(Goblin)enemy2; //자식=(자식)부모, 다운 캐스팅 시 오류 발생
        Enemy enemy3 = new Slime();

        if(enemy is Goblin)//객체가 해당 형식에 해당하는지 확인.
        {
            Debug.Log("Entity type is Goblin");
        }
        Goblin goblin3 = enemy as Goblin; // 형 변환이 가능하면 형 변환, 실패 시 null 반환
        //Goblin goblin3=enemy3 as Goblin; // 이 경우에는 NULL이 나옴
        if (goblin3 == null)
        {
            Debug.Log("goblin3 is NULL");
        }

        //이때 up casting만 할 경우 Enemy의 TakeDamage가 호출된다.
        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);

        goblin.Attack();
        slime.Attack();
    }
}

public class Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"적 {damage}만큼 체력 감소");
    }
    public virtual void Attack() // 부모 클래스에서 virtual로 정의하지 않았을 경우 파생 클래스에서 override를 이용하려 하면 에러가 발생.
    {//private로 정의된 메서드는 오버라이드 할 수 없음.
        Debug.Log("적을 공격한다");
    }
}
public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 {damage}만큼 체력 감소");
    }
    public override void Attack()//메소드 오버라이딩
    {
        Debug.Log("고블린의 몽둥이 후리기");
    }
}
public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 {damage}만큼 체력 감소");
    }
    public override void Attack()
    {
        Debug.Log("슬라임의 몸통박치기");
    }
}
public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 {damage}만큼 체력 감소");
    }
}
//up casting 이전

//public class Player
//{
//    private int damage = 10;
//    public void Hit(Goblin goblin)
//    {
//        goblin.TakeDamage(damage);
//    }
//    public void Hit(Slime slime)
//   {
//       slime.TakeDamage(damage);
//    }
//    public void Hit(Dragon dragon)
//    {
//        dragon.TakeDamage(damage);
//   }
//}

//up casting 이후
public class Player
{
    private int damage = 10;

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }
}
*/


/* 다형성 1
public class GameController : MonoBehaviour
{
    Entity entity = new Entity();
    Goblin goblin = new Goblin();
    Entity entity2 = new Goblin();
    private void Awake()
    {
        entity.Attack();
        entity.Heal();
        goblin.Attack();
        goblin.Avoid();
        goblin.Heal();//goblin에 정의된 Heal()이 사용된다.
        //entity2.Avoid();//goblin에 정의되어 있지만 사용할 수 없다.
        entity2.Attack();
        entity2.Heal();//entity에 정의된 Heal()이 사용된다.
    }
}
public class Entity //사용 가능 멤버: Attack(), Heal()
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }
}

public class Goblin : Entity// 사용 가능 멤버 : Attack(), Avoid(), Heal() 이때 Goblin의 Heal()이 호출된다.
{
    public void Avoid()
    {
        Debug.Log("도망가자!");
    }
    public void Heal()
    {
        Debug.Log("고블린의 체력 회복!");
    }
}
*/

/* 상속
public class Entity
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "NoName";
    }

    public void recoveryHP(int hp) {
        currentHP += hp;
    }
}
// 파생 클래스(자식 클래스) : 기반 클래스(부모 클래스)
public class Player : Entity
{
    private string ID;
    public Player(string id, int hp)
    {
        base.ID = "NONAME";//부모 클래스의 내부 변수에 접근함.
        ID = id;
        currentHP = hp;

        recoveryHP(1000);
        //private이므로 접근할 수 없음
        //Initialize();
    }
}
*/

/* 캡슐화와 정보 은닉
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        //private 멤버 변수에는 직접 접근 불가
        //player.currentHP = 100;
        //Debug.Log($"HP : {player.currentHP}");

        //currentHP의 Set, Get 메소드에 접근
        player.SetCurrentHP(100);
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}
public class Player
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
*/

/* 클래스 기초 - 생성자, 복사, this 포인터
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;
    public Player player03;

    private void Awake()
    {
        player01=new Player();//생성자를 호출한다.
        player02 = new Player("이름", 200);//오버로드된 생성자 호출

        player03 = player02; // 얕은 복사

        player03.ID = "유니티";

        Debug.Log(player02.ID); // 여기도 유니티로 출력된다.
        Debug.Log(player03.ID);

        player03 = player02.DeepCopy();//깊은 복사
        player03.ID = "플레이어3";
        Debug.Log(player02.ID);//여기선 변하지 않는다.
        Debug.Log(player03.ID);

        player03.SetID("유니티");
        

    }
}
public class Player
{
    public string ID;
    public int currentHP;

    public Player() {//생성자
        ID = "플레이어";
        currentHP = 1000;
    }//반환 형식을 가질 수 없으며 한정자는 public을 가진다.
    public Player(string id, int hp) {//생성자 오버로딩
        ID = id;
        currentHP = hp;
    }
//혹은 this를 이용해 생성자를 호출할 수 있다.
//    /*
//     public Player()
//    {
//        ID = "플레이어";
//    }
//
//    public Player(int hp): this()
//    {
//        currentHP = hp;
//    }
     
    public Player DeepCopy() //깊은 복사
    {
        Player clone = new Player(); //Player 메모리 생성
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
    public void SetID(string ID)//this 포인터
    {
        Debug.Log($"ID : {ID}"); // 여기선 지역 변수를 표시한다.
        Debug.Log($"ID : {this.ID}"); // 여기선 멤버 변수를 표시한다.
    }
}
*/

/*클래스 기초 - 클래스 선언과 멤버함수
public class GameController : MonoBehaviour
{
    public Player Player01;
    public Player Player02;

    private void Awake()
    {
        Player01 = new Player();// Player의 인스턴스가 변수에 채워짐.
        Player01.TakeDamage(100);
        //Player02.TakeDamage(200); // new 키워드로 할당되지 않은 변수를 사용하려 하면 NULL 에러가 출력됨.
        //Player01.RecoveryHP(100);//private로 선언된 멤버 함수를 이용하려 하면 에러 발생
    }
}
public class Player
//  클래스 이름 : 부모 클래스 형식으로 작성됨.        
{
    //멤버 변수
    private string ID = "플레이어";
    private int currentHP = 1000;

    //멤버 함수 - 클래스에 소속된 메소드
    void RecoveryHP(int hp) // 기본적으로 private로 설정됨(외부 접근 불가능)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage) // 메소드 내부에 선언된 변수는 지역 변수라 불림.
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }

    private void Awake()
    {
        TakeDamage(100); //같은 클래스에 소속된 메서드는 조건 없이 호출 가능
    }
}

public class Enemy
{
    private Player player;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}
*/




