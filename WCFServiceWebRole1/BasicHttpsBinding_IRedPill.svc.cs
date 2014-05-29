using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BasicHttpsBinding_IRedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BasicHttpsBinding_IRedPill.svc or BasicHttpsBinding_IRedPill.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace="http://KnockKnock.readify.net")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class BasicHttpsBinding_IRedPill : IBasicHttpsBinding_IRedPill
    {
        public ContactDetails WhoAreYou()
        {
            return new ContactDetails() { EmailAddress = "iamzhaoxu@gmail.com", FamilyName = "Zhao", GivenName = "Xu", PhoneNumber = "+61430106177" };
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return TriangleType.Error;
            }

            if (a == b || b == c || a == c)
            {
                if (a == b && b == c)
                {
                    return TriangleType.Equilateral;
                }
                else
                {
                    return TriangleType.Isosceles;
                }
            }
            else
            {
                return TriangleType.Scalene;
            }
        }


        public long FibonacciNumber(long n)
        {
            long unsignN = Math.Abs(n);
            long result = 0;
            if (unsignN <= 1)
            {
                result = unsignN;
            }
            else if(unsignN > 92)
            {
                ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("n", String.Format("Fib({0}{1}) will cause a 64-bit integer overflow.", n > 0 ? ">" : "<", 92));
                throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
            }
            else
            {
                long c = unsignN - 1;
                long a = 0;
                long b = 1;
                for (long i = 0; i < c; i++)
                {
                    result = b + a;
                    a = b;
                    b = result;
                }
            }

            if (n < 0 && unsignN % 2 == 0)
            {
                result = -result;
            }

            return result;
        }


        public string ReverseWords(string s)
        {
            if (s == null)
            {
                ArgumentNullException ex = new ArgumentNullException("s", "Value cannot be null.");
                throw new FaultException<ArgumentNullException>(ex, ex.Message);
            }

            StringBuilder buidler = new StringBuilder();
            Stack<char> wordStack = new Stack<char>();
            char[] array = s.ToCharArray();

            foreach(char c in array)
            {
                if (Char.IsWhiteSpace(c))
                {
                    while(wordStack.Count > 0)
                    {
                        buidler.Append(wordStack.Pop());
                    }
                    buidler.Append(c);
                }
                else
                {
                    wordStack.Push(c);
                }
            }

            while (wordStack.Count > 0)
            {
                buidler.Append(wordStack.Pop());
            }

            return buidler.ToString();
        }
    }
}
