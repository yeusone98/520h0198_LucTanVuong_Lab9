using StudentServiceLib;
using System.Diagnostics.Metrics;
using static System.Formats.Asn1.AsnWriter;

namespace _520h0198_LucTanVuong_Lab9
{
    [TestClass]
    public class UnitTest1
    {
        private Student stu;

        [TestInitialize]
        public void init()
        {
            stu = new Student();
        }
        [TestMethod]
        public void Test_Score_Method1()
        {
            Student s = new Student();
            s.Name = "Vuong";
            s.Age = 20;
            s.Score = 10;
            char letter = s.getLetterScore(); 


            Assert.AreEqual('A', letter);
        }

    [TestMethod]
    public void Test_Score_Method2()
    {
        Student s = new Student();
        s.Name = "Vuong";
        s.Age = 20;
        s.Score = 7.5;
        char letter = s.getLetterScore();


        Assert.AreEqual('B', letter);
    }


        [TestMethod]
        [DataRow(8, 'A')]
        [DataRow(7.5, 'A')]
        [DataRow(7, 'A')]
        [DataRow(6, 'C')]
        [DataRow(5, 'C')]
        [DataRow(2, 'E')]
        public void Test_All_Score_Method(int score, char expect)
        {
            stu.Score = score;
            char letter = stu.getLetterScore();
            Assert.AreEqual(letter, expect);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]

        public void exceptionShouldThrow()
        {
            stu.Score = 11;
        }
    }
}