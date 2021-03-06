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
            ///	Applies a multi-layer long short-term memory (LSTM) RNN to an input
            ///	sequence.<br></br>
            ///	
            ///	For each element in the input sequence, each layer computes the following
            ///	function:
            ///	
            ///	\[\begin{array}{ll} \\
            ///	    i_t = \sigma(W_{ii} x_t + b_{ii} + W_{hi} h_{(t-1)} + b_{hi}) \\
            ///	    f_t = \sigma(W_{if} x_t + b_{if} + W_{hf} h_{(t-1)} + b_{hf}) \\
            ///	    g_t = \tanh(W_{ig} x_t + b_{ig} + W_{hg} h_{(t-1)} + b_{hg}) \\
            ///	    o_t = \sigma(W_{io} x_t + b_{io} + W_{ho} h_{(t-1)} + b_{ho}) \\
            ///	    c_t = f_t * c_{(t-1)} + i_t * g_t \\
            ///	    h_t = o_t * \tanh(c_t) \\
            ///	\end{array}
            ///	
            ///	\]
            ///	
            ///	where \(h_t\) is the hidden state at time t, \(c_t\) is the cell
            ///	state at time t, \(x_t\) is the input at time t, \(h_{(t-1)}\)
            ///	is the hidden state of the layer at time t-1 or the initial hidden
            ///	state at time 0, and \(i_t\), \(f_t\), \(g_t\),
            ///	\(o_t\) are the input, forget, cell, and output gates, respectively.<br></br>
            ///	
            ///	\(\sigma\) is the sigmoid function, and \(*\) is the Hadamard product.<br></br>
            ///	
            ///	In a multilayer LSTM, the input \(x^{(l)}_t\) of the \(l\) -th layer
            ///	(\(l &gt;= 2\)) is the hidden state \(h^{(l-1)}_t\) of the previous layer multiplied by
            ///	dropout \(\delta^{(l-1)}_t\) where each \(\delta^{(l-1)}_t\) is a Bernoulli random
            ///	variable which is \(0\) with probability dropout.
            /// </summary>
            public partial class LSTM : Module
            {
                // auto-generated class
                
                public LSTM(PyObject pyobj) : base(pyobj) { }
                
                public LSTM(Module other) : base(other.PyObject as PyObject) { }
                
                public LSTM(int input_size, int hidden_size, int num_layers = 1, bool bias = true, bool batch_first = false, int dropout = 0, bool bidirectional = false)
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
                    if (num_layers!=1) kwargs["num_layers"]=ToPython(num_layers);
                    if (bias!=true) kwargs["bias"]=ToPython(bias);
                    if (batch_first!=false) kwargs["batch_first"]=ToPython(batch_first);
                    if (dropout!=0) kwargs["dropout"]=ToPython(dropout);
                    if (bidirectional!=false) kwargs["bidirectional"]=ToPython(bidirectional);
                    dynamic py = __self__.InvokeMethod("LSTM", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
