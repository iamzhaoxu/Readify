using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBasicHttpsBinding_IRedPill" in both code and config file together.
    [ServiceContract(Name = "IRedPill", Namespace = "http://KnockKnock.readify.net")]
    public interface IBasicHttpsBinding_IRedPill
    {

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhoAreYou", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhoAreYouResponse")]
        ContactDetails WhoAreYou();
        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c);
        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [FaultContract(typeof(System.ArgumentOutOfRangeException), Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeExceptionFault")]
        long FibonacciNumber(long n);

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [FaultContract(typeof(System.ArgumentNullException), Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault")]
        string ReverseWords(string s);
    }
}
