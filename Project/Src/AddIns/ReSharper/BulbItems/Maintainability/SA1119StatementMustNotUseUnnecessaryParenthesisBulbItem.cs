//-----------------------------------------------------------------------
// <copyright file="">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
//-----------------------------------------------------------------------

namespace StyleCop.ReSharper.BulbItems.Maintainability
{
    #region Using Directives

    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.TextControl;

    using StyleCop.ReSharper.BulbItems.Framework;
    using StyleCop.ReSharper.CodeCleanup.Rules;
    using StyleCop.ReSharper.Core;

    #endregion

    internal class SA1119StatementMustNotUseUnnecessaryParenthesisBulbItem : V5BulbItemImpl
    {
        public override void ExecuteTransactionInner(ISolution solution, ITextControl textControl)
        {
            var tokensForLine = Utils.GetTokensForLineFromTextControl(solution, textControl);

            foreach (var tokenNode in tokensForLine)
            {
                var parenthesizedExpressionNode = tokenNode.GetContainingElement<IParenthesizedExpressionNode>(true);
                MaintainabilityRules.RemoveParenthesisFromNode(parenthesizedExpressionNode);
            }
        }
    }
}