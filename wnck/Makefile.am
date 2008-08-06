SUBDIRS= . glue
if ENABLE_WNCK
pkg = wnck
pkgversion = 2.20
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = wnck-sharp-1.0.pc
else
pkg = 
endif

API_VERSION = 2.20.0.0
INCLUDE_API = 
METADATA = metadata
SYMBOLS =
references = 
glue_args = --glue-includes=libwnck/libwnck.h --gluelib-name=wncksharpglue-2 --glue-filename=glue/generated.c

sources = 

customs =			\
	Tasklist.custom

add_dist = wnck-sharp-1.0.pc.in

include ../Makefile.include

