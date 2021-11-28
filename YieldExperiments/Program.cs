using System;
using System.Collections.Generic;

namespace YieldExperiments
{
    class Program
    {
        class MyCustomClass
        {
            public int SomeFieldName
            {
                get => someFieldName;
                set { someFieldName = value; Console.WriteLine(someFieldName); }
            }

            private int someFieldName = 0;
        }

        int somePrivateField = 22;
        static int someStaticField = 23;

        static void Main(string[] args)
        {
            Playground01();
            Playground02();
            Playground03();
            Playground04();
            Playground05();

            var program = new Program();
            program.Playground06();
        }

        static void Playground01()
        {
            Console.WriteLine("Playground01");

            // Iterate
            var enumerableCollection = HelloEnumerable();
            foreach (var item in enumerableCollection)
            {
                Console.WriteLine(item);
            }

            // Use enumerator and movenext
            var enumerator = enumerableCollection.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        static IEnumerable<int> HelloEnumerable()
        {
            yield return 5;
            yield return 7;
            yield return 9;
        }

        static void Playground02()
        {
            Console.WriteLine("Playground02");
            var anEnumeratorObject = HelloEnumerator();

            // Iterate will produce error
            //foreach (var item in aEnumeratorObject)
            //{
            //    Console.WriteLine(item);
            //}

            // Use enumerator and movenext
            var enumerator = anEnumeratorObject;
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        static IEnumerator<int> HelloEnumerator()
        {
            yield return 1;
            yield return 3;
            yield return 5;
        }

        static void Playground03()
        {
            Console.WriteLine("Playground03");

            // Iterate
            var enumerableCollection = HelloEnumerableWithState();
            foreach (var item in enumerableCollection)
            {
                Console.WriteLine(item);
            }

            // Use enumerator and movenext
            var enumerator = enumerableCollection.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        static IEnumerable<int> HelloEnumerableWithState()
        {
            int fooVariable = 0;
            yield return fooVariable;

            ++fooVariable;
            yield return fooVariable;

            ++fooVariable;
            yield return fooVariable;
        }

        static void Playground04()
        {
            Console.WriteLine("Playground04");
            var anEnumeratorObject = HelloEnumeratorWithCustomClass();

            // Iterate will produce error
            //foreach (var item in aEnumeratorObject)
            //{
            //    Console.WriteLine(item);
            //}

            // Use enumerator and movenext
            var enumerator = anEnumeratorObject;
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);

            // Yield inside while
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        static IEnumerator<MyCustomClass> HelloEnumeratorWithCustomClass()
        {
            yield return new MyCustomClass() { SomeFieldName = 5 };

            var myCustomObj = new MyCustomClass();
            myCustomObj.SomeFieldName = 3;
            yield return myCustomObj;

            myCustomObj.SomeFieldName = -3;
            yield return myCustomObj;

            int i = myCustomObj.SomeFieldName;
            while (i != 0)
            {
                ++i;
                yield return null;
            }
        }

        static void Playground05()
        {
            Console.WriteLine("Playground02");
            var anEnumeratorObject = HelloEnumeratorWhileTrue();

            // Iterate will produce error
            //foreach (var item in aEnumeratorObject)
            //{
            //    Console.WriteLine(item);
            //}

            // Use enumerator and movenext
            var enumerator = anEnumeratorObject;
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        static IEnumerator<int> HelloEnumeratorWhileTrue()
        {
            yield return 5;

            int i = 0;
            while (i != 2)
            {
                yield return i++;
            }

            someStaticField = 25;
        }

        void Playground06()
        {
            Console.WriteLine("Playground02");
            var anEnumeratorObject = HelloEnumeratorAccessPrivateMember();

            // Iterate will produce error
            //foreach (var item in aEnumeratorObject)
            //{
            //    Console.WriteLine(item);
            //}

            // Use enumerator and movenext
            var enumerator = anEnumeratorObject;
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        IEnumerator<int> HelloEnumeratorAccessPrivateMember()
        {
            yield return 5;

            int i = 0;
            while (i != 2)
            {
                yield return i++;
            }

            somePrivateField = 25;
        }
    }
}
