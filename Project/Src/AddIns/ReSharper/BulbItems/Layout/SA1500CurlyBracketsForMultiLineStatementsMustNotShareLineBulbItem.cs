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

namespace StyleCop.ReSharper.BulbItems.Layout
{
    #region Using Directives

    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.TextControl;
    using JetBrains.ReSharper.Psi.CSharp.CodeStyle;
    using JetBrains.ReSharper.Psi.CodeStyle;

    using StyleCop.ReSharper.BulbItems.Framework;
    using StyleCop.ReSharper.CodeCleanup.Rules;
    using StyleCop.ReSharper.Core;

    #endregion

    public class SA1500CurlyBracketsForMultiLineStatementsMustNotShareLineBulbItem : V5BulbItemImpl
    {
        public override void ExecuteTransactionInner(ISolution solution, ITextControl textControl)
        {
            var element = Utils.GetElementAtCaret(solution, textControl);
            var containingBlock = element.GetContainingElement<IBlockNode>(true);

            if (containingBlock != null)
            {
                CSharpFormatterHelper.FormatterInstance.Format(containingBlock);
                new LayoutRules().CurlyBracketsForMultiLineStatementsMustNotShareLine(containingBlock.ToTreeNode());
            }
            else
            {
                var fieldDeclarationNode = element.GetContainingElement<IFieldDeclarationNode>(true);
                if (fieldDeclarationNode != null)
                {
                    CSharpFormatterHelper.FormatterInstance.Format(fieldDeclarationNode);
                    new LayoutRules().CurlyBracketsForMultiLineStatementsMustNotShareLine(fieldDeclarationNode.ToTreeNode());
                }
            }
        }
    }
}