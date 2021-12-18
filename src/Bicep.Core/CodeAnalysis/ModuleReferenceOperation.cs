// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Bicep.Core.Semantics;

namespace Bicep.Core.CodeAnalysis
{
    public record ModuleReferenceOperation(
        ModuleSymbol Symbol,
        IndexReplacementContext? IndexContext) : Operation
    {
        public override void Accept(IOperationVisitor visitor)
            => visitor.VisitModuleReferenceOperation(this);
    }
}
