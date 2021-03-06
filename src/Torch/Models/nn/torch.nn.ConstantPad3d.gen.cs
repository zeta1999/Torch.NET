// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Pads the input tensor boundaries with a constant value.<br></br>
            ///	
            ///	For N-dimensional padding, use torch.nn.functional.pad().
            /// </summary>
            public partial class ConstantPad3d : Module
            {
                // auto-generated class
                
                public ConstantPad3d(PyObject pyobj) : base(pyobj) { }
                
                public ConstantPad3d(Module other) : base(other.PyObject as PyObject) { }
                
                public ConstantPad3d(int padding = 0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (padding!=0) kwargs["padding"]=ToPython(padding);
                    dynamic py = __self__.InvokeMethod("ConstantPad3d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
