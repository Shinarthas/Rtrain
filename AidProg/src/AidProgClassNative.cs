/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Sat Nov 29 19:03:07 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:AidProg,AidProgClass,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\VAHA\Documents\MATLAB\AidProg\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{AidProgClass:C:\Users\VAHA\Documents\MATLAB\AidProg.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace AidProgNative
{
  /// <summary>
  /// The AidProgClass class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\VAHA\Documents\MATLAB\AidProg.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class AidProgClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static AidProgClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "AidProg.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the AidProgClass class.
    /// </summary>
    public AidProgClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~AidProgClass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg()
    {
      return mcr.EvaluateFunction("AidProg", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f)
    {
      return mcr.EvaluateFunction("AidProg", f);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A)
    {
      return mcr.EvaluateFunction("AidProg", f, A);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A, Object b)
    {
      return mcr.EvaluateFunction("AidProg", f, A, b);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A, Object b, Object Aeq)
    {
      return mcr.EvaluateFunction("AidProg", f, A, b, Aeq);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A, Object b, Object Aeq, Object beq)
    {
      return mcr.EvaluateFunction("AidProg", f, A, b, Aeq, beq);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <param name="lb">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A, Object b, Object Aeq, Object beq, Object lb)
    {
      return mcr.EvaluateFunction("AidProg", f, A, b, Aeq, beq, lb);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <param name="lb">Input argument #6</param>
    /// <param name="ub">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object AidProg(Object f, Object A, Object b, Object Aeq, Object beq, Object 
                    lb, Object ub)
    {
      return mcr.EvaluateFunction("AidProg", f, A, b, Aeq, beq, lb, ub);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A, b);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A, Object b, Object Aeq)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A, b, Aeq);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A, Object b, Object Aeq, 
                      Object beq)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A, b, Aeq, beq);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <param name="lb">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A, Object b, Object Aeq, 
                      Object beq, Object lb)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A, b, Aeq, beq, lb);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the AidProg M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <param name="Aeq">Input argument #4</param>
    /// <param name="beq">Input argument #5</param>
    /// <param name="lb">Input argument #6</param>
    /// <param name="ub">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AidProg(int numArgsOut, Object f, Object A, Object b, Object Aeq, 
                      Object beq, Object lb, Object ub)
    {
      return mcr.EvaluateFunction(numArgsOut, "AidProg", f, A, b, Aeq, beq, lb, ub);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
