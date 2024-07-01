using CommonElements;

namespace TestProject
{
    public class CommonFinderTest
    {
        [Fact]
        public void TestCommonElementsCase1()
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };

            int[] result = CommonFinder.FindCommonElements(array1, array2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCommonElementsCase2()
        {
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            int[] result = CommonFinder.FindCommonElements(array1, array2);

            Assert.Equal(expected, result);
        }

    }
}