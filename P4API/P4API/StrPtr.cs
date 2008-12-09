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

public class StrPtr : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StrPtr(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StrPtr obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StrPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        p4apiPINVOKE.delete_StrPtr(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public string Text() {
    string ret = p4apiPINVOKE.StrPtr_Text(swigCPtr);
    return ret;
  }

  public string Value() {
    string ret = p4apiPINVOKE.StrPtr_Value(swigCPtr);
    return ret;
  }

  public int Length() {
    int ret = p4apiPINVOKE.StrPtr_Length(swigCPtr);
    return ret;
  }

  public string End() {
    string ret = p4apiPINVOKE.StrPtr_End(swigCPtr);
    return ret;
  }

  public int Atoi() {
    int ret = p4apiPINVOKE.StrPtr_Atoi__SWIG_0(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_P4INT64 Atoi64() {
    SWIGTYPE_p_P4INT64 ret = new SWIGTYPE_p_P4INT64(p4apiPINVOKE.StrPtr_Atoi64__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void SetLength() {
    p4apiPINVOKE.StrPtr_SetLength__SWIG_0(swigCPtr);
  }

  public void SetLength(int len) {
    p4apiPINVOKE.StrPtr_SetLength__SWIG_1(swigCPtr, len);
  }

  public void SetEnd(string p) {
    p4apiPINVOKE.StrPtr_SetEnd(swigCPtr, p);
  }

  public int Compare(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_Compare(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CCompare(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_CCompare__SWIG_0(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SCompare(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_SCompare__SWIG_0(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int CCompare(string a, string b) {
    int ret = p4apiPINVOKE.StrPtr_CCompare__SWIG_1(a, b);
    return ret;
  }

  public static int SCompare(string a, string b) {
    int ret = p4apiPINVOKE.StrPtr_SCompare__SWIG_1(a, b);
    return ret;
  }

  public static int SCompare(byte a, byte b) {
    int ret = p4apiPINVOKE.StrPtr_SCompare__SWIG_2(a, b);
    return ret;
  }

  public static int SEqual(byte a, byte b) {
    int ret = p4apiPINVOKE.StrPtr_SEqual(a, b);
    return ret;
  }

  public int SCompareN(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_SCompareN(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int XCompare(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_XCompare__SWIG_0(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int XCompare(string a, string b) {
    int ret = p4apiPINVOKE.StrPtr_XCompare__SWIG_1(a, b);
    return ret;
  }

  public int XCompareN(StrPtr s) {
    int ret = p4apiPINVOKE.StrPtr_XCompareN(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string Contains(StrPtr s) {
    string ret = p4apiPINVOKE.StrPtr_Contains(swigCPtr, StrPtr.getCPtr(s));
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void StrCpy(string b) {
    p4apiPINVOKE.StrPtr_StrCpy(swigCPtr, b);
  }

  public void StrCat(string b) {
    p4apiPINVOKE.StrPtr_StrCat(swigCPtr, b);
  }

  public static int Atoi(string b) {
    int ret = p4apiPINVOKE.StrPtr_Atoi__SWIG_1(b);
    return ret;
  }

  public static string Itoa(int v, string e) {
    string ret = p4apiPINVOKE.StrPtr_Itoa(v, e);
    return ret;
  }

  public static SWIGTYPE_p_P4INT64 Atoi64(string buffer) {
    SWIGTYPE_p_P4INT64 ret = new SWIGTYPE_p_P4INT64(p4apiPINVOKE.StrPtr_Atoi64__SWIG_1(buffer), true);
    return ret;
  }

  public static string Itoa64(SWIGTYPE_p_P4INT64 v, string endbuf) {
    string ret = p4apiPINVOKE.StrPtr_Itoa64(SWIGTYPE_p_P4INT64.getCPtr(v), endbuf);
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int CaseFolding() {
    int ret = p4apiPINVOKE.StrPtr_CaseFolding();
    return ret;
  }

  public static int CaseIgnored() {
    int ret = p4apiPINVOKE.StrPtr_CaseIgnored();
    return ret;
  }

  public static int CaseHybrid() {
    int ret = p4apiPINVOKE.StrPtr_CaseHybrid();
    return ret;
  }

  public static void SetCaseFolding(int c) {
    p4apiPINVOKE.StrPtr_SetCaseFolding(c);
  }

  public static StrPtr.CaseUse CaseUsage() {
    StrPtr.CaseUse ret = (StrPtr.CaseUse)p4apiPINVOKE.StrPtr_CaseUsage();
    return ret;
  }

  public StrPtr() : this(p4apiPINVOKE.new_StrPtr(), true) {
  }

  public enum CaseUse {
    ST_UNIX,
    ST_WINDOWS,
    ST_HYBRID
  }

}

}