namespace YieldExperiments
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        [IteratorStateMachine((Type) typeof(<HelloEnumerable>d__3))]
        private static IEnumerable<int> HelloEnumerable() => 
            new <HelloEnumerable>d__3(-2);

        [IteratorStateMachine((Type) typeof(<HelloEnumerableWithState>d__7))]
        private static IEnumerable<int> HelloEnumerableWithState() => 
            new <HelloEnumerableWithState>d__7(-2);

        [IteratorStateMachine((Type) typeof(<HelloEnumerator>d__5))]
        private static IEnumerator<int> HelloEnumerator() => 
            new <HelloEnumerator>d__5(0);

        [IteratorStateMachine((Type) typeof(<HelloEnumeratorWithCustomClass>d__9))]
        private static IEnumerator<MyCustomClass> HelloEnumeratorWithCustomClass() => 
            new <HelloEnumeratorWithCustomClass>d__9(0);

        private static void Main(string[] args)
        {
            Playground01();
            Playground02();
            Playground03();
            Playground04();
        }

        private static void Playground01()
        {
            Console.WriteLine("Playground01");
            IEnumerable<int> enumerable = HelloEnumerable();
            foreach (int num in enumerable)
            {
                Console.WriteLine(num);
            }
            IEnumerator<int> enumerator = enumerable.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        private static void Playground02()
        {
            Console.WriteLine("Playground02");
            IEnumerator<int> enumerator2 = HelloEnumerator();
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
        }

        private static void Playground03()
        {
            Console.WriteLine("Playground03");
            IEnumerable<int> enumerable = HelloEnumerableWithState();
            foreach (int num in enumerable)
            {
                Console.WriteLine(num);
            }
            IEnumerator<int> enumerator = enumerable.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        private static void Playground04()
        {
            Console.WriteLine("Playground04");
            IEnumerator<MyCustomClass> enumerator2 = HelloEnumeratorWithCustomClass();
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
        }

        [CompilerGenerated]
        private sealed class <HelloEnumerable>d__3 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            private int <>l__initialThreadId;

            [DebuggerHidden]
            public <HelloEnumerable>d__3(int <>1__state)
            {
                this.<>1__state = <>1__state;
                this.<>l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            private bool MoveNext()
            {
                switch (this.<>1__state)
                {
                    case 0:
                        this.<>1__state = -1;
                        this.<>2__current = 5;
                        this.<>1__state = 1;
                        return true;

                    case 1:
                        this.<>1__state = -1;
                        this.<>2__current = 7;
                        this.<>1__state = 2;
                        return true;

                    case 2:
                        this.<>1__state = -1;
                        this.<>2__current = 9;
                        this.<>1__state = 3;
                        return true;

                    case 3:
                        this.<>1__state = -1;
                        return false;
                }
                return false;
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                Program.<HelloEnumerable>d__3 d__;
                if ((this.<>1__state != -2) || (this.<>l__initialThreadId != Environment.CurrentManagedThreadId))
                {
                    d__ = new Program.<HelloEnumerable>d__3(0);
                }
                else
                {
                    this.<>1__state = 0;
                    d__ = this;
                }
                return d__;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator() => 
                (IEnumerator) this.System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            int IEnumerator<int>.Current =>
                this.<>2__current;

            object IEnumerator.Current =>
                (int) this.<>2__current;
        }

        [CompilerGenerated]
        private sealed class <HelloEnumerableWithState>d__7 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            private int <>l__initialThreadId;
            private int <fooVariable>5__1;

            [DebuggerHidden]
            public <HelloEnumerableWithState>d__7(int <>1__state)
            {
                this.<>1__state = <>1__state;
                this.<>l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            private bool MoveNext()
            {
                int num2;
                switch (this.<>1__state)
                {
                    case 0:
                        this.<>1__state = -1;
                        this.<fooVariable>5__1 = 0;
                        this.<>2__current = this.<fooVariable>5__1;
                        this.<>1__state = 1;
                        return true;

                    case 1:
                        this.<>1__state = -1;
                        num2 = this.<fooVariable>5__1 + 1;
                        this.<fooVariable>5__1 = num2;
                        this.<>2__current = this.<fooVariable>5__1;
                        this.<>1__state = 2;
                        return true;

                    case 2:
                        this.<>1__state = -1;
                        num2 = this.<fooVariable>5__1 + 1;
                        this.<fooVariable>5__1 = num2;
                        this.<>2__current = this.<fooVariable>5__1;
                        this.<>1__state = 3;
                        return true;

                    case 3:
                        this.<>1__state = -1;
                        return false;
                }
                return false;
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                Program.<HelloEnumerableWithState>d__7 d__;
                if ((this.<>1__state != -2) || (this.<>l__initialThreadId != Environment.CurrentManagedThreadId))
                {
                    d__ = new Program.<HelloEnumerableWithState>d__7(0);
                }
                else
                {
                    this.<>1__state = 0;
                    d__ = this;
                }
                return d__;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator() => 
                (IEnumerator) this.System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            int IEnumerator<int>.Current =>
                this.<>2__current;

            object IEnumerator.Current =>
                (int) this.<>2__current;
        }

        [CompilerGenerated]
        private sealed class <HelloEnumerator>d__5 : IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;

            [DebuggerHidden]
            public <HelloEnumerator>d__5(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            private bool MoveNext()
            {
                switch (this.<>1__state)
                {
                    case 0:
                        this.<>1__state = -1;
                        this.<>2__current = 1;
                        this.<>1__state = 1;
                        return true;

                    case 1:
                        this.<>1__state = -1;
                        this.<>2__current = 3;
                        this.<>1__state = 2;
                        return true;

                    case 2:
                        this.<>1__state = -1;
                        this.<>2__current = 5;
                        this.<>1__state = 3;
                        return true;

                    case 3:
                        this.<>1__state = -1;
                        return false;
                }
                return false;
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            int IEnumerator<int>.Current =>
                this.<>2__current;

            object IEnumerator.Current =>
                (int) this.<>2__current;
        }

        [CompilerGenerated]
        private sealed class <HelloEnumeratorWithCustomClass>d__9 : IEnumerator<Program.MyCustomClass>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private Program.MyCustomClass <>2__current;
            private Program.MyCustomClass <obj>5__1;

            [DebuggerHidden]
            public <HelloEnumeratorWithCustomClass>d__9(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            private bool MoveNext()
            {
                switch (this.<>1__state)
                {
                    case 0:
                    {
                        this.<>1__state = -1;
                        Program.MyCustomClass class1 = new Program.MyCustomClass();
                        class1.SomeFieldName = 5;
                        this.<>2__current = class1;
                        this.<>1__state = 1;
                        return true;
                    }
                    case 1:
                        this.<>1__state = -1;
                        this.<obj>5__1 = new Program.MyCustomClass();
                        this.<obj>5__1.SomeFieldName = 3;
                        this.<>2__current = this.<obj>5__1;
                        this.<>1__state = 2;
                        return true;

                    case 2:
                        this.<>1__state = -1;
                        this.<obj>5__1.SomeFieldName = -7;
                        this.<>2__current = this.<obj>5__1;
                        this.<>1__state = 3;
                        return true;

                    case 3:
                        this.<>1__state = -1;
                        return false;
                }
                return false;
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            Program.MyCustomClass IEnumerator<Program.MyCustomClass>.Current =>
                this.<>2__current;

            object IEnumerator.Current =>
                this.<>2__current;
        }

        private class MyCustomClass
        {
            private int someFieldName = 0;

            public int SomeFieldName
            {
                get => 
                    this.someFieldName;
                set
                {
                    this.someFieldName = value;
                    Console.WriteLine(this.someFieldName);
                }
            }
        }
    }
}

