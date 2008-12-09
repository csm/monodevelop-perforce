/* p4api.i -- SWIG interface for p4api.
   Copyright (C) 2008 Pacific Biosciences. */


%module(directors="1") p4api
%{
#include <p4/clientapi.h>
%}

%feature(director) ClientUser;

%rename(OutputError2)  ClientUser::OutputError(char *);
%rename(OutputInfo2)   ClientUser::OutputInfo(char, char *);
%rename(OutputBinary2) ClientUser::OutputBinary(char *, int);
%rename(OutputText2)   ClientUser::OutputText(char *, int);
%rename(Help2)         ClientUser::Help(char *const *);

%typemap(in) (int argc, char *const * argv) {
  $1 = __arg;
  $2 = (char **) $input;
}

%typemap(ctype) (int argc, char *const * argv) "int __arg, char *const *"
%typemap(imtype) (int argc, char *const * argv) "int argc, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr)] string[]"
%typemap(cstype) (int argc, char *const * argv) "string[]"
%typemap(csin) (int argc, char *const * argv) "$csinput.Length, $csinput"

%typemap(imtype) unsigned char * "byte *"
%typemap(cstype) unsigned char * "byte *"
%typemap(in) unsigned char * %{ $1 = ($1_ltype) $input; %}
%typemap(csin) unsigned char * "$csinput"
%typemap(csout) unsigned char * {
  return $result;
}

%csmethodmodifiers ClientUser::OutputText(const unsigned char *data, int length) "public virtual unsafe"
%csmethodmodifiers ClientUser::OutputBinary(const unsigned char *data, int length) "public virtual unsafe"

%ignore ClientUser::OutputText(unsigned char *data, int length);
%ignore ClientUser::OutputBinary(unsigned char *data, int length);

%include "p4/error.h"
%include "p4/strbuf.h"
%include "p4/strdict.h"
%include "p4/clientuser.h"
%include "p4/clientapi.h"
