// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Diagnostics.Contracts;
using System;
using System.Runtime.InteropServices;

namespace System.Collections {
  // Summary:
  //     Defines methods to support the comparison of objects for equality.
  public partial interface IEqualityComparer {
    // Summary:
    //     Determines whether the specified objects are equal.
    //
    // Parameters:
    //   y:
    //     The second object to compare.
    //
    //   x:
    //     The first object to compare.
    //
    // Returns:
    //     true if the specified objects are equal; otherwise, false.
    //
    // Exceptions:
    //   System.ArgumentException:
    //     x and y are of different types and neither one can handle comparisons with
    //     the other.
    [Pure]
    bool Equals(object x, object y);
    //
    // Summary:
    //     Returns a hash code for the specified object.
    //
    // Parameters:
    //   obj:
    //     The System.Object for which a hash code is to be returned.
    //
    // Returns:
    //     A hash code for the specified object.
    //
    // Exceptions:
    //   System.ArgumentNullException:
    //     The type of obj is a reference type and obj is null.
    [Pure]
    int GetHashCode(object obj);
  }

  #region IEqualityComparer contract binding
  [ContractClass(typeof(IEqualityComparerContract))]
  public partial interface IEqualityComparer
  {

  }

  [ContractClassFor(typeof(IEqualityComparer))]
  abstract class IEqualityComparerContract : IEqualityComparer
  {
 
    #region IEqualityComparer Members

    bool IEqualityComparer.Equals(object x, object y)
    {
      throw new NotImplementedException();
    }

    int IEqualityComparer.GetHashCode(object obj)
    {
      Contract.Requires(obj != null);

      throw new NotImplementedException();
    }

    #endregion
  }
  #endregion

}
