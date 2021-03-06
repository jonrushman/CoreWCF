﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CoreWCF.IdentityModel.Claims;

namespace CoreWCF.IdentityModel.Policy
{
    // Issues claimsets whose conditions (if any) have been evaluated.
    public interface IAuthorizationPolicy : IAuthorizationComponent
    {
        // TODO: Consider changing to System.Security.Claims, need to get community feedback
        ClaimSet Issuer { get; }

        // Evaluates conditions (if any) against the context, may add grants to the context
        // Return 'false' if for this evaluation, should be called again if claims change. (eg. not done)
        // Return 'true' if no more claims will be added regardless of changes for this evaluation (eg. done).
        // 'state' is good for this evaluation only. Will be null if starting again.
        // Implementations should expect to be called multiple times on different threads.
        bool Evaluate(EvaluationContext evaluationContext, ref object state);
    }
}