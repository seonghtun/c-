// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Nullable;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    // class CSVar
    // {
    //     //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
    //     int globalVar;
    //     const int MAX = 1024;

    //     public void Method1()
    //     {
    //         // 로컬변수
    //         int localVar;

    //         // 아래 할당이 없으면 에러 발생
    //         localVar = 100;

    //         Console.WriteLine(globalVar);
    //         Console.WriteLine(localVar);
    //     }
    // }

    class CSVar
    {
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드 
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }

        public void Method1()
        {
            // 로컬변수
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(Max);
            Console.WriteLine(localVar);
        }
        //...
    }

    class Program
    {
        // 모든 프로그램에는 Main()이 있어야 함.
        // static void Main(string[] args)
        // {
        //     // 테스트
        //     CSVar obj = new CSVar();
        //     obj.Method1();

        //     // 1차 배열
        //     string[] players = new string[10];
        //     string[] Regions = { "서울", "경기", "부산" };

        //     // 2차 배열 선언 및 초기화
        //     string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

        //     // 3차 배열 선언
        //     string[,,] Cubes;

        //     //Jagged Array (가변 배열)
        //     //1차 배열 크기(3)는 명시해야
        //     int[][] A = new int[3][];

        //     //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
        //     A[0] = new int[2];
        //     A[1] = new int[3] { 1, 2, 3 };
        //     A[2] = new int[4] { 1, 2, 3, 4 };

        //     A[0][0] = 1;
        //     A[0][1] = 2;
        // }
        // static void Main(string[] args)
        // {
        //     int[] scores = { 80, 78, 60, 90, 100 };
        //     int sum = CalculateSum(scores); // 배열 전달: 배열명 사용
        //     Console.WriteLine(sum);
        // }

        // static int CalculateSum(int[] scoresArray) // 배열 받는 쪽
        // {
        //     int sum = 0;
        //     for (int i = 0; i < scoresArray.Length; i++)
        //     {
        //         sum += scoresArray[i];
        //     }
        //     return sum;
        // }


        // static void Main(string[] args)
        // {
        //     // 문자열(string) 변수
        //     string s1 = "C#";
        //     string s2 = "Programming";

        //     // 문자(char) 변수 
        //     char c1 = 'A';
        //     char c2 = 'B';

        //     // 문자열 결합
        //     string s3 = s1 + " " + s2;
        //     Console.WriteLine("String: {0}", s3);

        //     // 부분문자열 발췌
        //     string s3substring = s3.Substring(1, 5);
        //     Console.WriteLine("Substring: {0}", s3substring);

        // }
        // static void Main(string[] args)
        // {
        //     string s = "C# Studies";

        //     // 문자열을 배열인덱스로 한문자 엑세스 
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         Console.WriteLine("{0}: {1}", i, s[i]);
        //     }

        //     // 문자열을 문자배열로 변환
        //     string str = "Hello";
        //     char[] charArray = str.ToCharArray();

        //     for (int i = 0; i < charArray.Length; i++)
        //     {
        //         Console.WriteLine(charArray[i]);
        //     }

        //     // 문자배열을 문자열로 변환
        //     char[] charArray2 = { 'A', 'B', 'C', 'D' };
        //     s = new string(charArray2);

        //     Console.WriteLine(charArray2);
        //     Console.WriteLine(s);

        //     // 문자 연산
        //     char c1 = 'A';
        //     char c2 = (char)(c1 + 3);
        //     Console.WriteLine(c2);  // D 출력
        // }

        // static void Main(string[] args)
        // {
        //     StringBuilder sb = new StringBuilder();
        //     for (int i = 1; i <= 26; i++)
        //     {
        //         sb.Append(i.ToString());
        //         sb.Append(System.Environment.NewLine);
        //     }
        //     string s = sb.ToString();

        //     Console.WriteLine(s);
        // }
        // enum City
        // {
        //     Seoul,   // 0
        //     Daejun,  // 1
        //     Busan = 5,  // 5
        //     Jeju = 10   // 10
        // }

        // static void Main(string[] args)
        // {
        //     City myCity;

        //     // enum 타입에 값을 대입하는 방법
        //     myCity = City.Seoul;

        //     // enum을 int로 변환(Casting)하는 방법. 
        //     // (int)를 앞에 지정.
        //     int cityValue = (int)myCity;

        //     if (myCity == City.Seoul) // enum 값을 비교하는 방법
        //     {
        //         Console.WriteLine("Welcome to Seoul");
        //     }
        // }

        // [Flags]
        // enum Border
        // {
        //     None = 0,
        //     Top = 1,
        //     Right = 2,
        //     Bottom = 4,
        //     Left = 8
        // }

        // static void Main(string[] args)
        // {
        //     // OR 연산자로 다중 플래그 할당
        //     Border b = Border.Top | Border.Bottom;

        //     // & 연산자로 플래그 체크
        //     if ((b & Border.Top) != 0)
        //     {
        //         //HasFlag()이용 플래그 체크
        //         if (b.HasFlag(Border.Bottom))
        //         {
        //             // "Top, Bottom" 출력
        //             Console.WriteLine(b.ToString());
        //         }
        //     }
        // }

        // static bool verbose = false;
        // static bool continueOnError = false;
        // static bool logging = false;

        // static void Main(string[] args)
        // {
        //     if (args.Length != 1)
        //     {
        //         Console.WriteLine("Usage: MyApp.exe option");
        //         return;
        //     }

        //     string option = args[0];
        //     switch (option.ToLower())
        //     {
        //         case "/v":
        //         case "/verbose":
        //             verbose = true;
        //             break;
        //         case "/c":
        //             continueOnError = true;
        //             break;
        //         case "/l":
        //             logging = true;
        //             break;
        //         default:
        //             Console.WriteLine("Unknown argument: {0}", option);
        //             break;
        //     }
        // }

        //     static void Main(string[] args)
        //     {
        //         // 3차배열 선언
        //         string[,,] arr = new string[,,] {
        //         { {"1", "2"}, {"11","22"} },
        //         { {"3", "4"}, {"33", "44"} }
        // };

        //         //for 루프 : 3번 루프를 만들어 돌림
        //         for (int i = 0; i < arr.GetLength(0); i++)
        //         {
        //             for (int j = 0; j < arr.GetLength(1); j++)
        //             {
        //                 for (int k = 0; k < arr.GetLength(2); k++)
        //                 {
        //                     Debug.WriteLine(arr[i, j, k]);
        //                 }
        //             }
        //         }

        //         //foreach 루프 : 한번에 3차배열 모두 처리
        //         foreach (var s in arr)
        //         {
        //             Console.WriteLine(s);
        //         }
        //     }
        // static IEnumerable<int> GetNumber()
        // {
        //     yield return 10;  // 첫번째 루프에서 리턴되는 값
        //     yield return 20;  // 두번째 루프에서 리턴되는 값
        //     yield return 30;  // 세번째 루프에서 리턴되는 값
        // }

        // static void Main(string[] args)
        // {
        //     foreach (int num in GetNumber())
        //     {
        //         Console.WriteLine(num);
        //     }
        // }
        // struct MyPoint
        // {
        //     public int X;
        //     public int Y;

        //     public MyPoint(int x, int y)
        //     {
        //         this.X = x;
        //         this.Y = y;
        //     }

        //     public override string ToString()
        //     {
        //         return string.Format("({0}, {1})", X, Y);
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 구조체 사용
        //     MyPoint pt = new MyPoint(10, 12);
        //     Console.WriteLine(pt.ToString());
        // }

        // public class MyCustomer
        // {
        //     // 필드
        //     private string name;
        //     private int age;

        //     // 이벤트 
        //     public event EventHandler NameChanged;

        //     // 생성자 (Constructor)
        //     public MyCustomer()
        //     {
        //         name = string.Empty;
        //         age = -1;
        //     }

        //     // 속성
        //     public string Name
        //     {
        //         get { return this.name; }
        //         set
        //         {
        //             if (this.name != value)
        //             {
        //                 this.name = value;
        //                 if (NameChanged != null)
        //                 {
        //                     NameChanged(this, EventArgs.Empty);
        //                 }
        //             }
        //         }
        //     }
        //     public int Age
        //     {
        //         get { return this.age; }
        //         set { this.age = value; }
        //     }

        //     // 메서드
        //     public string GetCustomerData()
        //     {
        //         string data = string.Format("Name: {0} (Age: {1})",
        //                     this.Name, this.Age);
        //         return data;
        //     }
        // }

        // double _Sum = 0;
        // DateTime _Time;
        // bool? _Selected;

        // public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        // {
        //     if (i.HasValue && d.HasValue)
        //         this._Sum = (double)i.Value + (double)d.Value;

        //     // time값이 있는 체크.
        //     if (!time.HasValue)
        //         throw new ArgumentException();
        //     else
        //         this._Time = time.Value;

        //     // 만약 selected가 NULL이면 false를 할당
        //     this._Selected = selected ?? false;

        //     void NullableTest()
        //     {
        //         int? a = null;
        //         int? b = 0;
        //         int result = Nullable.Compare<int>(a, b);
        //         Console.WriteLine(result); //결과 -1

        //         double? c = 0.01;
        //         double? d = 0.0100;
        //         bool result2 = Nullable.Equals<double>(c, d);
        //         Console.WriteLine(result2); //결과 true
        //     }
        // }
        // private void Calculate(int a)
        // {
        //     a *= 2;
        //     Console.WriteLine(a);
        // }

        // static void Main(string[] args)
        // {
        //     Program p = new Program();

        //     int val = 100;
        //     p.Calculate(val);
        //     Console.WriteLine(p);
        //     Console.WriteLine(val);

        //     // val는 그대로 100        
        // }
        // static double GetData(ref int a, ref double b)
        // { return ++a * ++b; }

        // // out 정의
        // static bool GetData(int a, int b, out int c, out int d)
        // {
        //     c = a + b;
        //     d = a - b;
        //     return true;
        // }

        // static void Main(string[] args)
        // {
        //     // ref 사용. 초기화 필요.
        //     int x = 1;
        //     double y = 1.0;
        //     double ret = GetData(ref x, ref y);

        //     // out 사용. 초기화 불필요.
        //     int c, d;
        //     bool bret = GetData(10, 20, out c, out d);
        // }

        // int Calc(int a, int b, string calcType = "+")
        // {
        //     switch (calcType)
        //     {
        //         case "+":
        //             return a + b;
        //         case "-":
        //             return a - b;
        //         case "*":
        //             return a * b;
        //         case "/":
        //             return a / b;
        //         default:
        //             throw new ArithmeticException();
        //     }
        // }
        // int Calc(string calcType = "+", params int[] values)
        // {
        //     int a = values[0];
        //     int b = values[1];

        //     switch (calcType)
        //     {
        //         case "+":
        //             return a + b;
        //         case "-":
        //             return a - b;
        //         case "*":
        //             return a * b;
        //         case "/":
        //             return a / b;
        //         default:
        //             throw new ArithmeticException();
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     Program p = new Program();
        //     int ret = p.Calc("*", 1, 2);
        //     Console.WriteLine(ret);
        //     ret = p.Calc("+", 1, 2);
        //     Console.WriteLine(ret);
        // }

        // //메서드


        // //사용

        // 클래스 내의 이벤트 정의
        // class MyButton
        // {
        //     public string Text;
        //     // 이벤트 정의
        //     public event EventHandler Click;

        //     public void MouseButtonDown()
        //     {
        //         if (this.Click != null)
        //         {
        //             // 이벤트핸들러들을 호출
        //             Click(this, EventArgs.Empty);
        //         }
        //     }
        // }

        // // 이벤트 사용
        // public void Run()
        // {
        //     MyButton btn = new MyButton();
        //     // Click 이벤트에 대한 이벤트핸들러로
        //     // btn_Click 이라는 메서드를 지정함
        //     btn.Click += new EventHandler(btn_Click);
        //     btn.Text = "Run";
        //     //....
        // }

        // void btn_Click(object sender, EventArgs e)
        // {
        //     MessageBox.Show("Button 클릭");
        // }

        //         class MyButton
        // {
        //     // 이벤트 정의하는 다른 방법
        //     private EventHandler _click;
        //     public event EventHandler Click
        //     {
        //         add
        //         {
        //             _click += value;
        //             // _click = value;   // 싱글캐스트
        //         }
        //         remove
        //         {
        //             _click -= value;
        //         }
        //     }

        //     public void MouseButtonDown()
        //     {
        //         if (this._click != null)
        //         {
        //             // 이벤트핸들러들을 호출
        //             _click(this, EventArgs.Empty);                                
        //         }
        //     }

        //     /* 속성 정의
        //     private string _name;
        //     public string Name 
        //     {
        //         get
        //         {
        //             return _name;
        //         }
        //         set
        //         {
        //             _name = value;
        //         }
        //     }
        //     */
        // }
    }
}
