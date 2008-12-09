# Makefile for P4API wrapper.
# Copyright (C) 2008  Pacific Biosciences.

ARCHSYS = linux26-x86_64
P4APIHOME = ../../../ThirdParty/p4api/$(ARCHSYS)/p4api-2008.1.156517.BETA

DESTDIR ?= .dest

CXX = g++
CFLAGS = -g -O2 -fPIC
CPPFLAGS = -I$(P4APIHOME)/include
LDFLAGS = -L$(P4APIHOME)/lib
LIBS = -lclient -lrpc -lsupp
SWIG = swig
SWIGFLAGS = -csharp -namespace P4API -c++ -I$(P4APIHOME)/include
CSC = gmcs
CSCFLAGS = -target:library -debug -unsafe

all: lib lib/libp4api.so lib/P4API.dll

lib:
	mkdir -p lib

lib/libp4api.so: src/p4api_wrap.o
	$(CXX) $(CFLAGS) -shared -o $@ $< $(LDFLAGS) $(LIBS)

lib/P4API.dll:
	$(CSC) $(CSCFLAGS) -out:$@ P4API/*.cs

src/p4api_wrap.o: src/p4api_wrap.cc
	$(CXX) $(CFLAGS) $(CPPFLAGS) -c -o $@ $<

dotnet-all: P4API.mk
	make -f P4API.mk all

P4API.mk: P4API.csproj
	csproj2make -o P4API.mk P4API.csproj

install: all
	install -m 0644 lib/libp4api.so lib/P4API.dll $(DESTDIR)

#generated/.swig-stamp generated/p4api_wrap.cc: generated/P4API src/p4api.i
#	$(SWIG) $(SWIGFLAGS) -o generated/p4api_wrap.cc -outdir generated/P4API src/p4api.i
#	touch generated/.swig-stamp

#generated/P4API:
#	mkdir -p generated/P4API
