using System; // 단일 네임스페이스에서 모든 형식을 가져옵니다.

namespace Triangle // 관련 개체 집합을 포함하는 범위를 선언하는 데 사용됩니다. 네임스페이스, 클래스, 속성, 메서드, 구조체는 항상 대문자로 시작! 
{

    class Triangle
    // C#에서는 단일 상속만 허용됩니다. 즉, 한 클래스는 하나의 기본 클래스에서만 구현을 상속할 수 있습니다.
    //그러나 한 클래스는 두 개 이상의 인터페이스를 구현할 수 있습니다.
    {
        private int side_a;
        private int side_b;
        private int side_c;

        // 여기서 왜 따로 define을 해주는지 모르겠다.

        // public 키워드는 형식 및 형식 멤버에 대한 엑세스 한정자입니다.
        // 공용 엑세스는 허용 범위가 가장 큰 액세스 수준입니다.
        // ?? get, set 관련해서 이해가 안간다.
        public int Round { get; } = 0;

        public bool IsTriangle { 
            get
            {
                int longest = Math.Max(Math.Max(side_a, side_b), side_c);

                int others = side_a + side_b + side_c - longest;

                return longest - others < 0;
            }
        }
        //public int Round
        //{
        //    get
        //    {
        //        return round;
        //    }
        //    set
        //    {
        //        round = value;
        //    }
        //}


        //int round;
        //
        //public int Get_Side_a()
        //{
        //    return side_a;
        //}
        //public void Set_Side_a(int _side_a)
        //{
        //    side_a = _side_a;
        //}
        public Triangle() { }

        public Triangle(int _side_a, int _side_b, int _side_c) 
        // 왜 int _side_a, b, c를 다시 해줬는지??
        // 생성자란 클래스가 가진 특수한 메서드이다. 생성자는 리턴값을 가지지 않고, 클래스와 같은 이름을 가진다. 생성자는 클래스 객체가 생성될때 실행된다.
        // 생성자는 클래스안에 여러가지가 있을 수 있다. 
        // 오버로딩 : 같은 이름의 메서드를 사용하고 싶어서 쓰는 기법, 단 오버로딩은 리턴값만으로 구분되지 않는다.
        {
            side_a = _side_a;
            side_b = _side_b;
            side_c = _side_c;

            Round = side_a + side_b + side_c; // Round에 대한 정의
        }
        public void ChangeTriangle(int _side_a, int _side_b, int _side_c)
        {
            side_a = _side_a;
            side_b = _side_b;
            side_c = _side_c;

            Round = side_a + side_b + side_c;
        }
        public override string ToString() // string ToString()에 대한 의미를 잘 모르겠다.
        {
            return $"Draw({side_a}, {side_b}, {side_c})"; // 문자열 보간
        }

    }
    class Program
    {
        static void Main(string[] args) // Main 
        {
            Console.WriteLine("숫자를 ,로 나눠서 입력하세요");

            // "입력받은 문자열".Split(","); 
            string[] input = Console.ReadLine().Split(","); //문자 배열로 input을 ','기준으로 나눠서 받는다.
            Triangle trg;
            int side_a = int.Parse(input[0]); // 첫번째 string으로 받을것을 int화
            int side_b = int.Parse(input[1]); // 두번째 string으로 받을것을 int화
            int side_c = int.Parse(input[2]); // 세번째 string으로 받을것을 int화

            //trg.Round;
            trg = new Triangle(side_a, side_b, side_c);

            // 새 인스턴스 유형을 일반적으로 new 연산자를 사용하여 해당 유형의 생성자 중 하나를 호출한다.
            // new 연산자로 새 인스턴스 유형을 만드는 이유도 잘 모르겠다.

            Console.WriteLine(trg.Round);
            Console.WriteLine(trg.IsTriangle);

        }
    }
}
