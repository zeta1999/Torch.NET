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
            ///	A gated recurrent unit (GRU) cell
            ///	
            ///	\[\begin{array}{ll}
            ///	r = \sigma(W_{ir} x + b_{ir} + W_{hr} h + b_{hr}) \\
            ///	z = \sigma(W_{iz} x + b_{iz} + W_{hz} h + b_{hz}) \\
            ///	n = \tanh(W_{in} x + b_{in} + r * (W_{hn} h + b_{hn})) \\
            ///	h' = (1 - z) * n + z * h
            ///	\end{array}\]
            ///	
            ///	where \(\sigma\) is the sigmoid function, and \(*\) is the Hadamard product.
            /// </summary>
            public partial class GRUCell : Module
            {
                // auto-generated class
                
                public GRUCell(PyObject pyobj) : base(pyobj) { }
                
                public GRUCell(Module other) : base(other.PyObject as PyObject) { }
                
                public GRUCell(int input_size, int hidden_size, bool bias = true)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        input_size,
                        hidden_size,
                    });
                    var kwargs=new PyDict();
                    if (bias!=true) kwargs["bias"]=ToPython(bias);
                    dynamic py = __self__.InvokeMethod("GRUCell", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}