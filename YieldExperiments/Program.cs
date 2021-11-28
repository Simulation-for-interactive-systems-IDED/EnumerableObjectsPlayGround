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

        static void Main(string[] args)
        {
            Playground01();
            Playground02();
            Playground03();
            Playground04();
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
        }

        static IEnumerator<MyCustomClass> HelloEnumeratorWithCustomClass()
        {
            yield return new MyCustomClass() { SomeFieldName = 5 };

            var obj = new MyCustomClass();
            obj.SomeFieldName = 3;
            yield return obj;

            obj.SomeFieldName = -7;
            yield return obj;
        }
    }
}
