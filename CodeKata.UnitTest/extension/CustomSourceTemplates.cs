using JetBrains.Annotations;

namespace CodeKata.UnitTest.extension
{
    public static class CustomSourceTemplates
    {
        [SourceTemplate]
        public static void abs<T>(this T source)
        {
            /*$ Math.Abs(source)*/
        }

        [SourceTemplate]
        [Macro(Target = "expected", Editable = 1)]
        public static void ae<T>(this T source)
        {
            /*$ Assert.AreEqual( $expected$ , source);*/
        }
    }
}