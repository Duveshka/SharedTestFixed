using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMultiReferenceShared
{
    internal interface Interface2
    {
    }
    internal interface Interface3 : Interface2
    {
    }

    public class class_1 : Interface3
    {

    }
    public class class_3 : class_1
    {

    }
}
