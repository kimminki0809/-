using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ctrl + c = 터미널 강제종료
//ctrl + k + f = 줄 정리

//1. 어떤 함수가 그 기능을 할 수 있는가
//2. 그 함수가 무슨 기능을 가지고 있는가

class Player
{


}

class Monster
{


}

enum STARTSELCET
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}


namespace TextRpg001
{
    class Program
    {

        static STARTSELCET StartSelect(){
            //리턴값이 Enum


            //System.Console
            //System: 네임스페이스명
            //Console: 클래스명

            //Console.Clear();//Console 창을 지우는 함수            
            Console.WriteLine("");
            Console.WriteLine("어디로 이동하시겠습니까?");
            Console.WriteLine("1. 마을로 이동한다.");
            Console.WriteLine("2. 사냥터로 이동한다.");


            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
            //Console.ReadKey: 정적맴버함수 이기에 객체를 호출하지 않고 클래스.함수(인자값)의 형태로 사용 가능.
            //클래스화(객체화) 하지 않고도 사용 할 수 있는 함수 = 정적(static)맴버 



            //ReadKey함수 : ConsoleKeyInfo Console.ReadKey()의 형태

            //ConsoleKeyInfo: int나 float 같은 리턴값이며 Struct이다
            //Struct는 Class처럼 맴버변수와 맴버함수를 둘다 가질 수 있다.

            //고로 Struct를 토대로 만들어진 지역변수인 KeyInfo는 여러 함수를 리턴하는데 그 중 Key속성을 리턴한다.
            //ConsoleKeyInfo 구조체에서 Key 속성만을 출력합니다. Key 속성은 눌린 키를 나타내는 ConsoleKey 열거형 값입니다.
            //Key속성은 ConsoleKey라는 enum을 리턴하는 속성

            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
            //Key 속성
            //ConsoleKeyInfo Struct에 public ConsoleKey Key 형태의 속성이 있음
            //Key속성은 ConsoleKey라는 enum을 리턴하는 함수


            //ConsoleKey enum
            //public enum ConsoleKey 형태의 enum이 있음
            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ



            //Console.ReadKey() 메서드가 호출되면 프로그램은 여기서 일시적으로 정지되며, 
            //사용자가 키보드에서 어떤 키를 누를 때까지 대기합니다.
            //사용자가 키를 누르면, 눌린 키에 대한 정보를 ConsoleKeyInfo 구조체로 읽어옵니다. 
            //ConsoleKeyInfo 구조체에는 눌린 키에 대한 여러 정보가 담겨 있습니다.
            //읽어온 정보는 keyInfo라는 변수에 할당됩니다. keyInfo는 ConsoleKeyInfo 구조체의 인스턴스이며, 
            //눌린 키에 대한 정보를 담고 있습니다.


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            //누른 키를 그대로 리턴해주는 함수.
            //함수를 객체화함.

            Console.WriteLine(keyInfo.Key);
            //누른 키에 해당하는 ConsoleKey enum에서 값을 찾아 WriteLine해주는 함수.


            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
            // static int TenReturn(){
            //     return 10;
            // }

            // static void Main(string[] arg2){
            //     int Number = TenReturn(); //리턴값을 int로 받을 수 있는 것 처럼
            // }

            //ConsoleKeyInfo keyInfo = Console.ReadKey에선 ConsoleKeyInfo(struct)로 리턴값을 받는다.
            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

            switch (keyInfo.Key){

                //오류:
                //C:\Users\user\Desktop\Text RPG\Program.cs(33,28): error CS0161: 
                //'Program.StartSelect()': 코드 경로 중 일부만 값을 반환합니다. [C:\Users\user\Desktop\Text RPG\Text RPG.csproj]
                //: Switch 문에 안걸리는 경우에는 무엇을 리턴해 줄 것인지 요구하는 것.
                //그러므로 enum을 만들때는 에러나 잘못된 선택에 관한 것도 만듬. > NONESELECT
            
                case ConsoleKey.D1:
                Console.WriteLine("마을로 이동합니다.");
                Console.WriteLine("아무 키나 누르시면 이동합니다.");
                Console.ReadKey();
                return STARTSELCET.SELECTTOWN;

                case ConsoleKey.D2:
                Console.WriteLine("사냥터로 이동합니다.");
                Console.WriteLine("아무 키나 누르시면 이동합니다.");
                Console.ReadKey();
                return STARTSELCET.SELECTBATTLE;

                default:
                Console.WriteLine("잘못된 선택입니다.");
                Console.WriteLine("아무 키나 누르시면 선택 창으로 돌아갑니다.");
                Console.ReadKey();
                return STARTSELCET.NONESELECT;
            }
        }

        static void Town()
        {

            Console.WriteLine(" ");
            Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
            Console.WriteLine("1. 주점에 들른다.");
            Console.WriteLine("2. 대장간에 들른다.");
            Console.WriteLine("3. 숙소에 들른다.");

            
            ConsoleKeyInfo CKI = Console.ReadKey();
            //Console.ReadKey 함수를 밖으로 꺼냄.
            //ConsoleKeyInfo Struct(구조체) 중 Key 속성을 CKI가 가지게됨.

            if(CKI.Key == ConsoleKey.D1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("주점으로 이동합니다.");
                Console.ReadKey();
            }
            else
            {
                Town();
            }

        }

        static void Battle()
        {
            Console.WriteLine("기달");
            Console.ReadKey();

        }



        static void Main(string[] args)
        {

            while (true)
            {

                //함수는 그 자료형(Enum)의 변수로 사용가능.
                STARTSELCET SelectCheck = StartSelect();

                if (SelectCheck == STARTSELCET.SELECTTOWN)
                //C#의 if 문의 조건문은 bool 형식의 값이어야 합니다.
                //고로 할당연산자 = 이 아닌 동등비교연산자 == 가 들어가야한다.
                {
                    Town();
                }
                
                if (SelectCheck == STARTSELCET.SELECTBATTLE)
                {
                    Battle();
                }

                else
                {
                    StartSelect();
                }

                
            }
        }
    }

}