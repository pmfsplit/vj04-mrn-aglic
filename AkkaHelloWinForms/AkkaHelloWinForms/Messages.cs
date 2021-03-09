using System;
using System.Collections.Generic;
using System.Text;

namespace AkkaHelloWinForms
{
    class Messages
    {
        public class Write
        {
            public string Content { get; }
            public Write(string content)
            {
                Content = content;
            }
        }

        public class Add
        {
            public int A { get; }
            public int B { get; }

            public Add(int a, int b)
            {
                A = a;
                B = b;
            }
        }
    }
}
