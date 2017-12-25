﻿#region License
// MIT License
// 
// Copyright (c) 2017 Stefan Ebert
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXBusiness.D365MetaExplorer.Core
{
    /// <summary>
    /// This class provides demo data until proper load routine has been built.
    /// </summary>
    public static class DemoDataUtil
    {
        /// <summary>
        /// Creates a demo data modelstore without accessing any file.
        /// </summary>
        /// <param name="numPackages">Specified the maximum number of packages contained in the metadata.</param>
        /// <returns></returns>
        public static MetaDataStore GetModelStore(int numPackages)
        {
            MetaDataStore store = new MetaDataStore();

            Package p1 = new Package("System Base");
            p1.Models.Add(new Model("ModelBase1") { DisplayName = "Model Base-1" });
            p1.Models.Add(new Model("ModelBase2") { DisplayName = "Model Base-2" });
            store.Packages.Add(p1);

            if (numPackages >= 2)
            {
                Package p2 = new Package("System Foundation");
                p2.Models.Add(new Model("ModelFound1") { DisplayName = "Model Foundation-1" });
                p2.Models.Add(new Model("ModelFound2") { DisplayName = "Model Foundation-2" });
                store.Packages.Add(p2);
            }

            if (numPackages >= 3)
            {
                Package p3 = new Package("System Suite");
                p3.Models.Add(new Model("ModelSuite1") { DisplayName = "Model Suite-1" });
                p3.Models.Add(new Model("ModelSuite2") { DisplayName = "Model Suite-2" });
                p3.Models.Add(new Model("ModelSuite3") { DisplayName = "Model Suite-3" });
                p3.Models.Add(new Model("ModelSuite4") { DisplayName = "Model Suite-4" });
                store.Packages.Add(p3);
            }

            // TODO: Generate some references

            return store;
        }
    }
}
