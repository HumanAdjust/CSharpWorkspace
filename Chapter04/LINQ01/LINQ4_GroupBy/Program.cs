using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* group by into로 데이터 분류하기(494p 예제)*/
namespace LINQ4_GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrayProfile =
            {
                new Profile(){ Name = "정우성", Height = 186, Gender="남성" },
                new Profile(){ Name = "김태희", Height = 158, Gender="여성" },
                new Profile(){ Name = "고현정", Height = 172, Gender="여성" },
                new Profile(){ Name = "이문세", Height = 178, Gender="남성" },
                new Profile(){ Name = "하동운", Height = 171, Gender="남성" }
            };

            #region 성별로 그룹 나눔
            // 2. 쿼리 만들기
            var profileList1 = from profile in arrpROFILE
                               group profile by profile.Gender;

            // 3. 쿼리 실행(출력)
            PrintLinqList(profileList1);
            foreach (var Group in profileList1)
            {
                Console.WriteLine($"그룹 이름: {Group.Key}");  // Group.Key => 남성 / 여성
                foreach (var item in Group)
                {
                    Console.WriteLine($"{item.Name}, {item.Height}, {item.Gender}");
                }
            }
            #endregion

            #region 키(175)로 분류
            // 2. 쿼리 만들기(키 175이상과 미만으로 그룹을 분류함)
            var profileList = from profile in arrayProfile
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            // 3. 쿼리 실행
            foreach (var Group in profileList)
            {
                Console.WriteLine($"175미만 그룹인가? {Group.GroupKey}");
                foreach (var item in Group.Profiles)
                {
                    Console.WriteLine($"{item.Name}, {item.Height}");
                }
                Console.WriteLine();
            }
            #endregion



        }
    }
}
