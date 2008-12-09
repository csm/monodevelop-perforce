/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.33
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace P4API {

using System;
using System.Runtime.InteropServices;

public class ClientUser : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClientUser(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ClientUser obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClientUser() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        p4apiPINVOKE.delete_ClientUser(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ClientUser() : this(p4apiPINVOKE.new_ClientUser(), true) {
    SwigDirectorConnect();
  }

  public virtual void InputData(StrBuf strbuf, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_InputData(swigCPtr, StrBuf.getCPtr(strbuf), Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_InputDataSwigExplicitClientUser(swigCPtr, StrBuf.getCPtr(strbuf), Error.getCPtr(e));
  }

  public virtual void HandleError(Error err) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_HandleError(swigCPtr, Error.getCPtr(err)); else p4apiPINVOKE.ClientUser_HandleErrorSwigExplicitClientUser(swigCPtr, Error.getCPtr(err));
  }

  public virtual void Message(Error err) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Message(swigCPtr, Error.getCPtr(err)); else p4apiPINVOKE.ClientUser_MessageSwigExplicitClientUser(swigCPtr, Error.getCPtr(err));
  }

  public virtual void OutputError(string errBuf) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_OutputError(swigCPtr, errBuf); else p4apiPINVOKE.ClientUser_OutputErrorSwigExplicitClientUser(swigCPtr, errBuf);
  }

  public virtual void OutputInfo(char level, string data) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_OutputInfo(swigCPtr, level, data); else p4apiPINVOKE.ClientUser_OutputInfoSwigExplicitClientUser(swigCPtr, level, data);
  }

  public virtual unsafe void OutputBinary(sbyte * data, int length) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_OutputBinary(swigCPtr, data, length); else p4apiPINVOKE.ClientUser_OutputBinarySwigExplicitClientUser(swigCPtr, data, length);
  }

  public virtual unsafe void OutputText(sbyte * data, int length) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_OutputText(swigCPtr, data, length); else p4apiPINVOKE.ClientUser_OutputTextSwigExplicitClientUser(swigCPtr, data, length);
  }

  public virtual void OutputStat(StrDict varList) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_OutputStat(swigCPtr, StrDict.getCPtr(varList)); else p4apiPINVOKE.ClientUser_OutputStatSwigExplicitClientUser(swigCPtr, StrDict.getCPtr(varList));
  }

  public virtual void Prompt(StrPtr msg, StrBuf rsp, int noEcho, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Prompt(swigCPtr, StrPtr.getCPtr(msg), StrBuf.getCPtr(rsp), noEcho, Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_PromptSwigExplicitClientUser(swigCPtr, StrPtr.getCPtr(msg), StrBuf.getCPtr(rsp), noEcho, Error.getCPtr(e));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ErrorPause(string errBuf, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_ErrorPause(swigCPtr, errBuf, Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_ErrorPauseSwigExplicitClientUser(swigCPtr, errBuf, Error.getCPtr(e));
  }

  public virtual void Edit(SWIGTYPE_p_FileSys f1, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Edit__SWIG_0(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(f1), Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_EditSwigExplicitClientUser__SWIG_0(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(f1), Error.getCPtr(e));
  }

  public virtual void Diff(SWIGTYPE_p_FileSys f1, SWIGTYPE_p_FileSys f2, int doPage, string diffFlags, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Diff(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(f1), SWIGTYPE_p_FileSys.getCPtr(f2), doPage, diffFlags, Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_DiffSwigExplicitClientUser(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(f1), SWIGTYPE_p_FileSys.getCPtr(f2), doPage, diffFlags, Error.getCPtr(e));
  }

  public virtual void Merge(SWIGTYPE_p_FileSys all_your_base, SWIGTYPE_p_FileSys leg1, SWIGTYPE_p_FileSys leg2, SWIGTYPE_p_FileSys result, Error e) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Merge(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(all_your_base), SWIGTYPE_p_FileSys.getCPtr(leg1), SWIGTYPE_p_FileSys.getCPtr(leg2), SWIGTYPE_p_FileSys.getCPtr(result), Error.getCPtr(e)); else p4apiPINVOKE.ClientUser_MergeSwigExplicitClientUser(swigCPtr, SWIGTYPE_p_FileSys.getCPtr(all_your_base), SWIGTYPE_p_FileSys.getCPtr(leg1), SWIGTYPE_p_FileSys.getCPtr(leg2), SWIGTYPE_p_FileSys.getCPtr(result), Error.getCPtr(e));
  }

  public virtual int Resolve(SWIGTYPE_p_ClientMerge m, Error e) {
    int ret = ((this.GetType() == typeof(ClientUser)) ? p4apiPINVOKE.ClientUser_Resolve(swigCPtr, SWIGTYPE_p_ClientMerge.getCPtr(m), Error.getCPtr(e)) : p4apiPINVOKE.ClientUser_ResolveSwigExplicitClientUser(swigCPtr, SWIGTYPE_p_ClientMerge.getCPtr(m), Error.getCPtr(e)));
    return ret;
  }

  public virtual void Help(SWIGTYPE_p_p_char help) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Help(swigCPtr, SWIGTYPE_p_p_char.getCPtr(help)); else p4apiPINVOKE.ClientUser_HelpSwigExplicitClientUser(swigCPtr, SWIGTYPE_p_p_char.getCPtr(help));
  }

  public virtual SWIGTYPE_p_FileSys File(SWIGTYPE_p_FileSysType type) {
    IntPtr cPtr = ((this.GetType() == typeof(ClientUser)) ? p4apiPINVOKE.ClientUser_File(swigCPtr, SWIGTYPE_p_FileSysType.getCPtr(type)) : p4apiPINVOKE.ClientUser_FileSwigExplicitClientUser(swigCPtr, SWIGTYPE_p_FileSysType.getCPtr(type)));
    SWIGTYPE_p_FileSys ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_FileSys(cPtr, false);
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Finished() {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_Finished(swigCPtr); else p4apiPINVOKE.ClientUser_FinishedSwigExplicitClientUser(swigCPtr);
  }

  public StrDict varList {
    set {
      p4apiPINVOKE.ClientUser_varList_set(swigCPtr, StrDict.getCPtr(value));
    } 
    get {
      IntPtr cPtr = p4apiPINVOKE.ClientUser_varList_get(swigCPtr);
      StrDict ret = (cPtr == IntPtr.Zero) ? null : new StrDict(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Enviro enviro {
    set {
      p4apiPINVOKE.ClientUser_enviro_set(swigCPtr, SWIGTYPE_p_Enviro.getCPtr(value));
    } 
    get {
      IntPtr cPtr = p4apiPINVOKE.ClientUser_enviro_get(swigCPtr);
      SWIGTYPE_p_Enviro ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Enviro(cPtr, false);
      return ret;
    } 
  }

  public static void Edit(SWIGTYPE_p_FileSys f1, SWIGTYPE_p_Enviro env, Error e) {
    p4apiPINVOKE.ClientUser_Edit__SWIG_1(SWIGTYPE_p_FileSys.getCPtr(f1), SWIGTYPE_p_Enviro.getCPtr(env), Error.getCPtr(e));
  }

  public static void RunCmd(string command, string arg1, string arg2, string arg3, string arg4, string arg5, string pager, Error e) {
    p4apiPINVOKE.ClientUser_RunCmd(command, arg1, arg2, arg3, arg4, arg5, pager, Error.getCPtr(e));
  }

  public virtual void SetOutputCharset(int arg0) {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_SetOutputCharset(swigCPtr, arg0); else p4apiPINVOKE.ClientUser_SetOutputCharsetSwigExplicitClientUser(swigCPtr, arg0);
  }

  public virtual void DisableTmpCleanup() {
    if (this.GetType() == typeof(ClientUser)) p4apiPINVOKE.ClientUser_DisableTmpCleanup(swigCPtr); else p4apiPINVOKE.ClientUser_DisableTmpCleanupSwigExplicitClientUser(swigCPtr);
  }

  public virtual int OutputError2(string errBuf) {
    int ret = ((this.GetType() == typeof(ClientUser)) ? p4apiPINVOKE.ClientUser_OutputError2(swigCPtr, errBuf) : p4apiPINVOKE.ClientUser_OutputError2SwigExplicitClientUser(swigCPtr, errBuf));
    return ret;
  }

  public virtual int OutputInfo2(char level, string data) {
    int ret = ((this.GetType() == typeof(ClientUser)) ? p4apiPINVOKE.ClientUser_OutputInfo2(swigCPtr, level, data) : p4apiPINVOKE.ClientUser_OutputInfo2SwigExplicitClientUser(swigCPtr, level, data));
    return ret;
  }

  public virtual int Help2(SWIGTYPE_p_p_char help) {
    int ret = ((this.GetType() == typeof(ClientUser)) ? p4apiPINVOKE.ClientUser_Help2(swigCPtr, SWIGTYPE_p_p_char.getCPtr(help)) : p4apiPINVOKE.ClientUser_Help2SwigExplicitClientUser(swigCPtr, SWIGTYPE_p_p_char.getCPtr(help)));
    return ret;
  }

  private unsafe void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("InputData", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateClientUser_0(SwigDirectorInputData);
    if (SwigDerivedClassHasMethod("HandleError", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateClientUser_1(SwigDirectorHandleError);
    if (SwigDerivedClassHasMethod("Message", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateClientUser_2(SwigDirectorMessage);
    if (SwigDerivedClassHasMethod("OutputError", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateClientUser_3(SwigDirectorOutputError);
    if (SwigDerivedClassHasMethod("OutputInfo", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateClientUser_4(SwigDirectorOutputInfo);
    if (SwigDerivedClassHasMethod("OutputBinary", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateClientUser_5(SwigDirectorOutputBinary);
    if (SwigDerivedClassHasMethod("OutputText", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateClientUser_6(SwigDirectorOutputText);
    if (SwigDerivedClassHasMethod("OutputStat", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateClientUser_7(SwigDirectorOutputStat);
    if (SwigDerivedClassHasMethod("Prompt", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateClientUser_8(SwigDirectorPrompt);
    if (SwigDerivedClassHasMethod("ErrorPause", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateClientUser_9(SwigDirectorErrorPause);
    if (SwigDerivedClassHasMethod("Edit", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateClientUser_10(SwigDirectorEdit__SWIG_0);
    if (SwigDerivedClassHasMethod("Diff", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateClientUser_11(SwigDirectorDiff);
    if (SwigDerivedClassHasMethod("Merge", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateClientUser_12(SwigDirectorMerge);
    if (SwigDerivedClassHasMethod("Resolve", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateClientUser_13(SwigDirectorResolve);
    if (SwigDerivedClassHasMethod("Help", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateClientUser_14(SwigDirectorHelp);
    if (SwigDerivedClassHasMethod("File", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateClientUser_15(SwigDirectorFile);
    if (SwigDerivedClassHasMethod("Finished", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateClientUser_16(SwigDirectorFinished);
    if (SwigDerivedClassHasMethod("SetOutputCharset", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateClientUser_17(SwigDirectorSetOutputCharset);
    if (SwigDerivedClassHasMethod("DisableTmpCleanup", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateClientUser_18(SwigDirectorDisableTmpCleanup);
    if (SwigDerivedClassHasMethod("OutputError2", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateClientUser_19(SwigDirectorOutputError2);
    if (SwigDerivedClassHasMethod("OutputInfo2", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateClientUser_20(SwigDirectorOutputInfo2);
    if (SwigDerivedClassHasMethod("Help2", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateClientUser_21(SwigDirectorHelp2);
    p4apiPINVOKE.ClientUser_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ClientUser));
    return hasDerivedMethod;
  }

  private void SwigDirectorInputData(IntPtr strbuf, IntPtr e) {
    InputData(new StrBuf(strbuf, false), new Error(e, false));
  }

  private void SwigDirectorHandleError(IntPtr err) {
    HandleError(new Error(err, false));
  }

  private void SwigDirectorMessage(IntPtr err) {
    Message(new Error(err, false));
  }

  private void SwigDirectorOutputError(string errBuf) {
    OutputError(errBuf);
  }

  private void SwigDirectorOutputInfo(char level, string data) {
    OutputInfo(level, data);
  }

  private unsafe void SwigDirectorOutputBinary(sbyte * data, int length) {
    OutputBinary(data, length);
  }

  private unsafe void SwigDirectorOutputText(sbyte * data, int length) {
    OutputText(data, length);
  }

  private void SwigDirectorOutputStat(IntPtr varList) {
    OutputStat(new StrDict(varList, false));
  }

  private void SwigDirectorPrompt(IntPtr msg, IntPtr rsp, int noEcho, IntPtr e) {
    Prompt(new StrPtr(msg, false), new StrBuf(rsp, false), noEcho, new Error(e, false));
  }

  private void SwigDirectorErrorPause(string errBuf, IntPtr e) {
    ErrorPause(errBuf, new Error(e, false));
  }

  private void SwigDirectorEdit__SWIG_0(IntPtr f1, IntPtr e) {
    Edit(new SWIGTYPE_p_FileSys(f1, false), new Error(e, false));
  }

  private void SwigDirectorDiff(IntPtr f1, IntPtr f2, int doPage, string diffFlags, IntPtr e) {
    Diff(new SWIGTYPE_p_FileSys(f1, false), new SWIGTYPE_p_FileSys(f2, false), doPage, diffFlags, new Error(e, false));
  }

  private void SwigDirectorMerge(IntPtr all_your_base, IntPtr leg1, IntPtr leg2, IntPtr result, IntPtr e) {
    Merge(new SWIGTYPE_p_FileSys(all_your_base, false), new SWIGTYPE_p_FileSys(leg1, false), new SWIGTYPE_p_FileSys(leg2, false), new SWIGTYPE_p_FileSys(result, false), new Error(e, false));
  }

  private int SwigDirectorResolve(IntPtr m, IntPtr e) {
    return Resolve(new SWIGTYPE_p_ClientMerge(m, false), new Error(e, false));
  }

  private void SwigDirectorHelp(IntPtr help) {
    Help(new SWIGTYPE_p_p_char(help, false));
  }

  private IntPtr SwigDirectorFile(IntPtr type) {
    return SWIGTYPE_p_FileSys.getCPtr(File(new SWIGTYPE_p_FileSysType(type, false))).Handle;
  }

  private void SwigDirectorFinished() {
    Finished();
  }

  private void SwigDirectorSetOutputCharset(int arg0) {
    SetOutputCharset(arg0);
  }

  private void SwigDirectorDisableTmpCleanup() {
    DisableTmpCleanup();
  }

  private int SwigDirectorOutputError2(string errBuf) {
    return OutputError2(errBuf);
  }

  private int SwigDirectorOutputInfo2(char level, string data) {
    return OutputInfo2(level, data);
  }

  private int SwigDirectorHelp2(IntPtr help) {
    return Help2(new SWIGTYPE_p_p_char(help, false));
  }

  public delegate void SwigDelegateClientUser_0(IntPtr strbuf, IntPtr e);
  public delegate void SwigDelegateClientUser_1(IntPtr err);
  public delegate void SwigDelegateClientUser_2(IntPtr err);
  public delegate void SwigDelegateClientUser_3(string errBuf);
  public delegate void SwigDelegateClientUser_4(char level, string data);
  public unsafe delegate void SwigDelegateClientUser_5(sbyte * data, int length);
  public unsafe delegate void SwigDelegateClientUser_6(sbyte * data, int length);
  public delegate void SwigDelegateClientUser_7(IntPtr varList);
  public delegate void SwigDelegateClientUser_8(IntPtr msg, IntPtr rsp, int noEcho, IntPtr e);
  public delegate void SwigDelegateClientUser_9(string errBuf, IntPtr e);
  public delegate void SwigDelegateClientUser_10(IntPtr f1, IntPtr e);
  public delegate void SwigDelegateClientUser_11(IntPtr f1, IntPtr f2, int doPage, string diffFlags, IntPtr e);
  public delegate void SwigDelegateClientUser_12(IntPtr all_your_base, IntPtr leg1, IntPtr leg2, IntPtr result, IntPtr e);
  public delegate int SwigDelegateClientUser_13(IntPtr m, IntPtr e);
  public delegate void SwigDelegateClientUser_14(IntPtr help);
  public delegate IntPtr SwigDelegateClientUser_15(IntPtr type);
  public delegate void SwigDelegateClientUser_16();
  public delegate void SwigDelegateClientUser_17(int arg0);
  public delegate void SwigDelegateClientUser_18();
  public delegate int SwigDelegateClientUser_19(string errBuf);
  public delegate int SwigDelegateClientUser_20(char level, string data);
  public delegate int SwigDelegateClientUser_21(IntPtr help);

  private SwigDelegateClientUser_0 swigDelegate0;
  private SwigDelegateClientUser_1 swigDelegate1;
  private SwigDelegateClientUser_2 swigDelegate2;
  private SwigDelegateClientUser_3 swigDelegate3;
  private SwigDelegateClientUser_4 swigDelegate4;
  private SwigDelegateClientUser_5 swigDelegate5;
  private SwigDelegateClientUser_6 swigDelegate6;
  private SwigDelegateClientUser_7 swigDelegate7;
  private SwigDelegateClientUser_8 swigDelegate8;
  private SwigDelegateClientUser_9 swigDelegate9;
  private SwigDelegateClientUser_10 swigDelegate10;
  private SwigDelegateClientUser_11 swigDelegate11;
  private SwigDelegateClientUser_12 swigDelegate12;
  private SwigDelegateClientUser_13 swigDelegate13;
  private SwigDelegateClientUser_14 swigDelegate14;
  private SwigDelegateClientUser_15 swigDelegate15;
  private SwigDelegateClientUser_16 swigDelegate16;
  private SwigDelegateClientUser_17 swigDelegate17;
  private SwigDelegateClientUser_18 swigDelegate18;
  private SwigDelegateClientUser_19 swigDelegate19;
  private SwigDelegateClientUser_20 swigDelegate20;
  private SwigDelegateClientUser_21 swigDelegate21;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(StrBuf), typeof(Error) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(Error) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(Error) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(char), typeof(string) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(sbyte).MakePointerType(), typeof(int) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(sbyte).MakePointerType(), typeof(int) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(StrDict) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(StrPtr), typeof(StrBuf), typeof(int), typeof(Error) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(string), typeof(Error) };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(SWIGTYPE_p_FileSys), typeof(Error) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(SWIGTYPE_p_FileSys), typeof(SWIGTYPE_p_FileSys), typeof(int), typeof(string), typeof(Error) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(SWIGTYPE_p_FileSys), typeof(SWIGTYPE_p_FileSys), typeof(SWIGTYPE_p_FileSys), typeof(SWIGTYPE_p_FileSys), typeof(Error) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(SWIGTYPE_p_ClientMerge), typeof(Error) };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(SWIGTYPE_p_p_char) };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(SWIGTYPE_p_FileSysType) };
  private static Type[] swigMethodTypes16 = new Type[] {  };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes18 = new Type[] {  };
  private static Type[] swigMethodTypes19 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(char), typeof(string) };
  private static Type[] swigMethodTypes21 = new Type[] { typeof(SWIGTYPE_p_p_char) };
}

}
