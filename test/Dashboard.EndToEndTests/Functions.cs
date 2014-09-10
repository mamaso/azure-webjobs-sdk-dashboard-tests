﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs;

namespace Dashboard.EndToEndTests
{
    public class SingleFunction
    {
        [NoAutomaticTrigger]
        public static void Function(bool fail)
        {
            if (fail)
            {
                throw new InvalidOperationException();
            }
        }
    }
}