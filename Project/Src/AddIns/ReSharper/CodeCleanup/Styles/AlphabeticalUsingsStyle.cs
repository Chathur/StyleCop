﻿//-----------------------------------------------------------------------
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

namespace StyleCop.ReSharper.CodeCleanup.Styles
{
    #region Using Directives

    using System.ComponentModel;

    #endregion

    /// <summary>
    /// Enumeration to define the behaviour of sorting Using Declarations.
    /// </summary>
    public enum AlphabeticalUsingsStyle
    {
        /// <summary>
        /// Do not change.
        /// </summary>
        [Description("Do not change")]
        Ignore,

        /// <summary>
        /// Alphabetical order.
        /// </summary>
        [Description("Alphabetical order")]
        Alphabetical
    }
}