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

namespace StyleCop.ReSharper.BulbItems.Documentation
{
    #region Using Directives

    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.TextControl;

    using StyleCop.ReSharper.BulbItems.Framework;
    using StyleCop.ReSharper.CodeCleanup.Rules;
    using StyleCop.ReSharper.Core;

    #endregion

    /// <summary>
    /// SA1642: ConstructorSummaryDocumentationMustBeginWithStandardTextBulbItem.
    /// </summary>
    public class SA1642ConstructorSummaryDocumentationMustBeginWithStandardTextBulbItem : V5BulbItemImpl
    {
        public override void ExecuteTransactionInner(ISolution solution, ITextControl textControl)
        {
            var element = Utils.GetElementAtCaret(solution, textControl);

            if (element != null)
            {
                var constructorDeclaration = element.GetContainingElement<IConstructorDeclaration>(true);
                if (constructorDeclaration != null)
                {
                    new DocumentationRules().EnsureConstructorSummaryDocBeginsWithStandardText(constructorDeclaration);
                }
            }
        }
    }
}