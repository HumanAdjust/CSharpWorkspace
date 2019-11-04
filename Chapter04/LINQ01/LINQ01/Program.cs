using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* LINQ(Language Intergrated Query) */
/* 컬렉션을 대상으로 쿼리를 수행할 수 있다. */
namespace LINQ01
{
    class Program
    {
        // 랜덤 숫자 생성 메서드
        static int[] GenerateIntegerNum(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            // 1. 데이터 소스(자연수 20개를 저장한 배열)
            int[] numbers = GenerateIntegerNum(20);

            /* numbers 배열에서 2로 나누어지는 숫자만 새로운 리스트에 저장하고 오름차순 정렬하여 출력 */
            #region LINQ를 사용하지 않은 경우
            // 배열의 초기 상태 출력
            PrintArr(numbers);

            // 2. List 생성
            List<int> numList = new List<int>();

            // 3. Numbers 배열에서 짝수만 추출하여 List에 저장
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    numList.Add(num);
            }

            // 4. List의 숫자들을 오름차순으로 정렬
            numList.Sort();

            // 5. List 출력
            Console.WriteLine("--- 짝수만 추출한 결과 ---");
            foreach (var item in numList)
                Console.Write($"{item} ");
            Console.WriteLine('\n');

            #endregion

            #region LINQ를 사용한 경우
            PrintArr(numbers);

            // 2. 쿼리 만들기(짝수만 오름차순으로 남기는 쿼리)
            var linqList = from num in numbers  //num(범위 변수), numbers(컬렉션 타입의 데이터 소스)
                           where num % 2 == 0  // 결과가 true인 요소만 반환
                           orderby num ascending  //num을 기준으로 오름차순 정렬(내림차순: descending
                           select num;     //추출할 데이터 지정
            // select num from numbers where num % 2 == 0 orderby asc;

            // 3. 쿼리 실행(출력)
            Console.WriteLine("--- 짝수만 추출한 결과 ---");
            foreach (var item in numList)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
            #endregion

            // 2. 쿼리 만들기(2와 3으로 동시에 나누어지는 숫자만 오름차순으로 남기는 쿼리)
            var linqList2 = from num in numbers  //num(범위 변수), numbers(컬렉션 타입의 데이터 소스)
                           where num % 2 == 0 && num % 3 == 0  // 결과가 true인 요소만 반환
                           orderby num ascending  //num을 기준으로 오름차순 정렬(내림차순: descending
                           select num;     //추출할 데이터 지정
            // select num from numbers where num % 2 == 0 orderby asc;

            PrintLinqList(linqList2);
        }

        private static void PrintLinqList(IOrderedEnumerable<int> linqList2)
        {
            Console.WriteLine("--- 2와 3으로 동시에 나누어지는 숫자만 추출하여 오름차순 정렬 결과 ---");
            foreach (var item in linqList2)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
        }

        private static void PrintArr(int[] numbers)
        {
            Console.WriteLine("--- 원본 ---");
            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
        }
    }
}
