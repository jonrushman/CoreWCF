﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CoreWCF;

namespace ServiceContract
{
    [ServiceContract, XmlSerializerFormat]
    public interface SCInterfaceB_1144850
    {
        [OperationContract]
        string StringMethodB(string str);
    }
}
