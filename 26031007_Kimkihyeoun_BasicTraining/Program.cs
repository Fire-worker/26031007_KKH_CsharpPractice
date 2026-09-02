
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        ///// # 식별자 연습
        //// [파란색 글자 = 키워드_string] [하늘색 글자 = 식별자_name] [초록색 글자 = ???] << {1번 의문}
        //string name = "OhHeesung";
        //string id1000 = "123123";
        //// 식별자 앞 '_'는 앵간하면 쓰지마셈ㅇㅇ
        //string subject = "객체지향C#";

        //// 출력규칙 $"텍스트내용: {식별자}" | ("텍스트 : {0}, 텍스트: {1}", 식별자, 식별자);
        //// 왠만하면 앞의 것을 쓸것.
        //Console.WriteLine($"이름: {name}");

        ///// # 연산 연습
        //Console.WriteLine(10 + 2000);
        //// = "10" + "2000"
        //Console.WriteLine(10 + "2000");
        //Console.WriteLine(int.Parse("200") + 1);
        //Console.WriteLine(123448 % 3);
        //Console.WriteLine((12345 % 1) / 10);
        //// for문을 해체분석한것
        //Console.WriteLine((12345 % 10) / 1);
        //Console.WriteLine((12345 % 100) / 10);
        //Console.WriteLine((12345 % 1000) / 100);
        //Console.WriteLine((12345 % 10000) / 1000);
        //Console.WriteLine((12345 % 100000) / 10000);
        ////?? 앞에 -가 붙으면 값이 -n? why??
        //Console.WriteLine(4 % 3);
        //Console.WriteLine(4 % -3);  // 4 - (4/-3) * (-3)
        //Console.WriteLine(-4 % 3);  // 4 - (-4/3) * (3)
        //Console.WriteLine(-4 % -3); // -4 (-4/-3) * (-3)

        //// 실수 표현방법 : n.0 or n.n
        //Console.WriteLine(12345.0 / 1000.0);
        //Console.WriteLine(1 / 2);
        //Console.WriteLine(1.0 / 2.0);
        //Console.WriteLine(5.0 % 2.2);

        //// 문자열
        //Console.WriteLine('a');
        //// 이스케이프 문자는 탈출용. \t, \n , \\ 등
        //Console.WriteLine("안뇽안녕 \t\t\t방가봉가");

        //// 인덱스는 0부터
        //Console.WriteLine("안녕하세요"[0]);
        //Console.WriteLine("안녕하세요"[1]);
        //Console.WriteLine("안녕하세요"[2]);
        //Console.WriteLine("안녕하세요"[3]);

        //// exception, run time error
        //Console.WriteLine("한" + "글");
        //Console.WriteLine('한' + '글');

        //// boolean
        //Console.WriteLine(true);
        //Console.WriteLine(false);

        //// 변수 >> 키워드(type(=자료형))+식별자
        //int     idNumber; // 선언하는 것. << 이게 프로그래머들이 기획한테 원하는거
        //int     idNumber1   = 10;
        //long    longInt     = 1000000000000000000;
        //double  score       = 98.3;
        //char    character   = 'a';
        //string  message     = "기모찌";

        // 오버플로가 역순으로도 작용함 ㅇㅇ >> 이거 때문에 롤에서 최단시간 챌찍기 할 ㅅ ㅜ있었죠 예
        int a = -2147483648;
        int b = -10;
        Console.WriteLine(a + b);
        Console.WriteLine(uint.MinValue);
    }
}

// 기획문서의 스펙을 적는다.
// 객체지향 = 탑다운 방식으로 진행하는 것이 좋다. >> 클래스부터 만들어야함ㅇㅇ.
class GameScene
{
    //// 생성
    //Create();
    //// 초기화
    //Init();
    //// 갱신
    //update();
    //// 렌더링
    //Render();
    //// 파괴
    //Destroy( );
}