namespace YieldExperiments
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        private int somePrivateField = 0x16;
        private static int someStaticField = 0x17;

        [IteratorStateMachine((Type) typeof(<HelloEnumerable>d__5))]
        private static IEnumerable<int> HelloEnumerable() => 
            new <HelloEnumerable>d__5(-2);

        [IteratorStateMachine((Type) typeof(<HelloEnumerableWithState>d__9))]
        private static IEnumerable<int> HelloEnumerableWithState() => 
            new <HelloEnumerableWithState>d__9(-2);

        [IteratorStateMachine((Type) typeof(<HelloEnumerator>d__7))]
        private static IEnumerator<int> HelloEnumerator() => 
            new <HelloEnumerator>d__7(0);

        [IteratorStateMachine((Type) typeof(<HelloEnumeratorAccessPrivateMember>d__15))]
        private IEnumerator<int> HelloEnumeratorAccessPrivateMember()
        {
            <HelloEnumeratorAccessPrivateMember>d__15 d__1 = new <HelloEnumeratorAccessPrivateMember>d__15(0);
            d__1.<>4__this = this;
            return d__1;
        }

        [IteratorStateMachine((Type) typeof(<HelloEnumeratorWhileTrue>d__13))]
        private static IEnumerator<int> HelloEnumeratorWhileTrue() => 
            new <HelloEnumeratorWhileTrue>d__13(0);

        [IteratorStateMachine((Type) typeof(<HelloEnumeratorWithCustomClass>d__11))]
        private static IEnumerator<MyCustomClass> HelloEnumeratorWithCustomClass() => 
            new <HelloEnumeratorWithCustomClass>d__11(0);

        private static void Main(string[] args)
        {
            Playground01();
            Playground02();
            Playground03();
            Playground04();
            Playground05();
            new Program().Playground06();
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
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
        }

        private static void Playground05()
        {
            Console.WriteLine("Playground02");
            IEnumerator<int> enumerator2 = HelloEnumeratorWhileTrue();
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
        }

        private void Playground06()
        {
            Console.WriteLine("Playground02");
            IEnumerator<int> enumerator2 = this.HelloEnumeratorAccessPrivateMember();
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
            enumerator2.MoveNext();
            Console.WriteLine(enumerator2.Current);
        }

        [CompilerGenerated]
        private sealed class <HelloEnumerable>d__5 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            private int <>l__initialThreadId;

            [DebuggerHidden]
            public <HelloEnumerable>d__5(int <>1__state)
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
                Program.<HelloEnumerable>d__5 d__;
                if ((this.<>1__state != -2) || (this.<>l__initialThreadId != Environment.CurrentManagedThreadId))
                {
                    d__ = new Program.<HelloEnumerable>d__5(0);
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
        private sealed class <HelloEnumerableWithState>d__9 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            private int <>l__initialThreadId;
            private int <fooVariable>5__1;

            [DebuggerHidden]
            public <HelloEnumerableWithState>d__9(int <>1__state)
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
                Program.<HelloEnumerableWithState>d__9 d__;
                if ((this.<>1__state != -2) || (this.<>l__initialThreadId != Environment.CurrentManagedThreadId))
                {
                    d__ = new Program.<HelloEnumerableWithState>d__9(0);
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
        private sealed class <HelloEnumerator>d__7 : IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;

            [DebuggerHidden]
            public <HelloEnumerator>d__7(int <>1__state)
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
        private sealed class <HelloEnumeratorAccessPrivateMember>d__15 : IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            public Program <>4__this;
            private int <i>5__1;

            [DebuggerHidden]
            public <HelloEnumeratorAccessPrivateMember>d__15(int <>1__state)
            {
                this.<>1__state = <>1__state;
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
                        this.<i>5__1 = 0;
                        break;

                    case 2:
                        this.<>1__state = -1;
                        break;

                    default:
                        return false;
                }
                if (this.<i>5__1 == 2)
                {
                    this.<>4__this.somePrivateField = 0x19;
                    return false;
                }
                int num2 = this.<i>5__1;
                this.<i>5__1 = num2 + 1;
                this.<>2__current = num2;
                this.<>1__state = 2;
                return true;
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
        private sealed class <HelloEnumeratorWhileTrue>d__13 : IEnumerator<int>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private int <>2__current;
            private int <i>5__1;

            [DebuggerHidden]
            public <HelloEnumeratorWhileTrue>d__13(int <>1__state)
            {
                this.<>1__state = <>1__state;
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
                        this.<i>5__1 = 0;
                        break;

                    case 2:
                        this.<>1__state = -1;
                        break;

                    default:
                        return false;
                }
                if (this.<i>5__1 == 2)
                {
                    Program.someStaticField = 0x19;
                    return false;
                }
                int num2 = this.<i>5__1;
                this.<i>5__1 = num2 + 1;
                this.<>2__current = num2;
                this.<>1__state = 2;
                return true;
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
        private sealed class <HelloEnumeratorWithCustomClass>d__11 : IEnumerator<Program.MyCustomClass>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private Program.MyCustomClass <>2__current;
            private Program.MyCustomClass <myCustomObj>5__1;
            private int <i>5__2;

            [DebuggerHidden]
            public <HelloEnumeratorWithCustomClass>d__11(int <>1__state)
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
                        this.<myCustomObj>5__1 = new Program.MyCustomClass();
                        this.<myCustomObj>5__1.SomeFieldName = 3;
                        this.<>2__current = this.<myCustomObj>5__1;
                        this.<>1__state = 2;
                        return true;

                    case 2:
                        this.<>1__state = -1;
                        this.<myCustomObj>5__1.SomeFieldName = -3;
                        this.<>2__current = this.<myCustomObj>5__1;
                        this.<>1__state = 3;
                        return true;

                    case 3:
                        this.<>1__state = -1;
                        this.<i>5__2 = this.<myCustomObj>5__1.SomeFieldName;
                        break;

                    case 4:
                        this.<>1__state = -1;
                        break;

                    default:
                        return false;
                }
                if (this.<i>5__2 == 0)
                {
                    return false;
                }
                int num2 = this.<i>5__2 + 1;
                this.<i>5__2 = num2;
                this.<>2__current = null;
                this.<>1__state = 4;
                return true;
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

